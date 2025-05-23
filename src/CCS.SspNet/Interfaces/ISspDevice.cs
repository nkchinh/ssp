﻿namespace CCS.SspNet.Interfaces
{
    public interface ISspDevice
    {
        bool Reset();

        void SetHostProtocolVersion();

        ulong GetSerialNumber();

        bool Sync();

        bool Disable();

        bool Enable();

        string GetFirmwareVersion();

        string GetDatasetVersion();

    }
}
