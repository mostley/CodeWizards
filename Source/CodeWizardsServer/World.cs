using System.Collections.Generic;
using System.Linq;
using CodeWizards.Contracts;

namespace CodeWizards.Server
{
    public class World
    {
        public double SizeX { get; private set; }
        public double SizeY { get; private set; }

        public List<ServerEntity> Entities { get; set; }

        public World(double sizeX, double sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
            Entities = new List<ServerEntity>();
        }

        public void AddEntity(ServerEntity serverEntity)
        {
            Entities.Add(serverEntity);
        }

        public IEnumerable<ServerEntity> GetEntitiesInRadius(Vector position, double radius)
        {
            return Entities.Where(e => (e.Position - position).Length < radius);
        }
    }
}