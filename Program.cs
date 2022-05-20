using System;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace Twitter_API_CSHARP
{
    internal class Program
    {
        static async Task Main(string[] args)
        {



            string filter1 = "javascript";
            string filter2 = "python";
            string filter3 = "c#";
            string filter4 = "java";

            var userCredentials = new TwitterCredentials("nN2yYQcMWlhsvaa8awvHo9PWF", "MDGDCAAhOaA3BSVMSz5HF2LElow39rdJlPJxdQO9z1E4pZ03b3", "1629692186-BimLBhF2MUQZ5ufDZ4G93ufBy7byABzijbZcNqQ", "hdY2py8hMvdSb7tU0a0wDxLmkKZrH7Gj24P7XL0SpAjTo");
            var userClient = new TwitterClient(userCredentials);

            // Create a simple stream containing only tweets with the keyword France

            var stream = userClient.Streams.CreateFilteredStream();
            stream.AddTrack(filter1);
            stream.AddTrack(filter2);
            stream.AddTrack(filter3);
            stream.AddTrack(filter4);

           

            


        }

    }
}
