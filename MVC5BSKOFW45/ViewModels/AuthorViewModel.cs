﻿using Newtonsoft.Json;

namespace MVC5BSKOFW45.ViewModels
{
    public class AuthorViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "biography")]
        public string Biography { get; set; }
    }
}
