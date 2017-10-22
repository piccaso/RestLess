﻿using System.Net.Http;
using System.Threading.Tasks;
using RestLess.IntegrationTests.Interfaces;


// This file is generated by RestLess.
// All modifications will be erased at the next build.
// Please modify the dependent interface in order to change this file.
namespace RestLess.Generated
{
    internal sealed class RestClientForIApi08 : RestClientBase, IApi08
    {
        public Task<HttpResponseMessage> Get01Async(string apiKey)
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts{?apiKey}")
                              .WithUriVariable("apiKey", apiKey)
                              .ReadAsHttpResponseMessageAsync();
        }

        public Task<HttpResponseMessage> Get02Async(string apikey)
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts{?apiKey}")
                              .WithUriVariable("apikey", apikey)
                              .ReadAsHttpResponseMessageAsync();
        }

        public Task<HttpResponseMessage> Get03Async(string arg01)
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts{?apiKey}")
                              .WithUriVariable("apiKey", arg01)
                              .ReadAsHttpResponseMessageAsync();
        }

        public Task<HttpResponseMessage> Get04Async(string arg01)
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts{?apiKey}")
                              .WithUriVariable("apikey", arg01)
                              .ReadAsHttpResponseMessageAsync();
        }

        public Task<HttpResponseMessage> Get05Async()
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts{?customKey}")
                              .ReadAsHttpResponseMessageAsync();
        }

        public Task<HttpResponseMessage> Get06Async()
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts{?customkey}")
                              .ReadAsHttpResponseMessageAsync();
        }
    }
}