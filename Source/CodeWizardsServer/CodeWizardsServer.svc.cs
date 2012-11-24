namespace CodeWizards.Server
{
    using System;
    using System.Collections.Generic;

    using CodeWizards.Contracts;

    public class CodeWizardsServer : ICodeWizardsServer
    {
        public Dictionary<string, Session> Sessions { get; set; }

        public void WriteScroll(string token, string name, string code)
        {
        }

        public string Join(string username)
        {
            var token = Guid.NewGuid().ToString();
            Sessions.Add(token, new Session());
            return token;
        }

        public void Leave(string token)
        {
            Sessions.Remove(token);
        }

        public WorldUpdate GetUpdate(string token)
        {
            return null;
        }
    }
}
