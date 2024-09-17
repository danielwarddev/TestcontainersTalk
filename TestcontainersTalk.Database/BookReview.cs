using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestcontainersTalk.Database;

public class BookReview
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int BookId { get; set; }
    public int UserId { get; set; }
    public string ReviewContent { get; set; } = null!;
}