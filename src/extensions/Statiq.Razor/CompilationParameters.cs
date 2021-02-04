﻿using System;
using Statiq.Common;

namespace Statiq.Razor
{
    internal struct CompilationParameters
    {
        public NamespaceCollection Namespaces { get; set; }
        public Type BasePageType { get; set; }
        public bool IsDocumentModel { get; set; }
    }
}