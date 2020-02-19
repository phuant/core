using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100,ErrorMessage ="Max Length 100 Characters")]
        [Required(ErrorMessage ="Must Be Name")]
        public string Name { get; set; }

        public DateTime? CreateDate { get; set; }

        [ForeignKey("AuthorId")]
        [Required(ErrorMessage ="Must Be AuthorId")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
