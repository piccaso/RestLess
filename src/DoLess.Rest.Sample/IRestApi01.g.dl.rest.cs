﻿using System;
using System.Threading.Tasks;
using DoLess.Rest.Sample;

/*
* This file is generated by DoLess.Rest.
* All modifications will be erased at the next build.
* Please modify the dependent interface in order to change this file.
*/
namespace DoLess.Rest.Generated
{
    internal sealed class RestClientForIRestApi01 : RestClientBase, IRestApi01
    {
        public Task<string> GetBook(string id)
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("/v1/app/books/{id}")
                              .WithParameter("id", id)
                              .ReadAsStringAsync();
        }

        public Task<string> GetBook2(string id)
        {
            return RestRequest.Get(this)
                              .WithUriTemplate("/v1/app/books/{id}")
                              .WithParameter("id", id)
                              .ReadAsStringAsync();
        }
    }
}