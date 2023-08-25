using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Razor_blog.Models
{
    public class CreateArticle
    {

        [DisplayName("عنوان")]
        [Required(ErrorMessage = "عنوان مقاله اجباریست")]
        public string Title { get; set; }

        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage = "عکس مقاله اجباریست")]
        public string Picture { get; set; }

        [DisplayName("عکس Alt")]
        public string PictureAlt { get; set; }

        [DisplayName("عنوان عکس")]
        public string PictureTitle { get; set; }

        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباریست")]
        public string ShortDescription { get; set; }

        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
