

using System.ComponentModel.DataAnnotations;

namespace BtkAkademiMVC.Models

{
    public class Candidate
    {

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName alanı zorunludur.")]
        public string FirtName { get; set; } = String.Empty;

        [Required(ErrorMessage = "LastName alanı zorunludur.")]
        public string LastName { get; set; } = String.Empty;

        public int Age { get; set; }

        public string SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplayAt { get; set; }


        public Candidate()
        {
            ApplayAt = DateTime.Now;
        }
    }
}
