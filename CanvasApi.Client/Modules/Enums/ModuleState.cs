﻿using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Modules.Enums
{
    [EnumAsString]
    public enum ModuleState
    {
        Locked,
        Unlocked,
        Started,
        Completed
    }
}
