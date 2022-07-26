// Copyright (C) 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
    /// <summary>
    /// Notifies changes in app foreground/background.
    /// Subscribe to AppStateChanged to get notified of changes in app state.
    /// </summary>
    public class AppStateEventNotifier
    {
        /// <summary>
        /// Raised when the app enters the background/foreground.
        /// </summary>
        public static event Action<AppState> AppStateChanged
        {
            add
            {
                _client.AppStateChanged += value;
            }
            remove
            {
                _client.AppStateChanged -= value;
            }
        }

        private static IAppStateEventClient _client;

        static AppStateEventNotifier()
        {
            _client = MobileAds.GetClientFactory().BuildAppStateEventClient();
        }
    }
}
