using TomMyLibrary.Dto;
using TomMyLibrary.Models;

namespace TomMyLibrary.Interfaces;

public interface ILibrary
{
    Task<IEnumerable<Library>> GetLibraryByUserId(int userId);    
    Task<Library> AddBookToLibrary(LibraryDto libraryDto);
}
