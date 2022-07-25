using System.ComponentModel.DataAnnotations;

namespace ListaStudenti.Models
{
    public class student
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Te rog introdu numele")]

        public string Nume { get; set;}

        [Required(ErrorMessage = "Te rog introdu anul de studiu")]
        [Range(1, 3, ErrorMessage = "Anul de studiu trebuie sa fie cuprins intre 1 si 3")]
        public int? AnStudiu { get; set; }

        [Required(ErrorMessage = "Te rog introdu nota de absolvire")]
        [Range(5, 10, ErrorMessage = "Nota de absolvire trebuie sa fie cuprinsa intre 5 si 10")]
        public int? Nota { get; set; }

        


    }
}
