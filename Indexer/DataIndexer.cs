using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks; 
using Newtonsoft.Json.Linq;

namespace PMGIndexer
{
    public class DataIndexer : IDataIndexer
    {
        private readonly HttpClient _httpClient;

        public DataIndexer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task IndexEndpoints(List<string> endpoints)
        {
            // Iterate through the list of endpoints
            foreach (string endpoint in endpoints)
            {
                // Index the endpoint recursively
                await IndexEndpoint(endpoint);
            }
        }

        private async Task IndexEndpoint(string url)
        {
            // Retrieve data from the endpoint
            var data = await GetDataFromAPI(url);

            // Check if there is a next page of results
            string nextUrl = (string)data["next"];
            if (!string.IsNullOrEmpty(nextUrl))
            {
                // Save the data to a file
                string fileName = $"{url.Replace('/', '_')}.json";
                File.WriteAllText(fileName, data.ToString());

                // Print a message to the console
                Console.WriteLine($"Data from endpoint {url} saved to file {fileName}");

                // Index the next page of results
                await IndexEndpoint(nextUrl);
            }
        }

        private async Task<JObject> GetDataFromAPI(string url)
        {
            // Make a GET request to the API
            var response = await _httpClient.GetAsync(url);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();

            // Read the response as a JSON object
            var data = await response.Content.ReadAsAsync<JObject>();

            // Return the data
            return data;
        }
    }
}