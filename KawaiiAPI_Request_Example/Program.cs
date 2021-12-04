//Our Handle Request gets Created.
    using System;
    using System.Net.Http;

    //Your Own kawaii API Token.
    var kawaii_API_token = "";
    
    //Make the request and make the actually call.
    using (var client = new HttpClient())
    {
        var response = await client.GetAsync(
            string.Format("http://kawaii.red/api/gif/{0}/token={1}&type=txt/", "kiss", kawaii_API_token, new int[] { })
        );

        if (response.IsSuccessStatusCode && await response.Content.ReadAsStringAsync() is { } parsed)
        {
            Console.WriteLine($"Website is | {parsed}");
        }
    }