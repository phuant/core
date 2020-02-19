using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCore.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Must be Name")]
        [MaxLength(100,ErrorMessage ="Max Length 100 Characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Must Be PenName")]
        [MaxLength(150,ErrorMessage = "Max Length 150 Characters")]

        public string PenName { get; set; }
        [MaxLength(150,ErrorMessage ="Max Length 150 Characters")]
        [EmailAddress(ErrorMessage ="Email is valid")]

        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
