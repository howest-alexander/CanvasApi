﻿using Newtonsoft.Json;
using System;

namespace CanvasApi.Client.SisImports.Models.Concretes {
    public class Attachment : IAttachment {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("folder_id")]
        public ulong? FolderId { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("filename")]
        public string Filename { get; set; }
        [JsonProperty("upload_status")]
        public string UploadStatus { get; set; }
        [JsonProperty("content-type")]
        public string ContentType { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("size")]
        public ulong Size { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
       // [JsonProperty("unlock_at")]
        //public DateTime? UnlockAt { get; set; }
        //[JsonProperty("locked")]
        //public bool Locked { get; set; }
        //[JsonProperty("hidden")]
        //public bool Hidden { get; set; }
        //[JsonProperty("lock_at")]
        //public DateTime? LockAt { get; set; }
        //[JsonProperty("hidden_for_user")]
        //public bool HiddenForUser { get; set; }
        //[JsonProperty("thumbnail_url")]
        //public string ThumbnailUrl { get; set; }
        [JsonProperty("modified_at")]
        public DateTime? ModifiedAt { get; set; }
        //[JsonProperty("mime_class")]
        //public string MimeClass { get; set; }
        //[JsonProperty("media_entry_id")]
        //public ulong? MediaEntryId { get; set; }
        //[JsonProperty("locked_for_user")]
        //public bool LockedForUser { get; set; }
    }
}