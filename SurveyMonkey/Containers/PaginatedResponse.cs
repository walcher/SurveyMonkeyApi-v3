using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public class PaginatedResponse<T> where T : IPageableContainer
    {
        public int PerPage { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public Links Links { get; set; }
        public List<T> Data { get; set; }
    }

    [JsonConverter(typeof(TolerantJsonConverter))]
    public class Links
    {
        public string Self { get; set; }
        public string Prev { get; set; }
        public string Next { get; set; }
        public string Last { get; set; }
        public string First { get; set; }
    }
}
