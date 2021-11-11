using System;
using DIO.Series.Enums;

namespace DIO.Series.Entities
{
    public class SerieEntity : BasicEntity
    {
        private GenderEnum gender {get; set; }
        private string title {get; set; }
        private string description {get; set; }

        private int year {get; set; }

        //Construct method
        public SerieEntity (int id, GenderEnum gender, string title, string description, int year, bool active)
    {
        this.id = id;
        this.gender = gender;
        this.title = title;
        this.description = description;
        this.year = year;
        this.active = false;
    }

    //ToString method
    public override string ToString()
    {
        string showSerie = "";

        showSerie += "Gênero: " + this.gender + Environment.NewLine;
        showSerie += "Título: " + this.title + Environment.NewLine;
        showSerie += "Descrição: " + this.description + Environment.NewLine;
        showSerie += "Ano de início: " + this.year + Environment.NewLine;
        showSerie += "Ativo: " + this.active + Environment.NewLine;

        return showSerie;
    }

    public string ShowTitle()
    {
        return this.title;
    }

    public int ShowId()
    {
        return this.id;
    }
}

    
}