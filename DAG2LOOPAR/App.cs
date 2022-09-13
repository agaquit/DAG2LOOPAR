using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAG2LOOPAR
{
    public  class App
    {
        public void Run()
        {

            //            a.Får mata in två tal.
            //b.Skriv sedan till skärmen summan av de två talen.
            //c.Skriv sedan en fråga-Vill du fortsätta(J/ N)?.
            //d.Svarar användaren J återupprepas punkt a-c
            //e.Svarar användaren N avbryts programmet

            while (true)
            {

                Console.WriteLine("Mata in tal1:");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mata in tal2:");
                int tal2 = Convert.ToInt32(Console.ReadLine());

                int summa = tal1 + tal2;


                Console.WriteLine($"Summan av {tal1} och {tal2} är {summa}");

            }




            //            Skapa ett program där användaren får mata in två tal. Låt sedan programmet skriva ut alla tal som finns mellan dessa två tal på skärmen.

            //Lös detta med en for-loop.

            //Lös detta med en while-loop.

            //Gör med if-satser så att man kan skriva in tal1 > tal1 och vice versa.Om tal2 > tal1 ska du lista alla tal baklänges tal1 = 10 tall2 = 4 9 8 7 6 5

            //tal1 = 1 tall2 = 4 2 3

            //Console.WriteLine("Mata in 2 tal");
            //int tal1 = Convert.ToInt32(Console.ReadLine());
            //int tal2 = Convert.ToInt32(Console.ReadLine());


            //for (tal1 = tal1 + 1; tal1 < tal2; tal1++)
            //{
            //    Console.WriteLine(tal1);
            //}
            ////while ((tal1 + 1) < tal2)
            ////{
            ////    Console.WriteLine(tal1);
            ////    tal1++;
            ////}

            //Console.WriteLine("Mata in 2 tal");
            //int tal1 = Convert.ToInt32(Console.ReadLine());
            //int tal2 = Convert.ToInt32(Console.ReadLine());


            //if (tal1 < tal2)
            //{
            //    for (tal1 = tal1 + 1; tal1 < tal2; tal1++)
            //    {
            //        Console.WriteLine(tal1);
            //    }
            //}


            //else if (tal1 > tal2)
            //{ 
            //    for (tal1 = tal1 - 1; tal1 > tal2; tal1--)
            //    {
            //        Console.WriteLine(tal1);
            //    }
            //}
            
     
           

            



            //            Skapa ett program som skriver ut talen 0 - 10 på skärmen.

            //Lös detta med en for-loop.

            //Lös detta med en while-loop.

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);

            //}
            //int counter3 = 0;
            //while (counter3 <= 10)
            //{
            //    Console.WriteLine(counter3);
            //    counter3++;
            //}


            //string namnet = "Stefan";
            //char letter = 'A';

            //foreach (char c in namnet)
            //{
            //    Console.WriteLine(c);
            //}

            //while (true)
            //{
            //    Console.WriteLine("1. Starta spelet");
            //    Console.WriteLine("2. Kolla highscore");
            //    Console.WriteLine("3. Avsluta");
            //    Console.Write("Vad vill du göra: ");
            //    string sel = Console.ReadLine();
            //    if (sel == "1")
            //    {
            //        Console.WriteLine("Spelet startar");
            //        Console.WriteLine(".. och slutar");
            //    }
            //    else if (sel == "2")
            //    {
            //        Console.WriteLine("Highscore visas");
            //        Console.WriteLine("klart");
            //    }
            //    else if (sel == "3")
            //    {
            //        break;
            //    }

            //}




            // age++ = +1
            // age-- = -1
            // age = age +10
            //// age += 10
            //// age -= 10
            //int age = 12;
            //age -= 10;
            //// 22

            // while loop

            //int counter = 0;
            //while (counter < 5)
            //{
            //    Console.WriteLine("Jag heter Stefan");

            //    counter++; // counter = counter + 1
            //}

            //// for loop

            //for (int counter2 = 0; counter2 < 5; counter2 = counter2 + 1)
            //{

            //    Console.WriteLine("Jag heter Stefan");
            //    Console.WriteLine("Hej");
            //}

            //// Skriv ut alla heltal mellan 2022 och 1972 i bakvänd ordning
            //for (int year = 2022; year >= 1972; year--)
            //{
            //    Console.WriteLine(year);
            //}
            //for (int year = 1972; year >= 2022; year++)
            //{
            //    Console.WriteLine(year);
            //}









        }


    }


}
