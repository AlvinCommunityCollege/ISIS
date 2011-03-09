﻿using System.ComponentModel;

namespace ISIS.Schedule
{

    public enum CourseTypes
    {
        [Description("General Academic")]
        ACAD,

        [Description("Regular Technical")]
        TECH,

        [Description("Technical in WECM")]
        WECM,

        [Description("Non-funded")]
        NF,

        [Description("Non-reported Lab Course")]
        NLAB,

        [Description("Non-funded developmental")]
        NFDEV,

        [Description("Non-funded ROTC")]
        NROTC,

        [Description("Exempt from Rider 50")]
        R50
    }
}