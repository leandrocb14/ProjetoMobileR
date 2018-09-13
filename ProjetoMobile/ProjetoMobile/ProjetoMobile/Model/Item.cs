using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoMobile.Model
{
    public class Item
    {
        public string DirectoryImage { get; set; }
        public string Titulo { get; set; }        
        public double Preco { get; set; }
        public string Ingrediente { get; set; }

        public string PrecoFormatado
        {
            get
            {
                return $"R$ {Preco.ToString("0.00")}";
            }
        }
        public bool PossuiIngrediente
        {
            get
            {
                return !string.IsNullOrEmpty(Ingrediente);
            }
        }
    }
}
