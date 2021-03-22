using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool
{
    class Class
    {
        public int ClassId;   //科目ID
        public string ClassName;  //班级名字
        public override string ToString()
        {
            return this.ClassName;
        }
    }
}
