namespace CodeWizards.Server
{
    public class Game
    {
        public int Round { get; private set; }
        protected World World { get; private set; }

        public Game()
        {
            World = new God().CreateWorld();
        }

        void Update()
        {
            
        }
    }
}