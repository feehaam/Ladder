using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._17._Asynchronous_Programming
{
    internal class APICall
    {
        public static async Task Play()
        {
            HttpClient client = new HttpClient();

            // Make an asynchronous GET request to a URL
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

            // Read the response content as a string
            string content = await response.Content.ReadAsStringAsync();

            // Print the content to the console
            Console.WriteLine(content);
        }
    }
}
