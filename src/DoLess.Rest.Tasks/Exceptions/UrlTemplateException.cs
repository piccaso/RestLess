﻿using System;

namespace DoLess.Rest.Tasks.Exceptions
{
    internal class StringTemplateException : Exception
    {
        public StringTemplateException(string message) :
            base(message)
        {
        }
    }
}