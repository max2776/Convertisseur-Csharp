using System;
using System.Collections.Generic;
using System.Text;

namespace Convertisseur
{
    public class Vue
    {
        public string GetUserInput()
        {
            Console.WriteLine("Veuillez rentrer la chaine de caractère que vous souhaitez convertir en majuscule");
            string demande = Console.ReadLine();
            return demande;

        }
    }
}
