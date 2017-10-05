using System;
using System.ComponentModel.DataAnnotations;

namespace FCApi.Models
{
    public class Image
    {
        [Key]

        public int imgid { get; set; }

        [Display(Name = "???? ??????")]

        public string imgfolder { get; set; }

        public string imgurl_lg { get; set; }

        public string imgurl_sm { get; set; }

        public string imgurl_th { get; set; }

        public string imgfullurl { get; set; }

        [Display(Name = "????? ??????")]

        public string imgtitle { get; set; }

        [Display(Name = "??? ??????")]

        public string imgdesc { get; set; }

        [Display(Name = "???? ?????? ??????")]

        public string imglink { get; set; }

        public DateTime adate { get; set; }

        [Display(Name = "???? ??????")]

        public int status { get; set; }

        [Display(Name = "??? ??????")]

        public string imgw { get; set; }

        [Display(Name = "?????? ??????")]

        public string imgh { get; set; }


    }
}