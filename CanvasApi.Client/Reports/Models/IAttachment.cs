﻿namespace CanvasApi.Client.Reports.Models {

    internal interface IAttachment {
        ulong Id { get; set; }
        int Progress { get; set; }
        public string ContentType { get; set; }
        public string Url { get; set; }
        public string Filename { get; set; }
        public string DisplayName { get; set; }
    }
}