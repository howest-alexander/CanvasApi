﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models
{
    public interface IMasteryPath
    {
        IEnumerable<JObject> AssignmentSets { get; }
        bool? AwaitingChoice { get; }
        string ChooseUrl { get; }
        bool? Locked { get; }
        bool? ModulesTabDisabled { get; }
        string ModulesUrl { get; }
        long? SelectedSetId { get; }
        bool? StillProcessing { get; }
    }
}