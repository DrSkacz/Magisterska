using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Magisterka.Models
{
    public class Listy
    {
        public string Lista1 { get; set; }

        public List<SelectListItem> Głębokośc { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "-3.5", Text = "0" },
            new SelectListItem { Value = "-2.2", Text = "0,25" },
            new SelectListItem { Value = "-1.1", Text = "0,5"  },
            new SelectListItem { Value = "0", Text = "0,75" },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "1,25" },
            new SelectListItem { Value = "3", Text = "1,5"  },
            new SelectListItem { Value = "3.9", Text = "1,75"  },
            new SelectListItem { Value = "4.9", Text = "2,0" },
            new SelectListItem { Value = "5.5", Text = "2,25" },
            new SelectListItem { Value = "6.5", Text = "2,5"  },
            new SelectListItem { Value = "7", Text = "2,75"  },
            new SelectListItem { Value = "9.5", Text = "3,0" },
          
        };

        public string Lista2 { get; set; }

        public List<SelectListItem> Ziemia { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "2.33", Text = "Grunt gliniasty" },
            new SelectListItem { Value = "1.16", Text = "Grunt piaszczysty" },
            new SelectListItem { Value = "1.33", Text = "Piasek o wilgoci 20%"  },
            new SelectListItem { Value = "1.88", Text = "Piasek nasycony wodą" },
            new SelectListItem { Value = "1.76", Text = "Piasek morski o wilgoci 20%" },
            new SelectListItem { Value = "1.33", Text = "Piasek morski nasycony"  },
            new SelectListItem { Value = "2.1", Text = "Grunt wilgony" },
            new SelectListItem { Value = "1.4", Text = "Grunt średniowilgotny"  },
        };

        public string Lista3 { get; set; }

        public List<SelectListItem> Rury { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "1.5", Text = "2" },
            new SelectListItem { Value = "1.8", Text = "3"  },
            new SelectListItem { Value = "2.1", Text = "4"  },
        };
    }
}
