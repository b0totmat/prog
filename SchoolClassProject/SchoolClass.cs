using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public int Grade { get; set; }
        public char ClassId { get; set; }
        public int ClassMoney { get; set; }
        public int ClassSize { get; set; }

        public SchoolClass()
        {
            Grade = 12;
            ClassId = 'a';
            ClassMoney = 1000;
        }

        public SchoolClass(int grade, char classId, int classMoney)
        {
            Grade = grade;
            ClassId = classId;
            ClassMoney = classMoney;
        }

        public override string ToString() => $"{Grade}. {ClassId} ({ClassMoney} Ft)";
    }
}
