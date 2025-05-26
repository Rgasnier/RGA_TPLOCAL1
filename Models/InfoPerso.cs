using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class InfoPerso
    {
        // Propriété Nom
        [Required(ErrorMessage = "Veuillez indiquer votre nom")]
        public string Nom { get; set; }

        // Propriété Prénom
        [Required(ErrorMessage = "Veuillez indiquer votre prénom")]
        public string Prenom { get; set; }

        // Propriété Genre + valeur défaut
        [Required(ErrorMessage = "Veuillez sélectionner un genre.")]
        public string Genre { get; set; } = "Selectionner un sexe";

        // Propriété Adresse
        [Required(ErrorMessage = "Veuillez indiquer votre adresse")]
        public string Adresse { get; set; }

        // Propriété Code Postal + Contrôle de Format Regex
        [Required(ErrorMessage = "Veuillez indiquer votre code postal")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir exactement 5 chiffres.")]
        public string CodePostal { get; set; }

        // Propriété Ville
        [Required(ErrorMessage = "Veuillez indiquer votre ville")]
        public string Ville { get; set; }

        // Propriété Adresse Couriel + Contrôle de Format Regex 
        [Required(ErrorMessage = "Veuillez indiquer votre adresse mail")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "Format d'adresse email invalide.")]
        public string AdresseCouriel { get; set; }

        // Propriété Date de Début + Contrôle Date Maximum
        [Required(ErrorMessage = "Veuillez indiquer le début de votre formation")]
        [DataType(DataType.Date, ErrorMessage = "Format de date invalide.")]
        [Range(typeof(DateTime), "01/01/1900", "31/12/2020", ErrorMessage = "La date doit être antérieure au 01/01/2021.")]
        public DateTime DateDeDebut { get; set; }

        // Propriété Type de Formation
        [Required(ErrorMessage = "Veuillez sélectionner un type de formation.")]
        public string TypeDeFormation { get; set; } = "Select a course";

        // Propriété Avis Cobol Formation
        [Required(ErrorMessage = "Veuillez indiquer votre exament sur Cobol Formation")]
        public string CobolFormation { get; set; }

        // Propriété Avis C# Formation
        [Required(ErrorMessage = "Veuillez indiquer votre exament sur C# Formation")]
        public string CFormation { get; set; }
    }
}