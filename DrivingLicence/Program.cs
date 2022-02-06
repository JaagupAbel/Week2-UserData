using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvutab kasutaja vanust
            //Kui kasutaja on noorem, kui 18 siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada"
            //Kui kasutaja on vanem, kui 18 siis progam kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada"
            //Kui kasutaja on 18, siis program kuvab konsoolis
            //"Palju õnne! Nüüd sa saad ka juhilube taotleda";

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
                int sünniaasta = Convert.ToInt32(Console.ReadLine());

            int kasutajavanus = 2022 - sünniaasta;

            if (kasutajavanus > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada."); 
            }
            else if (kasutajavanus < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad ka juhilube taotleda");
            }
        }
    }
}
