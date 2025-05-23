﻿using System;
using System.IO;
using System.IO.Pipes;

namespace CCS.SspNet.Tests
{
    /// <summary>
    /// Emulator for device-based tests.
    /// </summary>
    public class SspDeviceEmulator
    {
        private readonly NamedPipeServerStream server;
        private readonly string pipeName;

        public SspDeviceEmulator()
        {
            pipeName = Guid.NewGuid().ToString();
            server = new NamedPipeServerStream(pipeName, PipeDirection.InOut);
        }

        public Stream GetClientStream()
        {
            var client = new NamedPipeClientStream(".", pipeName, PipeDirection.InOut);
            client.Connect();
            return client;
        }
    }
}
