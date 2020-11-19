using System;
using System.Collections.Generic;
using System.Text;

namespace Convertisseur
{
    public class Controller
    {
        public string Controleur()
        {
            Vue view = new Vue();
            string b = view.GetUserInput();

            Model model = new Model();
            return model.ConvertToUpperCase(b);
        }
        
    }
}
