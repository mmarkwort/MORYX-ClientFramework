﻿using System;
using System.Collections;
using Caliburn.Micro;
using Marvin.ClientFramework.Shell;

namespace Marvin.ClientFramework.Kernel
{
    internal class FallbackShellViewModel : Screen, IModuleShell
    {
        public const string ShellName = "FallbackShell";

        public string RunMode { get; set; }

        public string ConfiguredShell { get; set; }

        public void Initialize()
        {
        }

        public void ActivateItem(object item)
        {
        }

        public void DeactivateItem(object item, bool close)
        {
        }

        public IEnumerable GetChildren()
        {
            return new ArrayList();
        }

#pragma warning disable 67
        public event EventHandler<ActivationProcessedEventArgs> ActivationProcessed;
#pragma warning restore 67
    }
}
