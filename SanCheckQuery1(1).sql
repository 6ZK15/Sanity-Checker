--Senior Project Query
--Hare Solutions

--Begin Stored Procedures with constraints
--Check the rooms
Alter Proc Chk_Rooms
as
Begin
	--Check if not enough seats
			Select CRN, Course, [Course Title], Seating_Assn, Seating_MAX, Room from SanCheck Where Seating_Assn > Seating_MAX
				and Seating_MAX != 0

			
			
	--Check if room is underutilized
			
			Select CRN from SanCheck Where Seating_Assn < (.30 * Seating_MAX)

			
			
	--Check if room is double booked
		select outerquery.CRN, outerquery.Course, outerquery.[Course Title]
		from (
			Select distinct t1.CRN, t1.Course, t1.[Course Title] from SanCheck t1, SanCheck t2
				Where t1.Time_Begin = t2.Time_Begin and t1.Room = t2.Room and t1.Room != 'WEB' and t2.Room != 'WEB'
				and t1.Room != '' and t2.Room != '' and t1.Days = t2.Days and t1.[Course Title] Not Like t2.[Course Title]
				and t1.Course Not Like '%453%' and t1.Course Not Like '%553%'
				and t1.Course Not Like '%475%' and t1.Course Not Like '%490%'
				and t1.Course Not Like '%590%') as outerquery;
			
	--Check if class size is too large for classroom
			Select CRN, Course, [Course Title], Room, Seating_Assn, Seating_MAX, Capacity from SanCheck INNER JOIN Room_Capacity
				on SanCheck.Room = Room_Capacity.Room_Num
				Where (SanCheck.Seating_MAX > Room_Capacity.Capacity) AND (Room_Capacity.Capacity != 0)
	
	--Check if Muli-Media Room SHEC 2119 has a time period at all times
			Select Days, Time_Begin, Time_End from SanCheck
				Where Room != '2119' AND Time_Begin != ''
				Order by Days DESC
			
End
Go
--Check teachers
Alter Proc Chk_Teachers
as
Begin
	--Make sure no teacher is teaching over his or her course load

			Select distinct Instructor from SanCheck INNER JOIN Teacher_CourseLoad on
				SanCheck.ID = Teacher_CourseLoad.JagNumber
				Where Teacher_CourseLoad.CourseLoad > (Select COUNT(Instructor) from SanCheck)
				

			

	--Check for teachers that are teaching both night and day classes
	Select * from
	(Select distinct Instructor, ID, Sesh from SanCheck Where SanCheck.Sesh IN (' D')) As vwDay,
	(Select distinct Instructor, ID, Sesh from SanCheck Where SanCheck.Sesh IN (' E')) As vwEvening
	Where vwDay.ID = vwEvening.ID;
	
			
				
				

			

	--Check to see if each class has a teacher
	Select CRN, Course, [Course Title] from SanCheck where Instructor = ''

	--Check to see if classes are scheduled at the same time
	Select distinct vwFirstClass.ID, vwFirstClass.Instructor, vwFirstClass.Course, vwFirstClass.[Course Title], vwFirstClass.Days, vwFirstClass.Time_Begin,
			vwSecondClass.Course, vwSecondClass.[Course Title], vwSecondClass.Days, vwSecondClass.Time_Begin
	from (select CRN, Course, [Course Title], ID, Instructor, Days, Time_Begin from SanCheck) as vwFirstClass INNER JOIN
		 (select CRN, Course, [Course Title], ID, Instructor, Days, Time_Begin from SanCheck) as vwSecondClass
		 on vwFirstClass.ID = vwSecondClass.ID
	where vwFirstClass.Time_Begin = vwSecondClass.Time_Begin AND vwFirstClass.Days Like vwSecondClass.Days
		AND vwFirstClass.Time_Begin != '' AND vwFirstClass.CRN != vwSecondClass.CRN

	--Check for teachers that are scheduled for two non-cross listed classes at the same day time
	--Same as above?
	
	--Check if a teacher is scheduled for back-to-back classes
	SELECT vwEND.Course, vwEnd.ID, vwEnd.Days, vwEnd.Time_End,
		 vwBeg.Course, vwBeg.ID, vwBeg.Days, vwBeg.Time_Begin,
		 DATEADD(MINUTE, 15, CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwEnd.Time_End),4), 3, 0, ':'))) EndTime,
         CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwBeg.Time_Begin),4), 3, 0, ':')) AS BegTime
	FROM (SELECT Course, ID, Days, Time_Begin
         FROM SanCheck) AS vwBeg INNER JOIN
         (SELECT Course, ID, Days, Time_End
	     FROM SanCheck) AS vwEnd 
		ON vwBeg.ID=vwEnd.ID
	WHERE DATEADD(MINUTE, 15, CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwEnd.Time_End),4), 3, 0, ':'))) =
      CONVERT(DATETIME, STUFF(RIGHT(CONCAT('0',vwBeg.Time_Begin),4), 3, 0, ':'));


	--Check if a teacher has a class on MWF and TR
	Select * from
	(Select distinct Instructor, ID, Days from SanCheck Where SanCheck.Days IN ('M            ','    W        ','        F    ','M   W        ','M   W   F    ')) As vwMWF,
	(Select distinct Instructor, ID, Days from SanCheck Where SanCheck.Days IN ('  T          ','      R      ','  T   R      ')) As vwTR
	Where vwMWF.ID = vwTR.ID;
	
End
Go
--Check classes
Alter Proc chk_Courses
as
Begin
	--Check Semester Rotation for Fall
	Select vwOnSchedule.CRN, vwOnSchedule.Course, vwOnSchedule.[Course Title], vwOnSchedule.Instructor, vwOnSchedule.Room,
		vwOnSchedule.Time_Begin, vwOnSchedule.Time_End
	from (Select CRN, Course, [Course Title], Instructor, Room, Time_Begin, Time_End from SanCheck) as vwOnSchedule INNER JOIN
		 (Select CRN, Course, [Course Title] from tblFallRotation) as vwFallClasses on vwOnSchedule.CRN = vwFallClasses.CRN
	Where vwOnSchedule.CRN = vwFallClasses.CRN

	--Check that classes fit in one standard class period

	--Check modality
	Select vwHasModality.CRN, vwHasModality.Course, vwHasModality.[Course Title], vwHasModality.Instructor, vwHasModality.[Inst Method],
			vwHasModality.Room, vwHasModality.Time_Begin, vwHasModality.Time_End
	from (Select CRN, Course, [Course Title], Instructor, [Inst Method], Room, Time_Begin, Time_End from SanCheck) as vwHasModality INNER JOIN
		 (Select CRN, Course, [Course Title], Instructor, [Inst Method], Room, Time_Begin, Time_End from SanCheck) as vwNoModality
		 on vwHasModality.CRN = vwNoModality.CRN
	where vwHasModality.[Inst Method] != vwNoModality.[Inst Method] or LEN(vwHasModality.[Inst Method]) > 2

	--Check Special Topics Classes

	--Check to see if classes typically taken together are at the same time
			
End
Go