// Copyright (C) 2020 Google, LLC
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

namespace GoogleMobileAds.Common
{
    /// <summary>
    /// Information about an ad response.
    /// </summary>
    public interface IResponseInfoClient
    {
        /// <summary>
        /// Returns the mediation adapter class name of the ad network that loaded the ad.
        ///
        /// In the case of a mediated ad response, this is the name of the class that was
        /// responsible for performing the ad request and rendering the ad.
        ///
        /// For non-mediated responses, this value will be AdMobAdapter.
        /// Returns null if the ad failed to load.
        /// </summary>
        string MediationAdapterClassName { get; }

        /// <summary>
        /// Returns the response ID for the loaded ad.
        /// Can be used to look up ads in the Ad Review Center.
        /// Returns null if the ad failed to load.
        /// </summary>
        string ResponseId { get; }

        /// <summary>
        /// Returns a log friendly string of the ad request response.
        /// </summary>
        string Description { get; }
    }
}
