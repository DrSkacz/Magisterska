using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

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

  
        public List<ZmiennaItem> Zmienne = new List<ZmiennaItem>()
        {
            new ZmiennaItem("RQg","Moc grzewcza pompy ciepła"),
            new ZmiennaItem("RFi","Znamionowy współczynnik wydajnosci"),
            new ZmiennaItem("RQ0","Moc cieplna pobierana z gruntu"),
            new ZmiennaItem("RDz","Średnica zewnętrzna rury"),
            new ZmiennaItem("Rtinf","Temperatura gruntu na glebokosci"),
            new ZmiennaItem("Rt","Temperatura nośnika ciepła odpływająca z wymiennika gruntowego"),
            new ZmiennaItem("RL","Długość rury wymiennika ciepła"),
            ///////////////////////////////////////////////
            new ZmiennaItem("KQc","Zapotrzebowanie na moc cieplną pompy ciepła"),
            new ZmiennaItem("KCOP","Współczynnik efektywności pompy"),
            new ZmiennaItem("KQ0","Moc cieplna"),
            new ZmiennaItem("KH","Głębokość osadzenia wymiennika"),
            new ZmiennaItem("KZ","Głębokość stałej temperatury gruntu"),
            new ZmiennaItem("KB","Współczynnik B"),
            new ZmiennaItem("KTgr","Temperatura gruntu - stała"),
            new ZmiennaItem("KTgm","Temperatura płynu w obiegu"),
            new ZmiennaItem("Ktp","Temperatura powietrza przy gruncie"),
            new ZmiennaItem("DT","Różnica temperatur"), 
            new ZmiennaItem("Kalfag","Współczynnik przejmowania ciepła od strony glikolu"),
            new ZmiennaItem("Kalfap","Współczynnik przejmowania ciepła od strony powietrza"),
            new ZmiennaItem("KAgr","Współczynnik przejmowania ciepła gruntu"),
            new ZmiennaItem("KAr","Współczynnik przejmowania ciepła rury"),
            new ZmiennaItem("Kdw","Średnica wewnętrzna rury"),
            new ZmiennaItem("Kdz","Średnica zewnetrzna rury"),        
            new ZmiennaItem("KK","Współczynnik K"),
            new ZmiennaItem("KC","Współczynnik C"),
            new ZmiennaItem("Agr","Współczynnik przewodzenia gruntu"),
            new ZmiennaItem("KqL","Jednostkowy strumień ciepła"),
            new ZmiennaItem("Kep","Rozstawienie rur"),
            new ZmiennaItem("Kqh","Jednostkowa wydajność cieplna"),
            new ZmiennaItem("KLp","Łączna długość wymiennika ciepła"),
            /////////////////////////////////////////////
            new ZmiennaItem("SQc","Moc cieplna pompy ciepła"),
            new ZmiennaItem("SCOP","Współczynnik sprawności pompy ciepła"),
            new ZmiennaItem("SQ0","Moc chłodnicza pompy ciepła"),
            new ZmiennaItem("SQv","Jednostkowa wydajnosć gruntu"),
            new ZmiennaItem("SLo","Wymagana długość sondy"),      
            new ZmiennaItem("STsp","Czas pracy w ciągu całego roku (podany w H)"),
            new ZmiennaItem("SdLw","Dodatkowa procentowa długość sondy"),
            new ZmiennaItem("SLw","Łączna długość wymiennika ciepła"),       
            /////////////////////////////////////////////
            new ZmiennaItem("BDz","Średnica zewnetrzna rury"),
            new ZmiennaItem("BDw","Średnica wewnętrzna rury"),
            new ZmiennaItem("Bn","Liczba rur w obwodzie"),
            new ZmiennaItem("Blambdar","Współczynnik prewodzenia materiału rury"),
            new ZmiennaItem("BRr","Zredukowany opór jednostkowy gruntu"),
            new ZmiennaItem("BRgr","Opór jednostkowy gruntu dla pojedynczego odwiertu"),
            new ZmiennaItem("Btp","Czas pracy pompy cieplnej"),
            new ZmiennaItem("Btg","Czas działania instalacji"),
            new ZmiennaItem("BQ","Moc grzejna pompy ciepła"),
            new ZmiennaItem("BCOP","Współczynnik sprawności pompy ciepła"),
            new ZmiennaItem("BTgr","Temperatura gruntu"),
            new ZmiennaItem("BTgo","Temperatura płynu opuszczajacego parowacz"),
            new ZmiennaItem("BL","Łączna długość wymiennika ciepła")
    };

  }
    public class ZmiennaItem
    {
        public string Zmienna { get; set; }
        public string OpisZmiennej { get; set; }
        public string Wartosc { get; set; }

        public ZmiennaItem(string zmienna, string opiszmiennej)
        {
            Zmienna = zmienna;
            OpisZmiennej = opiszmiennej;
        }
    }
}

