using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TomMyLibrary.Dto;

namespace TomMyLibrary.Models;

[Table("library")]
public class Library
{
    public Library()
    {
            
    }
    public Library(LibraryDto libraryDto)
    {
        this.id = Guid.NewGuid().ToString();
        this.userid = libraryDto.userid;
        this.datacreate = DateTime.UtcNow;
        this.isbn = libraryDto.ISBN;
    }

    [Key]
    public string id { get; set; }
    public int userid { get; set; }
    public DateTime datacreate { get; set; }
    public long isbn { get; set; }
}
