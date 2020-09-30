using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Labo1
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recherche des racines de ax ^2 + bx + c :");
            Console.WriteLine("Quel est ton a?");
            int a = Verification();

            Console.WriteLine("Quel est ton b?");
            int b = Verification();

            Console.WriteLine("Quel est ton c?");
            int c = Verification();


            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine(" Pas de racine réelle ");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine(" Une racine réelle double :" + x);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine(" Deux racine réelle double :", x1 + "et" + x2);
            }
            
        }
        private static int Verification()
        {

            int sortie = default(int);
            bool error = true;
            string entree = Console.ReadLine();
            while (error)
            {

                try
                {
                    sortie = System.Convert.ToInt32(entree);
                    error = false;

                }
                catch
                {
                    Console.WriteLine("Retry");
                    entree = Console.ReadLine();

                }
            }
            return sortie;


        }
    } 
    */

    class Polynomial

    {
        static void Main(string[] args)
        {
            Polynomial p = new Polynomial(new double[] { 1, 0, -2 });
            Console.WriteLine(p.Degree);
            Console.WriteLine(p);
            Console.WriteLine(p.Evaluate(2));
            Polynomial q = new Polynomial(new double[] { 1, 0, -2 });
            Console.WriteLine(p == q);
            Console.WriteLine(p.Equals(q));
        }
        private readonly double[] n;
        public int x = 0;
        public Polynomial(double[] n)
        {
            this.n = n;
            Array.Reverse(this.n);
        }
        public int Degree
        {
            get { return this.n.Length - 1; }
        }

        public double Evaluate(int x)
        {
            double sum = 0;
            for (int i = this.n.Length - 1; i >= 0; i--)
            {

                sum += this.n[i] * Math.Pow(x, i);
            }
            return sum;
        }
        public override string ToString()
        {
            string formule = default(string);
            for (int i = this.n.Length - 1; i >= 0; i--)
            {
                if (this.n[i] != 0 & i != 0)
                {
                    formule += this.n[i].ToString() + "x^" + i.ToString();
                }
                else if (i == 0)
                {
                    formule += this.n[i];
                }
            }
            return formule;
        }
    }


}