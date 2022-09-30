// Copyright (C) 2022 Google LLC.
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

namespace GoogleMobileAds.Ump.Common
{
    public interface IConsentFormClient
    {
        /// <summary>
        /// Loads a consent form.
        /// </summary>
        /// <param name="onLoad">Called when the consent form is loaded. </param>
        /// <param name="OnError">Called when the consent form fails to load. </param>
        void LoadConsentForm(Action onLoad, Action<FormError> onError);

        /// <summary>
        /// Shows the consent form.
        /// </summary>
        /// <param name="onDismiss">Called when the consent form is dismissed. </param>
        /// <param name="OnError">Called when the consent form fails to show. </param>
        void Show(Action<FormError> onDismiss);
    }
}
