using ProjetoMobile.BLL;
using ProjetoMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.DAO
{
    public class CardapioDAO
    {
        public List<Item> Itens { get; set; }
        private CardapioBLL CardapioBLL { get; set; }        
        public CardapioDAO()
        {
            this.Itens = new List<Item>();
            this.CardapioBLL = new CardapioBLL();              
        }

        public string MensagemDeBoasVindas()
        {
            TimeSpan HorarioAtual = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return this.CardapioBLL.AvaliaHoraDeCumprimentoUsuario(HorarioAtual);
        }        

        #region Temporario
        /// <summary>
        /// Este metodo é responsável por adicionar um novo item dentro propriedade <see cref="Itens"/>.
        /// </summary>
        /// <param name="directoryImage">Representa o diretório da imagem dentro do projeto android, na pasta Resources > Drawable</param>
        /// <param name="titulo">Representa o título do Item</param>
        /// <param name="preco">Representa o valor do Item</param>
        /// <param name="ingrediente">Representa os componentes que constituem o item</param>
        private void AddItem(string directoryImage, string titulo, double preco, string ingrediente = null)
        {
            this.Itens.Add(new Item()
            {
                DirectoryImage = directoryImage,
                Titulo = titulo,
                Ingrediente = ingrediente,
                Preco = preco
            });
        }
        private void GetItens()
        {            
            //AddItem("smoothiesdemorango.jpg", "Smoothies de morango", 11);
            AddItem("crepiocatradional.jpg", "Crepioca tradicional", 15);
            AddItem("tapioca.jpg", "Tapioca tradicional", 5);
            //AddItem("milkshakepacoca.jpg", "Milk Shake de Paçoca", 11.60);
            AddItem("tapiocadoce.jpg", "Tapioca Doce", 7);
            AddItem("nuggets.jpg", "Nuggets", 10);
            AddItem("batatafrita.jpg", "Batata Frita", 10, "Batata frita com bacon e cheddar");
            AddItem("Massangana.jpg", "Privilege Massangana", 17.99);            
        }
        public List<Item> ListarItems()
        {
            GetItens();
            return this.Itens;
        }       

        #endregion
    }
}
