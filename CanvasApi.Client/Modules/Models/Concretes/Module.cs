﻿using CanvasApi.Client.Modules.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Models.Concretes
{
    internal class Module : IModule
    {
        public long Id { get; set; }
        public IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
        public int? Position { get; set; }
        public string Name { get; set; }
        public DateTime? UnlockAt { get; set; }
        public bool? RequireSequentialProgression { get; set; }
        public IEnumerable<int> PrerequisiteModuleIds { get; set; }
        public int? ItemsCount { get; set; }
        public string ItemsUrl { get; set; }
        public IEnumerable<ModuleItem> Items { get; set; }
        IEnumerable<IModuleItem> IModule.Items => this.Items;
        public IEnumerable<ModuleState> State { get; set; }
        public DateTime? CompletedAt { get; set; }
        public bool? PublishFinalGrade { get; set; }
        public bool? Published { get; set; }
    }
}
