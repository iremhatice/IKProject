using IKProject.Core.DomainModels.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Core.DomainModels.Models
{
    public class Yonetici:BaseEntity
    {
        [Required(ErrorMessage = "Ad zorunludur.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Photo zorunludur.")]
        public string Photo { get; set; }

        public string? SecondName { get; set; }
        public string? SecondLastName { get; set; }

        [Required(ErrorMessage = "Doğum tarihi zorunludur.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Doğum yeri zorunludur.")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "TC Kimlik No zorunludur.")]
        [StringLength(11, ErrorMessage = "TC Kimlik No 11 haneli olmalıdır.")]
        public string Tc { get; set; }

        [Required(ErrorMessage = "İşe giriş tarihi zorunludur.")]
        public DateTime EmploymentStartDate { get; set; }

        public DateTime? EmploymentEndDate { get; set; }

        public bool IsActive
        {
            get
            {
                return !EmploymentEndDate.HasValue || EmploymentEndDate.Value > DateTime.Now;
            }
        }

        [Required(ErrorMessage = "Meslek zorunludur.")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Departman zorunludur.")]
        public string Department { get; set; }

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

    }
}
