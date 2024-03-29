﻿using System.Threading;
using System.Threading.Tasks;
using EspionSpotify.Models;

namespace EspionSpotify
{
    public interface IRecorder
    {
        int CountSeconds { get; set; }
        Track Track { get; }
        bool Running { get; set; }

        Task Run(CancellationTokenSource token);

        void Dispose();
    }
}