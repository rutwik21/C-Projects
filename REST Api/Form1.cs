using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace REST_Api
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://fakestoreapi.com");
                var request = new RestRequest("products");
                var response = await client.GetAsync(request);
                
                if (response != null)
                {
                    var products = JsonObject.Parse(response.Content);
                    txtResult.Text = products.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private async void btnGetCategories_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://fakestoreapi.com");
                var request = new RestRequest("products/categories");
                var response = await client.GetAsync(request);

                if (response != null)
                {
                    var products = JsonObject.Parse(response.Content);
                    txtResult.Text = products.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private async void btnGetProduct_Click(object sender, EventArgs e)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                if(txtGetProduct.Text !=null)
                {
                    int productId = Convert.ToInt32(txtGetProduct.Text);
                    using (HttpResponseMessage response = await client.GetAsync($"https://fakestoreapi.com/products/{productId}"))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Above three lines can be replaced with new helper method below
                        // string responseBody = await client.GetStringAsync(uri);
                        txtResult.Text =responseBody;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter Product ID");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show( a.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDelete.Text != null)
                {
                    int productId = Convert.ToInt32(txtDelete.Text);
                    using (HttpResponseMessage response = await client.DeleteAsync($"https://fakestoreapi.com/products/{productId}"))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Above three lines can be replaced with new helper method below
                        // string responseBody = await client.GetStringAsync(uri);
                        txtResult.Text = responseBody;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter Product ID");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show( a.Message);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPostOrUpdate.Text != null)

                {
                    MessageBox.Show(txtPostOrUpdate.Text);
                    var product = JsonConvert.SerializeObject(txtPostOrUpdate.Text);
                    var payload = new StringContent(product, Encoding.UTF8, "application/json");
                    using (HttpResponseMessage response = await client.PostAsync("https://fakestoreapi.com/products",payload))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Above three lines can be replaced with new helper method below
                        // string responseBody = await client.GetStringAsync(uri);
                        txtResult.Text = responseBody;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter Product");
                }
            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPostOrUpdate.Text != null && txtUpdate.Text != null)
                {
                    int productId = Convert.ToInt32(txtUpdate.Text);
                    var product = JsonConvert.SerializeObject(txtPostOrUpdate.Text);
                    using (HttpResponseMessage response = await client.PutAsJsonAsync($"https://fakestoreapi.com/products/{productId}", product))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Above three lines can be replaced with new helper method below
                        // string responseBody = await client.GetStringAsync(uri);
                        txtResult.Text = responseBody;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter Product");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
