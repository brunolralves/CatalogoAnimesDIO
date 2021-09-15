using CatalogoAnimesDIO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAnimesDIO.Classes
{
    class Anime : BaseEntity
    {
        private Gender Gender { get; set; }
        private string Title {get; set; }
        private string Description {get; set; }
        private int Year { get; set; }

        private bool Deleted { get; set; }

        public Anime(int id,Gender gender, string title, string description, int year)
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }


        public override string ToString()
        {
            string returnString = " ";
            returnString += "Gênero: " + this.Gender + Environment.NewLine;
            returnString += "Titulo: " + this.Title + Environment.NewLine;
            returnString += "Descrição: " + this.Description + Environment.NewLine;
            returnString += "Ano de lançamento: " + this.Year;
           

            return returnString;
        }


        
        public string GetTitle()
        {
            return this.Title;
        }

        public int GetId()
        {
            return this.Id;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }
}
