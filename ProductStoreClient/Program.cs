using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ProductStoreClient
{
    class Program
    {
        static void Main()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50797/");

            var gizmo = new Product()  { Name = "Gizmo", Price = 100, category = "widget" };
            Uri gizmoUri = null;
            HttpResponseMessage response = client.PostAsJsonAsync("api/products", gizmo).Result;
            if (response.IsSuccessStatusCode)
            {
                gizmoUri = response.Headers.Location;
                Console.WriteLine(gizmoUri);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("------------------------");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            response = client.GetAsync("api/products/2").Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                Console.WriteLine("{0}\t{1}:\t{2}", product.Name, product.Price, product.category);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("---------------------------------");
            response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach (var p in products)
                {
                    Console.WriteLine("{0}\t{1};\t{2}", p.Name, p.Price, p.category);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("------------------------------------");
            gizmo.Price = 99.9;
            response = client.PutAsJsonAsync(gizmoUri.PathAndQuery, gizmo).Result;
            Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter Product ID to Update: ");
            int id = int.Parse(Console.ReadLine());
            response = client.GetAsync("api/products/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                product.Price = 110;
                response = client.PutAsJsonAsync("api/products/" + id, product).Result;
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("---------------------------------");
            response = client.DeleteAsync("api/Products/6").Result;
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            Console.WriteLine("*********************************");
            response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach(var p in products )
                {
                    Console.WriteLine("{0}\t{1};\t{2}", p.Name, p.Price, p.category);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})",(int)response.StatusCode, response.ReasonPhrase);
            }
        }
       
    }

}   
