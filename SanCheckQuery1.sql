--Senior Project Query
--Hare Solutions

--Begin Stored Procedures with constraints
--Check the rooms
alter Proc sp_Chk_EnoughSeats
as
Begin
	--Check if not enough seats
			Select CRN, Course, [Course Title], Seating_Assn, Seating_MAX, Room from SanCheck Where Seating_Assn > Seating_MAX
				and Seating_MAX != 0
End
Go

Create Proc sp_Chk_AtCapacity
as
Begin
	--Check if the room is at capacity
			Select CRN, Course, [Course Title], Seating_Assn, Seating_MAX, Room from SanCheck INNER JOIN Room_Capacity
				on SanCheck.Room = Room_Capacity.Room_Num
				Where (SanCheck.Seating_MAX = Room_Capacity.Capacity) AND (Room_Capacity.Capacity != 0)
End
Go
			
alter Proc sp_Chk_Utilized
as
Begin			
	--Check if room is underutilized
			
			Select CRN, Course from SanCheck Where Seating_Assn < (.30 * Seating_MAX)

End 
Go			

alter Proc sp_Chk_DblBook
as
Begin			
	--Check if room is double booked
		select outerquery.CRN, outerquery.Course, outerquery.[Course Title], outerquery.Room
		from (
			Select distinct t1.CRN, t1.Course, t1.[Course Title], t1.Room from SanCheck t1, SanCheck t2
				Where t1.Time_Begin = t2.Time_Begin and t1.Room = t2.Room and t1.Room != 'WEB' and t2.Room != 'WEB'
				and t1.Room != '' and t2.Room != '' and t1.Days = t2.Days and t1.[Course Title] Not Like t2.[Course Title]
				and t1.Course Not In (Select Course from tblCrossListed)) as outerquery;

End
Go

alter Proc sp_Chk_TeachDblBook
as
Begin
	--Check if the teacher is double booked
		select outerquery.Instructor, outerquery.Course, outerquery.[Course Title], outerquery.Room
		from (
			Select distinct t1.Instructor, t1.Course, t1.[Course Title], t1.Room from SanCheck t1, SanCheck t2
				Where t1.Time_Begin = t2.Time_Begin and t1.Room = t2.Room and t1.Room != 'WEB' and t2.Room != 'WEB'
				and t1.Room != '' and t2.Room != '' and t1.Days = t2.Days and t1.[Course Title] Not Like t2.[Course Title]
				and t1.Course Not In (Select Course from tblCrossListed)) as outerquery;
End
Go

alter Proc sp_Chk_ClassSize
as
Begin
			
	--Check if class size is too large for classroom
			Select CRN, Course, [Course Title], Room, Seating_Assn, Seating_MAX, Capacity from SanCheck INNER JOIN Room_Capacity
				on SanCheck.Room = Room_Capacity.Room_Num
				Where (SanCheck.Seating_MAX > Room_Capacity.Capacity) AND (Room_Capacity.Capacity != 0)

End
Go

alter Proc sp_Chk_2119
as
Begin	
	--Check if Muli-Media Room SHEC 2119 has a time period at all times
			Select distinct Replace(Days,' ','') as Days, Time_Begin, Time_End from SanCheck
				Where Time_Begin != '' and Time_Begin Not In (Select Time_Begin from SanCheck where Room = '2119')
			
End
Go
--Check teachers
alter Proc sp_Chk_CourseLoad
as
Begin
	--Make sure no teacher is teaching over his or her course load

			Select distinct Instructor from SanCheck INNER JOIN Teacher_CourseLoad on
				SanCheck.ID = Teacher_CourseLoad.JagNumber
				Where Teacher_CourseLoad.CourseLoad > (Select COUNT(Instructor) from SanCheck)
				
End
Go
			
alter Proc sp_Chk_TeachDayNight
as
Begin
	--Check for teachers that are teaching both night and day classes
	Select * from
	(Select distinct Instructor, ID, Sesh from SanCheck Where SanCheck.Sesh IN (' D')) As vwDay,
	(Select distinct Instructor, ID, Sesh from SanCheck Where SanCheck.Sesh IN (' E')) As vwEvening
	Where vwDay.ID = vwEvening.ID;
End
Go	
			
alter Proc sp_Chk_ScheduleAndWB
as
Begin
	--Check that the schedule matches the whiteboard
	Select Course, Instructor from SanCheck Where Course Not In (Select Course from tblClassAssignment)

End
Go				
				

			
alter Proc sp_Chk_ClassHasTeacher
as
Begin
	--Check to see if each class has a teacher
	Select CRN, Course, [Course Title] from SanCheck where Instructor = ''
End
Go

alter Proc sp_Chk_ClassSameTime
as
Begin

	--Check to see if classes are scheduled at the same time that are not cross-listed
	Select distinct vwFirstClass.ID, vwFirstClass.Instructor, vwFirstClass.CRN ,vwFirstClass.Course, vwFirstClass.[Course Title], vwFirstClass.Days, vwFirstClass.Time_Begin,
			vwFirstClass.CRN, vwSecondClass.Course as Course2, vwSecondClass.[Course Title], vwSecondClass.Days, vwSecondClass.Time_Begin
	from (select  CRN, Course, [Course Title], ID, Instructor, Days, Time_Begin from SanCheck) as vwFirstClass INNER JOIN
		 (select CRN, Course, [Course Title], ID, Instructor, Days, Time_Begin from SanCheck) as vwSecondClass
		 on vwFirstClass.ID = vwSecondClass.ID
	where vwFirstClass.Time_Begin = vwSecondClass.Time_Begin AND vwFirstClass.Days = vwSecondClass.Days
		AND vwFirstClass.Time_Begin != '' AND vwFirstClass.CRN != vwSecondClass.CRN AND vwFirstClass.Course NOT IN (select Course from tblCrossListed)
		AND vwSecondClass.Course NOT IN (Select Course from tblCrossListed) AND vwFirstClass.Course != vwSecondClass.Course
