using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebAPIWithCrud.Data;
using WebAPIWithCrud.Models;

namespace WebAPIWithCrud.Services;

public class ItemsService
{
    private readonly AppDbContext _context;
    private readonly List<Items> _items = new();
    private int _nextId = 1;

    public ItemsService(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Items> GetAll()
    {
        return _context.Items.ToList();
    }

    public Items? GetById(int id)
    {
        return _context.Items.Find(id);
    }

    public Items? GetByName(string name)
    {
        return _context.Items.FirstOrDefault(i => i.Name == name);
    }

    public Items? Create(Items item)
    {
        _context.Items.Add(item);
        _context.SaveChanges();
        return item;
    }

    public bool Update(int id, Items item)
    {
        var existingItem = _context.Items.Find(id);
        if (existingItem.Name == null)
            return false;

        existingItem.Name = item.Name;
        existingItem.Description = item.Description;

        _context.SaveChanges();
        return true;
    }

    public bool Delete(int id)
    {
        var item = _context.Items.Find(id);
        if (item == null)
            return false;

        _context.Items.Remove(item);
        _context.SaveChanges();
        return true;
    }
}
