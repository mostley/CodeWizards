namespace CodeWizards.Server
{
    using System;
    using Contracts;

    public class CodeWizardsServer : ICodeWizardsServer
    {
        readonly Sessions sessions = new Sessions();

        readonly Game game = new Game();

        public void WriteScroll(string token, string name, string code)
        {
        }

        public string Join(string username)
        {
            var token = Guid.NewGuid().ToString();
            sessions.Add(token, new Session());
            return token;
        }

        public void Leave(string token)
        {
            sessions.Remove(token);
        }

        public WorldUpdate GetUpdate(string token)
        {
            var worldUpdate = new WorldUpdate();

            //TODO:

            return worldUpdate;
        }

    }
}
