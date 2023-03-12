using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) :base(name)
        {
            BaseGradeBook.Type = Enums.GradeBookType.Standard;
            //sdsadsa
        }
    }
}
