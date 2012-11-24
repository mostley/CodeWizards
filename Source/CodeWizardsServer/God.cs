using System;
using CodeWizards.Contracts;

namespace CodeWizards.Server
{
    public class God
    {
        const int SizeX = 40;
        const int SizeY = 40;

        public World CreateWorld()
        {
            var world = new World(SizeX, SizeY);

            AddStones(world);

            return world;
        }

        void AddStones(World world)
        {
            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                world.AddEntity(new ServerEntity(new Vector(random.NextDouble() * world.SizeX, random.NextDouble() * world.SizeY)));
            }
        }
    }
}