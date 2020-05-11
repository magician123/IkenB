using System;
using System.Collections.Generic;

namespace QuestionTwo
{
    
    public class Module
    {
        #region Fields
        List<double> grades;


        #endregion

        #region Properties
        public List<double> Grades
        {
            get
            {
                return grades;
            }
            set
            {
                grades = value;
            }
        }
        #endregion

        #region Constructor
        public Module()
        {
            Grades = new List<double>();
        }




        #endregion

        #region Methods
        public void AddGrade(double grade)
        {
            Grades.Add(grade);

        }
       
        #endregion
    }


}