using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_paskaita_2019_01_03
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
