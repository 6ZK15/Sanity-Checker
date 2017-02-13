select CRN from SanCheck, Room_Capacity where (Room_Capacity.Room_Num = 1300 AND Room_Capacity.Room_Num != 'WEB')

select * from SanCheck INNER JOIN Room_Capacity
on SanCheck.Room = Room_Capacity.Room_Num


insert into Room_Capacity (Room_Num, Capacity) values ('','')

select * from SanCheck

select * from Room_Capacity

select * from SanCheck INNER JOIN Teacher_CourseLoad
on SanCheck.ID = Teacher_CourseLoad.JagNumber
Order by SanCheck.Instructor

select * from SanCheck INNER JOIN Room_Capacity
on SanCheck.Room = Room_Capacity.Room_Num
Where (SanCheck.Seating_MAX > Room_Capacity.Capacity) AND (Room_Capacity.Capacity != 0)