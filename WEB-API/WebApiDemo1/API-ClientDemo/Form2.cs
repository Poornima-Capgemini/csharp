﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace API_ClientDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Employ
        {
            public int Empno { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
            public string Desig { get; set; }
            public int Basic { get; set; }
        }
        HttpClient client;
        public async void GetEmploy(int id)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52015/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.
          Accept.Add(new MediaTypeWithQualityHeaderValue
          ("application/json"));

                HttpResponseMessage response =
                            await client.GetAsync("api/Employ/" + id);
                if (response.IsSuccessStatusCode)
                {
                    string employs = await response.Content.ReadAsStringAsync();
                    Employ c = JsonConvert.DeserializeObject<Employ>(employs);
                    if (c != null)
                    {
                        txtName.Text = c.Name;
                        txtDept.Text = c.Dept;
                        txtDesig.Text = c.Desig;
                        txtBasic.Text = c.Basic.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employs not available");
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetEmploy(Convert.ToInt32(txtEmpno.Text));
        }
    }
}
