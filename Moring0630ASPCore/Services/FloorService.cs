using Microsoft.EntityFrameworkCore;
using Moring0630ASPCore.Data;
using Moring0630ASPCore.Models;

namespace Moring0630ASPCore.Services
{
    public class FloorService : IFloorService
    {
        private readonly AppDbContext _context;

        public FloorService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Floor model)
        {
            _context.Floors.Add(model);
            return _context.SaveChanges();
        }

        public Floor FindFloor(int id)
        {
            return _context.Floors.Find(id);
        }

        public List<Floor> GetFloors()
        {
            return _context.Floors.Include(x => x.Building).ToList();
        }

        public int Update(Floor model)
        {
            _context.Floors.Update(model);
            return _context.SaveChanges();
        }
        public int Delete(int id)
        {
            var model = FindFloor(id);
            _context.Floors.Remove(model);
            return _context.SaveChanges();
        }

        public List<Building> GetBuildings()
        {
            return _context.Buildings.ToList();
        }
    }
}
