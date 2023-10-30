using Moring0630ASPCore.Data;
using Moring0630ASPCore.Models;

namespace Moring0630ASPCore.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly AppDbContext _context;

        public BuildingService(AppDbContext appDbContext)
        {
            _context=appDbContext;
        }
        public int Add(Building model)
        {
            _context.Buildings.Add(model);
            _context.SaveChanges();
            return model.Id;
        }

        public int Delete(Building model)
        {
            _context.Buildings.Remove(model);
            return _context.SaveChanges();
        }

        public Building Find(int id)
        {
            return _context.Buildings.Find(id);
        }

        public List<Building> ToList()
        {
           return _context.Buildings.ToList();
        }

        public int Update(Building model)
        {
            _context.Buildings.Update(model);
            return _context.SaveChanges();
        }
    }
}
