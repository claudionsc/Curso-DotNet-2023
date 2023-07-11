using Flurl.Http;
using System.Collections.Generic;
using System.Net;

namespace Consumidor.API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            string url = "https://localhost:7244/";

            string endpoint = url + "api/TarefaItems";

            IEnumerable<Trabalho> listaTarefas = endpoint.GetJsonAsync<IEnumerable<Trabalho>>().Result;

            dtgGrid.DataSource = listaTarefas;
        }
    }
}