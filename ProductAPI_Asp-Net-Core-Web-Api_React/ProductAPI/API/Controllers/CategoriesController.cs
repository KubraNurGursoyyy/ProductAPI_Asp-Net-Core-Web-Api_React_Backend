using DTO.DTOs;
using AutoMapper;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoriesController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _categoryService.GetAllAsync();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await _categoryService.GetByIdAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryDTO categoryDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _categoryService.AddAsync(categoryDto);
        return CreatedAtAction(nameof(GetCategoryById), new { id = categoryDto.ID }, categoryDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryDTO categoryDto)
    {
        if (id != categoryDto.ID || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _categoryService.UpdateAsync(categoryDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var category = await _categoryService.GetByIdAsync(id);
        if (category == null)
        {
            return NotFound();
        }

        await _categoryService.DeleteAsync(id);
        return NoContent();
    }
}


/*
private readonly IUserService _userService;
private readonly IMapper _mapper;

public UsersController(IUserService userService, IMapper mapper)
{
_userService = userService;
_mapper = mapper;
}

[HttpPost]
public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
{
var userEntity = _mapper.Map<UserEntities>(userDto); // DTO'dan Entity'ye dönüştür
await _userService.CreateUserAsync(userEntity); // Entity ile servis metoduna gönder
return CreatedAtAction(nameof(GetUser), new { id = userEntity.ID }, userDto);
}
*/
