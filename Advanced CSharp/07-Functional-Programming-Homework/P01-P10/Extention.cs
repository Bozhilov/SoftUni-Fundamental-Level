using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_P10
{
    public static class Extention
    {
        public static List<Student> ExtentionCount(this IList<Student> marks)
        {
            var result =
                from s in marks
                where (s.Marks.Count(x => x == 2) == 2)
                select s;
            return result.ToList();
        }
    }
}