// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Reflection;
using System.Threading;

namespace Moryx.ClientFramework.Kernel.Tests
{
    internal class FileLoaderGoodMock : IAssemblyFileLoader
    {
        public void Initialize(Uri uri, ProxyConfig proxyConfig)
        {

        }

        public void Dispose()
        {

        }

        public void DownloadFile()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                AssemblyDownloaded(this, Assembly.GetExecutingAssembly());
            });
        }

        public event EventHandler<Assembly> AssemblyDownloaded;


        public event EventHandler<FailedDownload> AssemblyDownloadFailed;
        private void RaiseAssemblyDownloadFailed(FailedDownload e)
        {
            var handler = AssemblyDownloadFailed;
            if (handler != null) handler(this, e);
        }
    }
}
