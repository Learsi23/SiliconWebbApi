﻿
using Infrastructure.Contexts;
using Infrastructure.Factories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace SiliconWebbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
//[UseApiKey]
public class CategoryController(Datacontext context) : ControllerBase
{

    private readonly Datacontext _context = context;



    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await _context.Categories.OrderBy(o => o.CategoryName).ToListAsync();
        return Ok(CategoryFactory.Create(categories));
    }

}
