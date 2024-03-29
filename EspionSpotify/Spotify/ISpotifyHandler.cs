﻿using System;
using System.Threading.Tasks;
using System.Timers;
using EspionSpotify.Events;
using EspionSpotify.Models;

namespace EspionSpotify.Spotify
{
    public interface ISpotifyHandler
    {
        Timer EventTimer { get; }
        Timer SongTimer { get; }
        ISpotifyProcess SpotifyProcess { get; }
        ISpotifyStatus SpotifyLatestStatus { get; }
        bool ListenForEvents { get; set; }

        Track Track { get; set; }

        event EventHandler<TrackChangeEventArgs> OnTrackChange;
        event EventHandler<PlayStateEventArgs> OnPlayStateChange;
        event EventHandler<TrackTimeChangeEventArgs> OnTrackTimeChange;

        Task<Track> GetTrack();
        Task TriggerEvents();

        void Dispose();
    }
}