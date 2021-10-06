﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApp.ApiClients
{
    public class CategoryClient
    {
        private HttpClient httpClient;

        public CategoryClient()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:55286")
            };
        }

        public async Task<List<CategoryDTO>> ReceiveAllCategories()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<List<CategoryDTO>>("sample-data/categoryes.json");
                return response;
            }
            catch
            {
                throw new HttpRequestException();
            }
        }
    }
}
