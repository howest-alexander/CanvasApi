using Canvas.Api.Client.SisImports.Models;
using CanvasApi.Client.Users.Models.Concrete;
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CanvasApi.Client.SisImports.Models.Concretes {
    public class SisImport : ISisImport {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("ended_at")]
        public DateTime? EndedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("workflow_state")]
        public string WorkflowState { get; set; }

        [JsonProperty("data")]
        public SisImportData Data { get; set; }

        [JsonProperty("statistics")]
        public SisImportStatistics Statistics { get; set; }

        [JsonProperty("progress")]
        public long? Progress { get; set; }

        [JsonProperty("user")]
        [CanBeNull]
        public User User { get; set; }

        [JsonProperty("processing_warnings")]
        [CanBeNull]
        public IEnumerable<IEnumerable<string>> ProcessingWarnings { get; set; }

        [JsonProperty("processing_errors")]
        [CanBeNull]
        public IEnumerable<IEnumerable<string>> ProcessingErrors { get; set; }

        [JsonProperty("batch_mode")]
        public bool? BatchMode { get; set; }

        [JsonProperty("batch_mode_term_id")]
        public long? BatchModeTermId { get; set; }

        [JsonProperty("multi_term_batch_mode")]
        public bool? MultiTermBatchMode { get; set; }

        [JsonProperty("skip_deletes")]
        public bool? SkipDeletes { get; set; }

        [JsonProperty("override_sis_stickiness")]
        public bool? OverrideSisStickiness { get; set; }

        [JsonProperty("add_sis_stickiness")]
        public bool? AddSisStickiness { get; set; }

        [JsonProperty("clear_sis_stickiness")]
        public bool? ClearSisStickiness { get; set; }

        [JsonProperty("diffing_data_set_identifier")]
        public string DiffingDataSetIdentifier { get; set; }

        [JsonProperty("diffed_against_import_id")]
        public ulong? DiffedAgainstImportId { get; set; }

        [JsonProperty("diffing_drop_status")]
        public string? DiffingDropStatus { get; set; }

        [JsonProperty("diffing_threshold_exceeded")]
        public bool DiffingThresholdExceeded { get; set; }

        [JsonProperty("change_threshold")]
        public ulong ChangeThreshold { get; set; }

        [JsonProperty("diffed_csv_attachments")]
        public IEnumerable<Attachment> DiffedCsvAttachment { get; set; }

        [JsonProperty("errors_attachment")]
        public Attachment ErrorsAttachment { get; set; }

        [JsonProperty("csv_attachments")]
        public IEnumerable<Attachment> CsvAttachments { get; set; }
    }
}