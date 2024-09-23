using OOP01.Models.AppExceptions;
using OOP01.Models.Entities;

SchoolClass schoolClass9a = new(9, 13, 'a');
SchoolClass schoolClass9b = new(9, 13, 'b');

SchoolClass schoolClass10a = new(10, 13, 'a');
SchoolClass schoolClass10b = new(10, 13, 'b');

SchoolClass schoolClass12a = new(12, 13, 'a');
SchoolClass schoolClass12b = new(12, 13, 'b');

SchoolClass schoolClass13a = new(13, 13, 'a');
SchoolClass schoolClass13b = new(13, 13, 'b');

try { schoolClass9a.SetLastGrade(1); }
catch(LastGradeModificationErrorException lastGradeModificationError)
{
    Console.WriteLine(lastGradeModificationError.ParamName);
    Console.WriteLine(lastGradeModificationError.Message);
}

schoolClass9a.AdvanceGrade();
Console.WriteLine(schoolClass9a.Name);
