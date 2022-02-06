using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Porgramm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaastat;
            //Programm kuvab sünniaastat konsoolis;
            //"Oled sündinud aastal {yearOfBirth}

            Console.WriteLine("Palun, sisesta oma vanus:");
            int kasutajavanus = Convert.ToInt32(Console.ReadLine());

            int sünniaasta = 2022 - kasutajavanus;

            Console.WriteLine($"Oled sündinud {sünniaasta}");



        }
    }
}