End
Go
	
	
alter Proc sp_Chk_BacktoBack
as
Begin
	--Check if a teacher is scheduled for back-to-back classes
	SELECT vwEND.Course As EndingCourse, vwEnd.ID, vwEnd.Days, vwEnd.Time_End,
		 vwBeg.Course As BeginningCourse, vwBeg.ID, vwBeg.Instructor As Instructor,vwBeg.Days, vwBeg.Time_Begin,
		 DATEADD(MINUTE, 15, CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwEnd.Time_End),4), 3, 0, ':'))) EndTime,
         CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwBeg.Time_Begin),4), 3, 0, ':')) AS BegTime
	FROM (SELECT Course, ID, Instructor, Days, Time_Begin
         FROM SanCheck) AS vwBeg INNER JOIN
         (SELECT Course, ID, Days, Time_End
	     FROM SanCheck) AS vwEnd 
		ON vwBeg.ID=vwEnd.ID
	WHERE DATEADD(MINUTE, 15, CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwEnd.Time_End),4), 3, 0, ':'))) =
      CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwBeg.Time_Begin),4), 3, 0, ':'));
End
Go

alter Proc sp_Chk_TeachAllDays
as
Begin

	--Check if a teacher has a class on MWF and TR
	Select * from
	(Select distinct Instructor, ID, Days from SanCheck Where SanCheck.Days IN ('M            ','    W        ','        F    ','M   W        ','M   W   F    ')) As vwMWF,
	(Select distinct Instructor, ID, Days from SanCheck Where SanCheck.Days IN ('  T          ','      R      ','  T   R      ')) As vwTR
	Where vwMWF.ID = vwTR.ID;
	
End
Go
--Check classes for fall rotation
alter Proc sp_Chk_FallRotation
as
Begin
	--Check if semester classes are not in the rotation for the respective semester
	/*
	select *
	from vwRotClasses
	WHERE class NOT IN (SELECT class from vwOnSchedule);
	*/
	Select Course
	from tblRotation
	Where Course NOT IN (SELECT Course from SanCheck) AND TermID = 1
End
Go

--Check classes for fall rotation
alter Proc sp_Chk_SpringRotation
as
Begin
	Select Course
	from tblRotation
	Where Course NOT IN (SELECT Course from SanCheck) AND TermID = 2

End
Go

alter Proc sp_Chk_SummerRotation
as
Begin
	Select Course
	from tblRotation
	Where Course NOT IN (SELECT Course from SanCheck) AND TermID = 3
End
Go


	--Check for classes that do not fit in a standard class period
alter Proc sp_Chk_ClassPeriod
as
Begin
	Select * 
	from (Select distinct CRN, Course, (Replace(Days,' ','') + Time_Begin + Time_End) as TimeAttribute from SanCheck Where Time_Begin != '') as vwTimeAttribute
	Where vwTimeAttribute.TimeAttribute Not In (Select Day + StartTime + EndTime from tblClassPeriod) AND vwTimeAttribute.TimeAttribute != ''
End
Go

	--Check modality
alter Proc sp_Chk_Modality
as
Begin
	Select vwHasModality.CRN As CRN, vwHasModality.Course As Course, vwHasModality.[Course Title], vwHasModality.Instructor, vwHasModality.[Inst Method],
			vwHasModality.Room, vwHasModality.Time_Begin, vwHasModality.Time_End
	from (Select CRN, Course, [Course Title], Instructor, [Inst Method], Room, Time_Begin, Time_End from SanCheck) as vwHasModality INNER JOIN
		 (Select CRN, Course, [Course Title], Instructor, [Inst Method], Room, Time_Begin, Time_End from SanCheck) as vwNoModality
		 on vwHasModality.CRN = vwNoModality.CRN
	where vwHasModality.[Inst Method] != vwNoModality.[Inst Method] or LEN(vwHasModality.[Inst Method]) > 2
End
Go

	--Create a view for the tblClassPair data
alter View vwClassPairsInSchedule
as
Select vwSchedule1.Time_Begin As Time1,
	   vwSchedule1.Days As Day1,
	   vwSchedule1.Course As Course1,
	   vwSchedule2.Time_Begin As Time2,
	   vwSchedule2.Days As Day2,
	   vwSchedule2.Course As Course2
From (Select Time_Begin, Days, Course from SanCheck) As vwSchedule1 INNER JOIN
	 (Select Time_Begin, Days, Course from SanCheck) As vwSchedule2
	 On vwSchedule1.Time_Begin = vwSchedule2.Time_Begin

	--Check to see if classes typically taken together are at the same time
alter Proc sp_Chk_TakenTogether
as
Begin
	Select vwClassPairsInSchedule.Time1 As BeginTime,
		   vwClassPairsInSchedule.Day1 As Days,
		   tblClassPair.ClassPairID, tblClassPair.Class1,
		   tblClassPair.Class2
	From vwClassPairsInSchedule INNER JOIN tblClassPair
	     On vwClassPairsInSchedule.Course1 = tblClassPair.Class1 AND
		    vwClassPairsInSchedule.Course2 = tblClassPair.Class2
End
Go		