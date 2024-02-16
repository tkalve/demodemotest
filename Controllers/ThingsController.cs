using DemoDemo.Data;
using DemoDemo.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThingsController : ControllerBase
{
    private readonly ILogger<ThingsController> _logger;
    private readonly DemoContext _context;

    public ThingsController(DemoContext context, ILogger<ThingsController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Thing>> Get()
    {
        var things = await _context.Things.ToListAsync();
        return things;
    }

    [HttpGet("search")]
    public IEnumerable<Thing> Search(string query)
    {
        var sqlQuery = "SELECT Id, Name, Description FROM Things WHERE Name LIKE '%" + query + "%' OR Description LIKE '%" + query + "%'";
        _logger.LogInformation("Performing search: {query}", sqlQuery);
        
        var things = _context.Things.FromSqlRaw(sqlQuery);
        return things;
    }
}
