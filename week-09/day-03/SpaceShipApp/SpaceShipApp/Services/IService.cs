using SpaceShipApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.Services
{
    public interface IService
    {
        SpaceEntityDto GetAllSpaceEntities();
        void MoveSpaceShipToPlanetById(int id);
    }
}
