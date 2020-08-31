﻿using System;
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
        public string Nazwa { get; set; }

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

        /*
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string RXo { get; set; } 
        */

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

        /// <summary>
        /// ///////////////////////////////////////
        /// </summary>

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

        ////////////////////////////////////////
        /////////////////////
        ////////////////////////////////////////
        ///
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SQv { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SLo { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SLw { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SdLw { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SQc { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SCOP { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string STsp { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string SQ0 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BDz { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BDw { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Blambdar { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Bn { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BRr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BQ { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BCOP { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BTgr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BTgo { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BRgr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Btp { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string Btg { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [RegularExpression(@"^[0-9',''.'\s\-]{1,40}$", ErrorMessage = "Prosze używać liczb")]
        public string BL { get; set; }

    }

    public class Lista
    {
        public string Zmienna { get; set; }
        public string Opiszmiennej { get; set; }
    }
   

}


