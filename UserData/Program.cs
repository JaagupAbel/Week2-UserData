using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust;
            //Programm kuvab kasutaja vanust konsoolist;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");



        }
    }
}
