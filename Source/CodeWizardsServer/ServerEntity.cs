using CodeWizards.Contracts;

namespace CodeWizards.Server
{
    public class ServerEntity
    {
        public Vector Position { get; set; }

        public ServerEntity(Vector position)
        {
            Position = position;
        }
    }
}