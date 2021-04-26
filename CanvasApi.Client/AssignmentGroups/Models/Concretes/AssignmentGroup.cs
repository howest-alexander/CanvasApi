﻿using System.Collections.Generic;
using CanvasApi.Client.Assignments.Models;
using CanvasApi.Client.Assignments.Models.Concretes;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.AssignmentGroups.Models.Concrete
{
    internal class AssignmentGroup : IAssignmentGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Position { get; set; }
        public decimal? GroupWeight { get; set; }
        public string SisSourceId { get; set; }
        public JObject IntegrationData { get; set; }

        public IEnumerable<Assignment> Assignments { get; set; }
        IEnumerable<IAssignment> IAssignmentGroup.Assignments => this.Assignments;

        public GradingRules Rules { get; set; }
        IGradingRules IAssignmentGroup.Rules => this.Rules;
    }
}
