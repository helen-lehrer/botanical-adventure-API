using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BotanicalAdventure.Models;

namespace BotanicalAdventure.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ItemsController : ControllerBase
  {
    private readonly BotanicalAdventureContext _db;
    public ItemsController(BotanicalAdventureContext db)
    {
      _db = db;
    }

    //GET api/items
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Item>>> Get (string name, string category, string type, string difficulty)
    {
      var query = _db.Items.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (difficulty != null)
      {
        query = query.Where(entry => entry.Difficulty == difficulty);
      }
      
      return await query.ToListAsync();
    }

    // GET: api/items/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Item>> GetItem(int id)
    {
      var item = await _db.Items.FindAsync(id);

      if (item == null)
      {
        return NotFound();
      }

      return item;
    }

    //PUT: api/items/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Item item)
    {
      if(id != item.ItemId)
      {
        return BadRequest();
      }
      _db.Entry(item).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ItemExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
  private bool ItemExists(int id)
  {
    return _db.Items.Any(e => e.ItemId == id);
  }

  //Delete: api/items/1
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteItem(int id)
  {
    var item = await _db.Items.FindAsync(id);
    if (item == null)
    {
      return NotFound();
    }

    _db.Items.Remove(item);
    await _db.SaveChangesAsync();

    return NoContent();
  }

  }
}