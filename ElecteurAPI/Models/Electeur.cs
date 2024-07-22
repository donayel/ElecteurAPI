using System;

namespace ElecteurAPI.Models
{
    public class Electeur
    {
        public int Id { get; set; }
        public string NumeroElecteur { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
