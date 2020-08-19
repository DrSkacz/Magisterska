using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Magisterka.Models
{
    public class PP
    {
        //[RegularExpression(@"^ 0 - 9, 0 - 9] + $")]
        //[StringLength(5)]
        //[Required]
        //Raczej

            public string STYL { get; set; }

            public string PVALUE { get; set; } //Conversja jeszcze

            public double PVALUE2 { get; set; } //jest texbox co bedzie w double pozniej 


        public List<SelectListItem> LISTA { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "100", Text = "1" },
            new SelectListItem { Value = "10", Text = "2" },
            new SelectListItem { Value = "1", Text = "3" },
        };


    }
}
