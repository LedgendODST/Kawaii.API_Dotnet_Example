    //Our Handle Request gets Created.
    using System;
    using System.Net.Http;
    using System.Net.Http.Json;
    using KawaiiAPI_Request_Example;

    //Make the request and make the actually call.
    using (var client = new HttpClient())
    {
        try
        {
            var kawaii_API_token = "";
            var response = await client.GetFromJsonAsync<KawaiiRedApi>(
                string.Format("http://kawaii.red/api/gif/{0}/token={1}&filter={2}/", "kiss",
                    kawaii_API_token, new int[] { })
            );

            if (response is not null)
            {
                Console.WriteLine($"Image is | {response.Response}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }