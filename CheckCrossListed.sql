select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = 'M   W   F    '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = 'M   W        '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = 'M            '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = '  T   R      '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = '  T          '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = '    W        '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = '      R      '
order by SanCheck.Days ASC

select CRN, [Course Title], Course, SanCheck.Days, Time_Begin, Time_End from SanCheck
Where SanCheck.Days = '        F    '
order by SanCheck.Days ASC