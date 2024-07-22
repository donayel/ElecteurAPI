using System;

namespace ElecteurAPI.Models
{
    public class Electeur
    {
        // Id auto incrément de l'électeur
        public int Id { get; set; }
        // Numéro de l'électeur
        public string NumeroElecteur { get; set; }
        // Nom de l'électeur
        public string Nom { get; set; }
        // Prénom de l'électeur
        public string Prenoms { get; set; }
        // Date de naissance de l'électeur 
        public DateTime DateNaissance { get; set; }
        //Contact de l'électeur
        public string Contact { get; set; }
        // Email de l'électeur
        public string Email { get; set; }
    }
}
