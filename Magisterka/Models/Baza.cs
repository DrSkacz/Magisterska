using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Magisterka.Models
{
    public class Baza
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public string DATA { get; set; }

        [Required]
        public string Nazwa{ get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Opis { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RQg { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RFi { get; set; }
        /* WARTOSC Z SELECTA nie wiem czy jest potrzebna
                [Required(AllowEmptyStrings = true)]
                [DisplayFormat(ConvertEmptyStringToNull = false)]
                [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
                public string Rro { get; set; }
        */
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RQ0 { get; set; }
        //WARTOSC Z SELECTA2 nie wiem czy jest potrzebna
        
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RXo { get; set; }
        

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RDz { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Rtinf { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Rt { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RL { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KQc { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KCOP { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KQ0 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KH { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KZ { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KB { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KTgr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string DT { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KTgm { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Ktp { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Kalfag { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Kalfap { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KAgr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Agr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KAr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Kdw { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Kdz { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KK { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KC { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KqL { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Kqh { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Kep { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string KLp { get; set; }


        public List<SelectListItem> Zmienne { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "RQg", Text = "RQg" },
            new SelectListItem { Value = "RQg", Text = "RQg" },
            new SelectListItem { Value = "RQg", Text = "RQg"  },
            new SelectListItem { Value = "RQg", Text = "RQg"  },
        };


    }
}
