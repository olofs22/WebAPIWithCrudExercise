using Microsoft.AspNetCore.Mvc;
using WebAPIWithCrud.Models;
using System.Linq;
using WebAPIWithCrud.Services;

namespace WebAPIWithCrud.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{

    private readonly ItemsService _itemsService;

    public ItemsController(ItemsService itemsService)
    {
        _itemsService = itemsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Item>> GetAll() => Ok(_itemsService.GetAll());

    [HttpGet("{id:int}")]
    public ActionResult<Item> Get(int id)
    {
        var item = _itemsService.Get(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public ActionResult<Item> Create(Item item)
    {
        var newItem = _itemsService.Create(item);
        return Created($"/api/items/{newItem.Id}", newItem);
    }

    [HttpPut("{id:int}")]
    public ActionResult Update(int id, Item item)
    {
        if (!_itemsService.Update(id, item)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        if (!_itemsService.Delete(id)) return NotFound();
        return NoContent();
    }

}