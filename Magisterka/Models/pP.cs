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

        public string BOX1 { get; set; }
        public string BOX2 { get; set; }
        public string BOX3 { get; set; }
        public string BOX4 { get; set; }

        public double SQv { get; set; }
        public double SLambdasr { get; set; }
        public double SLo { get; set; }
        public double SQc { get; set; }
        public double SCOP { get; set; }
        public double STsp { get; set; }
        public double SQ0 { get; set; }
        public double SLw { get; set; }
        public double SdLw { get; set; }

        public double SLambdai { get; set; } //do selectora <=
        public double SUi { get; set; } // to bedzie wyswietlane
        public double SUia { get; set; }
        public double SUib { get; set; }
        public double SUic { get; set; }
        public double SUid { get; set; }
        public double SUie { get; set; }
        public double SUif { get; set; }

        public string Selector4 { get; set; }

        public string Selector4a { get; set; }

        public string Selector4b { get; set; }

        public string Selector4c { get; set; }

        public string Selector4d { get; set; }

        public string Selector4e { get; set; }

        public string Selector4f { get; set; }

        public List<SelectListItem> LISTA { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "2,9", Text = "Amfibolit" },
            new SelectListItem { Value = "2,2", Text = "Andezyt" },
            new SelectListItem { Value = "4,1", Text = "Anhydryt" },
            new SelectListItem { Value = "3,1", Text = "Aplit" },
            new SelectListItem { Value = "2,9", Text = "Arkoza" },
            new SelectListItem { Value = "1,7", Text = "Bazalt" },
            new SelectListItem { Value = "0,7", Text = "Bentonit 12%" },
            new SelectListItem { Value = "1,5", Text = "Bentonit/ Piasek 12%/50%" },
            new SelectListItem { Value = "1,6", Text = "Beton" },
            new SelectListItem { Value = "2,8", Text = "Brekcja" },
            new SelectListItem { Value = "2,6", Text = "Dioryt" },
            new SelectListItem { Value = "3,2", Text = "Dolomit" },
            new SelectListItem { Value = "1,9", Text = "Gabro" },
            new SelectListItem { Value = "1,6", Text = "Gips" },
            new SelectListItem { Value = "2,9", Text = "Gneis" },
            new SelectListItem { Value = "3,4", Text = "Granit" },
            new SelectListItem { Value = "0,4", Text = "Ił, Glina sucha" },
            new SelectListItem { Value = "1,6", Text = "Ił wilgotny" },
            new SelectListItem { Value = "2,2", Text = "Iłowiec" },
            new SelectListItem { Value = "6,0", Text = "Kwarcyt" },   
            new SelectListItem { Value = "2,1", Text = "Łupek ilasty" },
            new SelectListItem { Value = "2,6", Text = "Marmur" },
            new SelectListItem { Value = "2,1", Text = "Margiel" },
            new SelectListItem { Value = "2,2", Text = "Margiel dolomityczny" },
            new SelectListItem { Value = "2,0", Text = "Mica" },
            new SelectListItem { Value = "3,0", Text = "Pegmatyt" },
            new SelectListItem { Value = "4,0", Text = "Perydotyt" },
            new SelectListItem { Value = "0,4", Text = "Piasek suchy" },
            new SelectListItem { Value = "1,2", Text = "Piasek suchy zbity" },
            new SelectListItem { Value = "1,0", Text = "Piasek wilgotny" },
            new SelectListItem { Value = "2,4", Text = "Piasek nasycony(nawodniony)" },
            new SelectListItem { Value = "2,0", Text = "Piasek zmrożony" },
            new SelectListItem { Value = "2,3", Text = "Piaskowiec" },
            new SelectListItem { Value = "0,4", Text = "Pył Suchy" },
            new SelectListItem { Value = "1,8", Text = "Pył Wilgotny" },
            new SelectListItem { Value = "2,4", Text = "Pyłowiec" },
            new SelectListItem { Value = "0,02", Text = "Powietrze" },
            new SelectListItem { Value = "3,0", Text = "Serpentyn" },
            new SelectListItem { Value = "2,2", Text = "Wapień marglisty" },
            new SelectListItem { Value = "2,4", Text = "Wapień oolitowy" },
            new SelectListItem { Value = "0,4", Text = "Torf" },
            new SelectListItem { Value = "0,6", Text = "Woda(temp 0-10C)" },
            new SelectListItem { Value = "0,3", Text = "Węgiel" },
            new SelectListItem { Value = "2,8", Text = "Wapień zbity" },
            new SelectListItem { Value = "0,4", Text = "Żwir suchy" },
            new SelectListItem { Value = "1,8", Text = "Żwir nasycony" },
            new SelectListItem { Value = "2,8", Text = "Zlepieniec" },
        };

    }
}
