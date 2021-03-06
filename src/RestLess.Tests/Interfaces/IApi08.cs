﻿using System.Net.Http;
using System.Threading.Tasks;
using RestLess.Tests.Entities;

namespace RestLess.Tests.Interfaces
{
    public interface IApi08
    {
        [Get("api/posts{?apiKey}")]
        Task<HttpResponseMessage> Get01Async(string apiKey);

        [Get("api/posts{?apiKey}")]
        Task<HttpResponseMessage> Get02Async(string apikey);

        [Get("api/posts{?apiKey}")]
        Task<HttpResponseMessage> Get03Async([Name("apiKey")] string arg01);

        [Get("api/posts{?apiKey}")]
        Task<HttpResponseMessage> Get04Async([Name("apikey")] string arg01);

        [Get("api/posts{?customKey}")]
        Task<HttpResponseMessage> Get05Async();

        [Get("api/posts{?customkey}")]
        Task<HttpResponseMessage> Get06Async();

        [Get("api/posts{?apiKey}")]
        Task<HttpResponseMessage> Get07Async(Person apiKey);
    }
}
