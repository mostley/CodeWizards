using System;
using System.Windows.Forms;
using CodeWizards.TestClient.CodeWizardsServer;

namespace CodeWizards.TestClient
{
    public partial class Form1 : Form
    {
        private readonly CodeWizardsServerClient client;
        private string token;

        public Form1()
        {
            InitializeComponent();

            client = new CodeWizardsServerClient();
        }


        private void Button1Click(object sender, EventArgs e)
        {
            token = this.client.Join("TestClient");
        }
    }
}
