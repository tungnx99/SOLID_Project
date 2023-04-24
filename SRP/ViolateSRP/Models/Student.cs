using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Models
{
    //public class Student
    //{
    //    private int Id { get; set; }
    //    private string Name { get; set; }

    //    public int MediumScoreOfAll()
    //    {
    //        return 0;
    //    }

    //    public int MediumScoreOfSubject(int subjectCode)
    //    {
    //        return 0;
    //    }

    //    public int RankedAcademic(int semesterCode)
    //    {
    //        return 0;
    //    }
    //}

    public class Student
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
    }

    public class CaculateScoreOfStudent : Student
    {

        public int MediumScoreOfAll()
        {
            return 0;
        }

        public int MediumScoreOfSubject(int subjectCode)
        {
            return 0;
        }
    }

    public class GradeOfStudent : Student
    {
        public int RankedAcademic(int semesterCode)
        {
            return 0;
        }
    }
}
