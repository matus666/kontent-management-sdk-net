﻿using Newtonsoft.Json;

namespace KenticoCloud.ContentManagement.Models.Assets
{
    public class AssetDescriptionsModel
    {
        [JsonProperty("language", Required = Required.Always)]
        public ManageApiReference Language { get; set; }

        [JsonProperty("description", Required = Required.AllowNull)]
        public string Description { get; set; }
    }
}