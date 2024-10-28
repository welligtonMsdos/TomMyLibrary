using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TomMyLibrary.Dto;
using TomMyLibrary.Interfaces;
using TomMyLibrary.Models;

namespace TomMyLibrary.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibraryController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILibrary _library;

    public LibraryController(ILibrary library, IMapper mapper)
    {
        _library = library;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<Library>> AddBookToLibrary(LibraryDto libraryDto)
    {
        try
        {
            var library = await _library.AddBookToLibrary(libraryDto);

            return Ok(library);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{userId}")]
    public async Task<ActionResult<IEnumerable<LibraryGetDto>>> GetLibraryByUserId(int userId)
    {
        try
        {
            var booksMyLibrary = _mapper.Map<List<LibraryGetDto>>(await _library.GetLibraryByUserId(userId));

            return Ok(booksMyLibrary);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
