using System;
using System.Reflection.Metadata;

namespace seance1
{
    class MathOps
    {
        public static double Expo(int rep,int val)
        {
            double output = val;
            foreach (int value in Enumerable.Range(1, rep))
            {
                output = output * val;
            }
            return output;
        }
    }
    class Polynome
    {
        private double[] userInputs;
        public Polynome (double[] coefs)
        {
            this.userInputs = coefs;
        }
        public int Degree
        {
            get
            {
                return userInputs.Length - 1;
            }
        }
        public double Evaluate(int entree)
        {
            double result = 0;
            int expo = this.Degree;
            foreach (double element in this.userInputs)
            {
                result = result + element * MathOps.Expo(expo,entree);
                expo = expo - 1;
            }
            return result;
        }
        


    }
    class SecondDegre
    {
        public static int userInput(string nom)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(nom);
                    int a = Convert.ToInt32(Console.ReadLine());
                    return a;
                }
                catch
                {
                Console.WriteLine("werreur god dayum");
                }
            }
        }


        public static void calcul(int a,int b,int c)
        {
            // Calcul du discriminant
            float delta = b*b - 4 * a * c;
            Console.WriteLine(" Discriminant :", delta );

            // Test des trois cas possibles et affichage des racines du trinôme
            if (delta < 0)
            {
                Console.WriteLine(" Pas de racine réelle ");
            }
            else if (delta == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine (" Une racine réelle double :", x);
            }
            else 
            {
                float x1 = (float)((-b - Math.Sqrt( delta )) / (2 * a));
                float x2 = (float)((-b + Math.Sqrt( delta )) / (2 * a));
                Console.WriteLine(" Deux racines réelles distinctes :", x1 , "et", x2);
            }

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("1 pour second degre et deux pour polynome");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                SecondDegreExe();
            }
            else
            {
                PolynomeExe();
            }
        }
        static void SecondDegreExe()
        {
            int a = SecondDegre.userInput("a?");
            int b = SecondDegre.userInput("b?");
            int c = SecondDegre.userInput("c?");
            SecondDegre.calcul(a,b,c);
        }
        static void PolynomeExe()
        {
            Polynome p = new Polynome ( new double [] {1 , 0, -2}) ;
            Console.WriteLine (p.Degree);
            Console.WriteLine (p);
            Console.WriteLine (p.Evaluate(2));

        }
       
    }
    
}




