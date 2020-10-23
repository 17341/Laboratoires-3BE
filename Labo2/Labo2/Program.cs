using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person khaled = new Person("Khaled", "Ferekh");
            Teacher lurkin = new Teacher(1500, "Lurkin", "Professeur");
            Activity programation = new Activity("Programation", 5, "PO3T", lurkin);
            Console.WriteLine(lurkin.Get_Salary());
            Console.WriteLine('\n');
            Console.WriteLine(khaled);
            Console.WriteLine(programation);
        }
    }
    public class Person
    {
        public String First_name;
        public String Last_name;

        public Person(string First_name, string Last_name)
        {
            this.First_name = First_name;
            this.Last_name = Last_name;
        }
        public override string ToString()
        {
            return string.Format("Firstname : {0}\nLastname : {1} ", First_name, Last_name);
        }

    }
    public class Teacher : Person
    {
        public double salary;
        public Teacher(double salary, string First_name, string Last_name) : base(First_name, Last_name)
        {
            this.salary = salary;
        }
        public double Get_Salary()
        {
            return salary;
        }

    }
    public class Student : Person
    {
        private List<Evaluation> Cours = new List<Evaluation>();
        public Student(string First_name, string Last_name, List<Evaluation> Cours) : base(First_name, Last_name)
        {
            this.Cours = Cours;
        }
        public void Add(Evaluation evaluation) 
        {
            Cours.Add(evaluation);
        }
        public double Average()
        {
            return 4.0;
        }
        public string Bulletin()
        {
            return "bulletin";
        }

    }
    public class Evaluation
    {
        public Activity evaluation_activity;
        public int note;
        public Evaluation(Activity evaluation_activity, int note)
        {
            this.evaluation_activity = evaluation_activity;
            this.note = note;
        }
        public int Note()
        {
            return this.note;
        }
    }
    public class Activity
    {
        public Teacher activity_teacher;
        public string Name;
        public int ETCS;
        public string Code;
        public Activity(string Name, int ETCS, string Code, Teacher activity_teacher)
        {
            this.activity_teacher = activity_teacher;
            this.ETCS = ETCS;
            this.Code = Code;
            this.Name = Name;
        }
        public override string ToString()
        {
            return this.activity_teacher.salary.ToString();
        }

    }
}
