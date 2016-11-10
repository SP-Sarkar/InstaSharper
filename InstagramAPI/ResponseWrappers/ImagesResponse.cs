﻿using Newtonsoft.Json;

namespace InstagramAPI.ResponseWrappers
{
    public class ImagesResponse
    {
        [JsonProperty("low_resolution")]
        public ImageResponse LowResolution { get; set; }

        [JsonProperty("thumbnail")]
        public ImageResponse Thumbnail { get; set; }

        [JsonProperty("standard_resolution")]
        public ImageResponse StandartResolution { get; set; }
    }
}