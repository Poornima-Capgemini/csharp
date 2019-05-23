using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace API_ClientDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HttpClient client;
        protected async void GetAllEmployees()
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52015/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Employ");
                if(response.IsSuccessStatusCode)
                {
                    string employs = await response.Content.ReadAsStringAsync();
                    List<Employ> clist = JsonConvert.DeserializeObject<List<Employ>>(employs);

                    MessageBox.Show(employs);
                    dgEmploy.DataSource = clist.ToList();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllEmployees();
        }
        public class Employ
        {
            public int Empno { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
            public string Desig { get; set; }
            public int Basic { get; set; }

        }
    }
}
