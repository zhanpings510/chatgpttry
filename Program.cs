using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft;


/// <summary>
/// This is first code by using ChatGPT API to get the result with a Model called "Davinci"
/// March 6, 2023
/// </summary>

class Program
{
    static async Task Main(string[] args)
    {
        var client = new HttpClient();
        var url = "https://api.openai.com/v1/completions";

        // Create the request payload as a string
        var payload = @"{
            ""model"": ""text-davinci-003"",
            ""prompt"": ""Say this is a test"",
            ""max_tokens"": 7,
            ""temperature"": 0
        }";

        // Create the HTTP request message
        var request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");

        // Set the Authorization header
        request.Headers.Add("Authorization", "Bearer ag-XyAUmHf7NavistarVymQvp8ssVT3BlbkFJ8AanLW3Wuz8E7VIlTuyD");

        // Send the request and get the response
        var response = await client.SendAsync(request);
        var responseString = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseString);
        Console.ReadLine(); 
    }
}


//This code uses the HttpClient class to create a POST request to the specified URL with the JSON payload. It sets the Content-Type and Authorization headers to match the Curl command. Finally, it sends the request and retrieves the response as a string.
//Note that you'll need to replace the bearer token in the Authorization header with your own token, as the one in the example is just a placeholder.





