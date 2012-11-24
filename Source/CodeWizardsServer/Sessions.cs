using System.Collections.Generic;

namespace CodeWizards.Server
{
    public class Sessions
    {
        readonly Dictionary<string, Session> sessions = new Dictionary<string, Session>();
        readonly object syncObject = new object();

        public void Add(string token, Session session)
        {
            lock (syncObject)
            {
                sessions.Add(token, session);
            }
        }

        public void Remove(string token)
        {
            lock (syncObject)
            {
                sessions.Remove(token);
            }
        }
    }
}