using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.Primitives;

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

        public double Selector1 { get; set; }

        public double Selector2 { get; set; }


        public List<SelectListItem> GlebokoscR { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "-3,5", Text = "0" },
            new SelectListItem { Value = "-2,2", Text = "0,25" },
            new SelectListItem { Value = "-1,1", Text = "0,5"  },
            new SelectListItem { Value = "0", Text = "0,75" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "1,25" },
            new SelectListItem { Value = "3", Text = "1,5"  },
            new SelectListItem { Value = "3,9", Text = "1,75"  },
            new SelectListItem { Value = "4,9", Text = "2,0" },
            new SelectListItem { Value = "5,5", Text = "2,25" },
            new SelectListItem { Value = "6,5", Text = "2,5"  },
            new SelectListItem { Value = "7", Text = "2,75"  },
            new SelectListItem { Value = "9,5", Text = "3,0" }
        };

        public List<SelectListItem> GlebaR { get; set; } = new List<SelectListItem>
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
        public StringValues Gleba { get; internal set; }
    }
}
