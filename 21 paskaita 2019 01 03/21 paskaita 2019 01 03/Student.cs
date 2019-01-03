using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_paskaita_2019_01_03
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float AverageMark { get; set; }
        public bool IsGettingTuition { get; set; }

        public Student(int Id, string Name, int Age, float AverageMark, bool IsGettingTuition)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.AverageMark = AverageMark;
            this.IsGettingTuition = IsGettingTuition;
        }
    }
}
