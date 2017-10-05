using System;
using System.ComponentModel.DataAnnotations;

namespace FCApi.Models
{
    public class Post
    {
        [Key]

        public int PostId { get; set; }

        [Required(ErrorMessage ="?????? ????? ????? ???????")]

        [Display(Name ="????? ???????")]

        public string post_title { get; set; }

        public int post_status{ get; set; }

        [DataType(DataType.Date)]

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]

        public DateTime post_adate { get; set; }

        [Display(Name ="??????")]

        public string post_author { get; set; }

        [Display(Name ="????????")]

        // [UIHint("tinymce_Jquery_Full"), AllowHtml]

        public string post_data { get; set; }

        [Display(Name = "???? ???????")]

        public string post_excerpt { get; set; }

        [Display(Name = "???? ??????? ????????")]

        public string post_img { get; set; }

        [Display(Name = "????? ??????")]

        public string post_img_title { get; set; }
    }
}