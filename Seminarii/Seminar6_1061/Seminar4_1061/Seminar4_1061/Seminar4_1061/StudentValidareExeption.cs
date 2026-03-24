using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_1061 {
    internal class StudentValidareExeption:Exception {
        public StudentValidareExeption(string message) : base(message) { }
    }
}
