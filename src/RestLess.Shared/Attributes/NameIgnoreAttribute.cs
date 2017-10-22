﻿using System;

namespace RestLess
{
    /// <summary>
    /// Indicates to not serialize/deserialize this property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NameIgnoreAttribute : Attribute
    {
    }
}
