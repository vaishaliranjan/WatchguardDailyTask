using System;

namespace CSharpInter
{
    public class Person
    {
        //SHortcut- prop tab tab tab tab 
        public string Name { get; set; }
        //----------------------------- Getters and Setters -------
        private DateTime _deathtime;
        public DateTime Deathtime
        {
            get { return _deathtime; }
            set { _deathtime = value; }
        }

        //-------------------------Auto-Implemented Property------
        public DateTime GraduationTime { get; set; } //internally create a private field 
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
            //doesnt have set method
        }
        public DateTime Birthdate { get; private set; }

        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}
        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}


        //fields, properties, constructor, methods
        public Person(DateTime birthdate)
        {
            Birthdate= birthdate;
        }
    }
    class Oct5 {

        static void Main(string[] args)
        {

            Person vaishali = new Person(new DateTime(2003, 02, 11));
            // vaishali.Birthdate= new DateTime(2003,02,11);
            //Console.WriteLine(vaishali.GetBirthdate());
            //  Console.WriteLine(vaishali.Age);


            int a = new int();
            Console.WriteLine(a);
            int s;
            Console.WriteLine(s);
            // }
        }
    }
}