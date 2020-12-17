using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Magisterka.Models
{
    public class Obl
    {
        //[RegularExpression(@"^ 0 - 9, 0 - 9] + $")]
        //[StringLength(5)]
        //[Required]
        public double RQg { get; set; }

        public double RFi { get; set; }

        public double Rro { get; set; }

        public double RQ0 { get; set; }

        public double RXo { get; set; }

        public double RDz { get; set; }

        public double Rtinf { get; set; }

        public double Rt { get; set; }

        public double RL { get; set; }
        
        public string BOX1 { get; set; }

        public string BOX2 { get; set; }

        public string BOX3 { get; set; }

        public string Selector1 { get; set; }
        
        public List<SelectListItem> Glebokosc { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "0", Text = "0" },
            new SelectListItem { Value = "0,25", Text = "0,25" },
            new SelectListItem { Value = "0,5", Text = "0,5"  },
            new SelectListItem { Value = "0,75", Text = "0,75" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "1,25", Text = "1,25" },
            new SelectListItem { Value = "1,5", Text = "1,5"  },
            new SelectListItem { Value = "1,75", Text = "1,75"  },
            new SelectListItem { Value = "2,0", Text = "2,0" },
            new SelectListItem { Value = "2,25", Text = "2,25" },
            new SelectListItem { Value = "2,5", Text = "2,5"  },
            new SelectListItem { Value = "2,75", Text = "2,75"  },
            new SelectListItem { Value = "3,0", Text = "3,0" },
            new SelectListItem { Value = "4,375", Text = "4,375" },
            new SelectListItem { Value = "6,875", Text = "6,875"  },

        };

        public string Selector3 { get; set; }

        public List<SelectListItem> Miesiac { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Styczeń" },
            new SelectListItem { Value = "2", Text = "Luty" },
            new SelectListItem { Value = "3", Text = "Marzec"  },
            new SelectListItem { Value = "4", Text = "Kwiecień" },
            new SelectListItem { Value = "5", Text = "Maj" },
            new SelectListItem { Value = "6", Text = "Czerwiec" },
            new SelectListItem { Value = "7", Text = "Lipiec"  },
            new SelectListItem { Value = "8", Text = "Sierpień"  },
            new SelectListItem { Value = "9", Text = "Wrzesień" },
            new SelectListItem { Value = "10", Text = "Pazdiernik" },
            new SelectListItem { Value = "11", Text = "Listopad"  },
            new SelectListItem { Value = "12", Text = "Grudzień"  },
        };


        public string Selector2 { get; set; }

        public List<SelectListItem> Gleba { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "2,33", Text = "Grunt gliniasty" },
            new SelectListItem { Value = "1,16", Text = "Grunt piaszczysty" },
            new SelectListItem { Value = "1,33", Text = "Piasek o wilgoci 20%"  },
            new SelectListItem { Value = "1,88", Text = "Piasek nasycony wodą" },
            new SelectListItem { Value = "1,76", Text = "Piasek morski o wilgoci 20%" },
            new SelectListItem { Value = "1,33", Text = "Piasek morski nasycony"  },
            new SelectListItem { Value = "2,1", Text = "Grunt wilgony" },
            new SelectListItem { Value = "1,4", Text = "Grunt średniowilgotny"  },
        };
    }
}
