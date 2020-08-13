using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Magisterka.Models
{
    public class pKO
    {
        //[RegularExpression(@"^ 0 - 9, 0 - 9] + $")]
        //[StringLength(5)]
        //[Required]
        public double KQc { get; set; }

        public double KCOP { get; set; }

        public double KQ0 { get; set; }

        public double KH { get; set; }

        public double KZ { get; set; }

        public double KB { get; set; }

        public double KTgr { get; set; }

        public double KTgm { get; set; }

        public double Ktp { get; set; }

        public double Kalfag { get; set; }

        public double Kalfap { get; set; }

        public double KAgr { get; set; }

        public double KAr { get; set; }

        public double Kdw { get; set; }

        public double Kdz { get; set; }

        public double KK { get; set; }

        public double KAAgr { get; set; }

        public double KqL { get; set; }

        public double Kqh { get; set; }

        public double Kep { get; set; }

        public double KLp { get; set; }

        public double selector3 { get; set; }

        public double Lista3 { get; set; }

        public List<SelectListItem> List3 { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "1,5", Text = "2" },
            new SelectListItem { Value = "1,8", Text = "3"  },
            new SelectListItem { Value = "2,1", Text = "4"  },
        };

    }
}
