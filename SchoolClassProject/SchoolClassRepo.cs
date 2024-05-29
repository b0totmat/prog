using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses;

        public SchoolClassRepo()
        {
            _schoolClasses = new List<SchoolClass>()
            {
                new SchoolClass { Grade = 9, ClassId = 'a', ClassMoney = 5000, ClassSize = 24 },
                new SchoolClass { Grade = 10, ClassId = 'b', ClassMoney = 7000, ClassSize = 30 },
                new SchoolClass { Grade = 11, ClassId = 'c', ClassMoney = 6000, ClassSize = 26 }
            };
        }

        public List<SchoolClass> FindAll() => _schoolClasses;

        public SchoolClassRepo(List<SchoolClass> classes)
        {
            _schoolClasses = classes;
        }

        public string MostPaydSchoolClass()
        {
            SchoolClass largest;
            string result = string.Empty;

            if(_schoolClasses.Count > 0)
            {
                largest = _schoolClasses[0];
                result = $"{largest.Grade}.{largest.ClassId}";
                foreach (var sc in _schoolClasses)
                {
                    if (sc.ClassMoney > largest.ClassMoney)
                    {
                        largest = sc;
                        result = $"{sc.Grade}.{sc.ClassId}";
                    }
                }
            }

            return result;
        }

        public string SumOfClassMoney(int timeInMonths)
        {
            string result = $"Befizetett osztálypénzek {timeInMonths} hónapra:\n";
            foreach (var sc in FindAll())
            {
                int paidMoney = 0;
                for (int i = 0; i < timeInMonths; i++)
                    paidMoney += sc.ClassMoney;

                result += $"{sc.Grade}.{sc.ClassId}: {paidMoney}\n";
            }

            return result;
        }
    }
}
