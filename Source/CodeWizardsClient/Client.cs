namespace CodeWizards.Client
{
    using System;
    using System.Timers;

    using CodeWizards.Client.CodeWizardServerProxy;
    using CodeWizards.Contracts;

    public class Client
    {
        private readonly CodeWizardsServerClient client;
        private readonly string token;

        private readonly Timer updateTimer;

        public Client(string username)
        {
            this.client = new CodeWizardsServerClient();

            this.token = this.client.Join(username);

            this.updateTimer = new Timer(500);
            this.updateTimer.Elapsed += this.UpdateTimerElapsed;
            this.updateTimer.Start();
        }

        private void UpdateTimerElapsed(object o, ElapsedEventArgs e)
        {
            var updateData = this.client.GetUpdate(this.token);

            this.OnUpdate(updateData);
        }

        public event Action<WorldUpdate> Update;

        protected virtual void OnUpdate(WorldUpdate obj)
        {
            var handler = this.Update;
            if (handler != null)
            {
                handler(obj);
            }
        }
    }
}
