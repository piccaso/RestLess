﻿using System.Net.Http;
using System.Threading.Tasks;
using RestLess.IntegrationTests.Interfaces;


// This file is generated by RestLess.
// All modifications will be erased at the next build.
// Please modify the dependent interface in order to change this file.
namespace RestLess.Generated
{
    internal sealed class RestClientForIApi02WithoutUriTemplatePrefix : RestClientBase, IApi02WithoutUriTemplatePrefix
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("api/posts")
                              .ReadAsHttpResponseMessageAsync();
        }
    }

    internal sealed class RestClientForIApi02WithUriTemplatePrefix01 : RestClientBase, IApi02WithUriTemplatePrefix01
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return RestRequest.Get(this)
                              .WithUriTemplatePrefix("api/")
                              .WithUriTemplate("posts")
                              .ReadAsHttpResponseMessageAsync();
        }
    }

    internal sealed class RestClientForIApi02WithUriTemplatePrefix02 : RestClientBase, IApi02WithUriTemplatePrefix02
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return RestRequest.Get(this)
                              .WithUriTemplatePrefix("/api/")
                              .WithUriTemplate("posts")
                              .ReadAsHttpResponseMessageAsync();
        }
    }

    internal sealed class RestClientForIApi02WithUriTemplatePrefixAndSuffix : RestClientBase, IApi02WithUriTemplatePrefixAndSuffix
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return RestRequest.Get(this)
                              .WithUriTemplatePrefix("/api/")
                              .WithUriTemplateSuffix("/suffix")
                              .WithUriTemplate("posts")
                              .ReadAsHttpResponseMessageAsync();
        }
    }

    internal sealed class RestClientForIApi02WithUriTemplateSuffix01 : RestClientBase, IApi02WithUriTemplateSuffix01
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return RestRequest.Get(this)
                              .WithUriTemplateSuffix("{?api_key}")
                              .WithUriTemplate("api/posts")
                              .ReadAsHttpResponseMessageAsync();
        }
    }

    internal sealed class RestClientForIApi02WithUriTemplateSuffix02 : RestClientBase, IApi02WithUriTemplateSuffix02
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            return RestRequest.Get(this)
                              .WithUriTemplateSuffix("{?notFound}")
                              .WithUriTemplate("api/posts")
                              .ReadAsHttpResponseMessageAsync();
        }
    }
}