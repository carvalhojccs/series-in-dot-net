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

        private bool excluded {get; set; }

        //Construct method
        public SerieEntity (
            int id, 
            GenderEnum gender, 
            string title, 
            string description, 
            int year)
    {
        this.id = id;
        this.gender = gender;
        this.title = title;
        this.description = description;
        this.year = year;
        this.excluded = false;
    }

    //ToString method
    public override string ToString()
    {
        string showSerie = "";

        showSerie += "Gênero: " + this.gender + Environment.NewLine;
        showSerie += "Título: " + this.title + Environment.NewLine;
        showSerie += "Descrição: " + this.description + Environment.NewLine;
        showSerie += "Ano de início: " + this.year + Environment.NewLine;
        showSerie += "Excluído: " + this.excluded + Environment.NewLine;

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

    public bool GetExcluded()
    {
        return this.excluded;
    }

    public void Delete()
    {
        this.excluded = true;
    }
}
   
}