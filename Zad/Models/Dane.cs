using System.ComponentModel.DataAnnotations;

namespace Zad.Models
{
    public class Dane
    {

        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        //[RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj hasło skladające się z min. 8 znaków, w tym jedna wielka litera, jedna mała i jedna cyfra")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze powtórz hasło; musi być takie samo")]
        [Compare ("Haslo")]
        public string PowtorzHaslo { get; set; }

        [Phone(ErrorMessage ="Podaj poprawny numer telefonu 9cyfr")]
        public string Tel { get; set; }

        [Range(11, 80, ErrorMessage="Wiek musi być większy niż 10 lat i mniejszy niż 80 lat")]
        public int Wiek { get; set; }
        [EnumDataType(typeof(Kategorie) ,ErrorMessage ="Wybierz poprawną kategorię z podanych")]
        public string Miasto { get; set; }
       
        public enum Kategorie
        {
            Szczecin,
            Warszawa,
            Poznan,
            Krakow,
            Wroclaw

        }
        //public string Temat { get; set; }
        //[Required(ErrorMessage = "Prosze podaj Temat")]
        //public string Tresc { get; set; }

        //[Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        //[MinLength(10), MaxLength(50)]
    }
}
