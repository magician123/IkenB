using System;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark;
        public int  Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                    _id =value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value != null)
                {
                    if (value != "")
                        _name = "";
                    else
                        _name = value;
                }
                else
                    Console.WriteLine("Name cannot be null");
               
                
            }
        }
        public int PassMark { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = null;

            Console.WriteLine(student.Name);

            Console.ReadLine();
        }
    }
}
