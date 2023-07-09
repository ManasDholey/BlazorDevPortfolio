using DevPortfolioServer.Data;
using DevPortfolioShared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace DevPortfolioServer.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDataDBContext _appDBContext;

        public CategoriesController(AppDataDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Category> categories = await _appDBContext.Categories.ToListAsync();

            return Ok(categories);
        }
    }
}
