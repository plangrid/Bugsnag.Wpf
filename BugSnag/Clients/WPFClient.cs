﻿using System;
using System.Linq;
using System.Windows;

#if !NET35
// Tasks for Async versions of Notify()
using System.Threading.Tasks;
#endif

namespace Bugsnag.Clients
{
    public static class WPFClient
    {
        public static Configuration Config;
        private static BaseClient Client;

        static WPFClient()
        {
            Client = new BaseClient(ConfigurationStorage.ConfigSection.Settings);
            Config = Client.Config;
        }

        public static void Start()
        {

        }

        public static void SendStoredReports()
        {
            Client.SendStoredReports();
        }

        public static void Notify(Exception error)
        {
            Client.Notify(error);
        }

        public static void Notify(Exception error, Metadata metadata)
        {
            Client.Notify(error, metadata);
        }

        public static void Notify(Exception error, Severity severity)
        {
            Client.Notify(error, severity);
        }

        public static void Notify(Exception error, Severity severity, Metadata metadata)
        {
            Client.Notify(error, severity, metadata);
        }

#if !NET35
        public static Task NotifyAsync(Exception error)
        {
            return Client.NotifyAsync(error);
        }

        public static Task NotifyAsync(Exception error, Metadata metadata)
        {
            return Client.NotifyAsync(error, metadata);
        }

        public static Task NotifyAsync(Exception error, Severity severity)
        {
            return Client.NotifyAsync(error, severity);
        }

        public static Task NotifyAsync(Exception error, Severity severity, Metadata metadata)
        {
            return Client.NotifyAsync(error, severity, metadata);
        }
#endif
    }
}
