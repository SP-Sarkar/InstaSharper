﻿using Newtonsoft.Json;

namespace InstagramAPI.ResponseWrappers
{
    public class LikesResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("data")]
        public InstaUserResponse[] Users { get; set; }
    }
}