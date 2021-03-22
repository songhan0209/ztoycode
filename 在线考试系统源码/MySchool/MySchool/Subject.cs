using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    public class Subject
    {
        public int SubjectId;   //科目ID
        public string SubjectName;  //科目名字
        public override string ToString()
        {
            return this.SubjectName;
        }
    }
}
