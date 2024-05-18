using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Application.DTOs
{
    public class YoneticiDTO
    {
        [Required(ErrorMessage = "Ad zorunludur.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur.")]
        public string LastName { get; set; }
        public string Photo { get; set; }

        public string? MiddleName { get; set; }
        public string Email
        {
            get
            {
                return $"{FirstName}.{LastName}@bilgeadam.com";
            }
        }

        [Required(ErrorMessage = "Adres zorunludur.")]
        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Meslek zorunludur.")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Departman zorunludur.")]
        public string Department { get; set; }
    }
}
