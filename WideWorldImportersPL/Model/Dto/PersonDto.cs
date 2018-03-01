using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.Model.Dto
{
    public class PersonDto
    {
        [Display(Name = "Person ID")]
        public int PersonId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Preferred Name")]
        public string PreferredName { get; set; }

        [Display(Name = "IsPermittedToLogon")]
        public bool IsPermittedToLogon { get; set; }

        [Display(Name = "Logon Name")]
        public string LogonName { get; set; }

        [Display(Name = "IsExternalLogonProvider")]
        public bool IsExternalLogonProvider { get; set; }

        [Display(Name = "IsSystemUser")]
        public bool IsSystemUser { get; set; }

        [Display(Name = "IsEmployee")]
        public bool IsEmployee { get; set; }

        [Display(Name = "IsSalesperson")]
        public bool IsSalesperson { get; set; }

        [Display(Name = "User Preferences")]
        public string UserPreferences { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Custom Fields")]
        public string CustomFields { get; set; }

        [Display(Name = "Other Languages")]
        public string OtherLanguages { get; set; }

        [Display(Name = "Last Edited By")]
        public int LastEditedBy { get; set; }

        [Display(Name = "Valid From")]
        public DateTime ValidFrom { get; set; }

        [Display(Name = "Valid To")]
        public DateTime ValidTo { get; set; }
    }

    public class PersonDetailDto : PersonDto
    {
        public byte[] Photo { get; set; }
    }
}
