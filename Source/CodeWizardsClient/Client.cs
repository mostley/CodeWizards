namespace CodeWizards.Client
{
    using CodeWizards.Client.CodeWizardServerProxy;

    public class Client
    {
        private readonly CodeWizardsServerClient client;
        private string token;

        public Client(string username)
        {
            this.client = new CodeWizardsServerClient();

            this.token = this.client.Join(username);
        }
    }
}
