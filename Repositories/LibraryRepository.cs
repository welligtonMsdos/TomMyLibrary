using Microsoft.EntityFrameworkCore;
using TomMyLibrary.Data;
using TomMyLibrary.Dto;
using TomMyLibrary.Interfaces;
using TomMyLibrary.Models;

namespace TomMyLibrary.Repositories;

public class LibraryRepository : ILibrary
{
    private readonly DBTomBookContext _context;
    public LibraryRepository(DBTomBookContext context)
    {
        _context = context;
    }
    public async Task<Library> AddBookToLibrary(LibraryDto libraryDto)
    {
        var library = new Library(libraryDto);

        _context.libraries.Add(library);

        await _context.SaveChangesAsync();

        return library;
    }

    public async Task<IEnumerable<Library>> GetLibraryByUserId(int userId)
    {
        var booksMyLibrary = await _context
            .libraries
            .Where(x=>x.userid == userId)
            .ToListAsync();

        return booksMyLibrary;
    }
}
