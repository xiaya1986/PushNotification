// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.Phone.Notification;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Linq;
using System.Net;

namespace WPPushNotification.TestClient
{
    /// <summary>
    /// Handles the various aspects of managing push notifications for the application.
    /// </summary>
    public class PushHandler
    {
        private HttpNotificationChannel httpChannel;
        const string channelName = "WeatherUpdatesChannel";

        private bool connectedToMSPN;
        private bool connectedToServer;
        private bool notificationsBound;

        /// <summary>
        /// Contains information about the locations displayed by the application.
        /// </summary>
        public Dictionary<string, LocationInformation> Locations { get; private set; }

        /// <summary>
        /// A dispatcher used to interact with the UI.
        /// </summary>
        public Dispatcher Dispatcher { get; private set; }

        /// <summary>
        /// Push service related status information.
        /// </summary>
        public Status PushStatus { get; private set; }

        /// <summary>
        /// Whether or not the handler has fully established a connection to both the MSPN and the application server.
        /// </summary>
        public bool ConnectionEstablished
        {
            get
            {
                return connectedToMSPN && connectedToServer && notificationsBound;
            }
        }
	}
}
