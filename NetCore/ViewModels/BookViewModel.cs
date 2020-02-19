using System;
using System.ComponentModel.DataAnnotations;

namespace NetCore.ViewModel
{
    public class BookViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Max Length 100 Characters")]
        [Required(ErrorMessage = "Must Be Name")]
        public string Name { get; set; }

        public DateTime? CreateDate { get; set; }

        [Required(ErrorMessage = "Must Be AuthorId")]
        public int AuthorId { get; set; }

        public AuthorViewModel Author { get; set; }
    }
}
