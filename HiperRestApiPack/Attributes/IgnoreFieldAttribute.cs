﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HiperRestApiPack
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class IgnoreFieldAttribute : Attribute
    {
    }
}
