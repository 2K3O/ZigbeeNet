﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZigBeeNet.ZCL.Clusters.ColorControl
{
    public enum ColorCapabilities
    {
        HUE_AND_SATURATION = 0x0001,
        ENHANCED_HUE = 0x0002,
        COLOR_LOOP = 0x0004,
        XY_ATTRIBUTE = 0x0008,
        COLOR_TEMPERATURE = 0x0010
    }
}
