using WebAPIWithCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebAPIWithCrud.Services;

public class ItemsService
{
    private static readonly List<Item> Items = new();
    private static int _nextId = 1;

    public IEnumerable<Item> GetAll() => Items;

    public Item? Get(int id) => Items.FirstOrDefault(item => item.Id == id);

    public Item Create(Item item)
    {
        item.Id = _nextId++;
        Items.Add(item);
        return item;
    }

    public bool Update(int id, Item item)
    {
        var existing = Items.FirstOrDefault(x => x.Id == id);
        if (existing == null) return false;
        existing.Name = item.Name;
        return true;
    }

    public bool Delete(int id)
    {
        var item = Items.FirstOrDefault(x => x.Id == id);
        if (item == null) return false;
        Items.Remove(item);
        return true;
    }
}
