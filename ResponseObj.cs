using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("language")]
    public string language { get; set; }

    [JsonProperty("confidence")]
    public double confidence { get; set; }

    [JsonProperty("code")]
    public string code { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data[] data { get; set; }

}

}
