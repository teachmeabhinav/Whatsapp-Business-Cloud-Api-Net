﻿using Newtonsoft.Json;

namespace WhatsappBusiness.CloudApi.Webhook
{
    public class ImageMessageReceived
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("entry")]
        public List<ImageMessageEntry> Entry { get; set; }
    }

    public class ImageMessageEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changes")]
        public List<ImageMessageChange> Changes { get; set; }
    }

    public class ImageMessageChange
    {
        [JsonProperty("value")]
        public ImageMessageValue Value { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }
    }

    public class ImageMessageValue
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        [JsonProperty("metadata")]
        public ImageMessageMetadata Metadata { get; set; }

        [JsonProperty("contacts")]
        public List<ImageMessageContact> Contacts { get; set; }

        [JsonProperty("messages")]
        public List<ImageMessage> Messages { get; set; }
    }

    public class ImageMessageContact
    {
        [JsonProperty("profile")]
        public ImageMessageProfile Profile { get; set; }

        [JsonProperty("wa_id")]
        public string WaId { get; set; }
    }

    public class ImageMessageProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ImageMessage
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }

    public class Image
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ImageMessageMetadata
    {
        [JsonProperty("display_phone_number")]
        public string DisplayPhoneNumber { get; set; }

        [JsonProperty("phone_number_id")]
        public string PhoneNumberId { get; set; }
    }
}