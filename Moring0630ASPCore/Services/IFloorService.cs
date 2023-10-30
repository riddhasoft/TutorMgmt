using Moring0630ASPCore.Data;
using Moring0630ASPCore.Migrations;
using Moring0630ASPCore.Models;

namespace Moring0630ASPCore.Services
{
    public interface IFloorService
    {
        List<Floor> GetFloors();
        int Add(Floor model);
        int Update(Floor model);
        Floor FindFloor(int id);
        int Delete(int id);
        List<Building> GetBuildings();
    }

}
