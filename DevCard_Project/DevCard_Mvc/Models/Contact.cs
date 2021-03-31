using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3 ,ErrorMessage = "حداقل طول نام 3 کاراکتر است")]
        [MaxLength(100,ErrorMessage = "حداکثر طول نام 100 کاراکتر است")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "مقدار وارد شده فیلد صحیح نیست")]
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Services { get; set; }
    }
}
