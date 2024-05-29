using SchoolClassProject;

SchoolClass sc1 = new SchoolClass
{
    Grade = 9,
    ClassId = 'a',
    ClassMoney = 7000
},
            sc2 = new()
{
    Grade = 9,
    ClassId = 'b',
    ClassMoney = 6000
};

Console.WriteLine(sc1);
Console.WriteLine(sc2);

int difference = Math.Abs(sc1.ClassMoney - sc2.ClassMoney);

if(sc1.ClassMoney > sc2.ClassMoney)
    Console.WriteLine($"{sc1.Grade}.{sc1.ClassId} havonta {difference} forinttal többet fizetnek osztálypénzbe, mint {sc2.Grade}.{sc2.ClassId} osztály tanulói.");
else if(sc2.ClassMoney > sc1.ClassMoney)
    Console.WriteLine($"{sc2.Grade}.{sc2.ClassId} havonta {difference} forinttal többet fizetnek osztálypénzbe, mint {sc1.Grade}.{sc1.ClassId} osztály tanulói.");
else
    Console.WriteLine($"{sc1.Grade}.{sc1.ClassId} és {sc2.Grade}.{sc2.ClassId} tanulói ugyan annyit fizetnek osztálypénzbe havonta.");

SchoolClassRepo scr = new SchoolClassRepo(
    new List<SchoolClass>()
    {
        new SchoolClass { Grade = 9, ClassId = 'b', ClassMoney = 6000, ClassSize = 30 },
        new SchoolClass { Grade = 12, ClassId = 'c', ClassMoney = 5000, ClassSize = 30 },
        new SchoolClass { Grade = 10, ClassId = 'a', ClassMoney = 7000, ClassSize = 30 },
        new SchoolClass { Grade = 11, ClassId = 'b', ClassMoney = 5000, ClassSize = 30 }
    }
);

Console.WriteLine(scr.SumOfClassMoney(10));
