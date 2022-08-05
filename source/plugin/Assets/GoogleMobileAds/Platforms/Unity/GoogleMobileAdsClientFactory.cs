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
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using GoogleMobileAds.Unity;
using UnityEngine.Scripting;

namespace GoogleMobileAds
{
    [Preserve]
    public class GoogleMobileAdsClientFactory: IClientFactory
    {
        public IAppStateEventClient BuildAppStateEventClient()
        {
            return AppStateEventClient.Instance;
        }

        public IAppOpenAdClient BuildAppOpenAdClient()
        {
            return new AppOpenAdClient();
        }

        public IBannerAdClient BuildBannerClient()
        {
            return new BannerAdClient();
        }

        public IInterstitialAdClient BuildInterstitialClient()
        {
            return new InterstitialAdClient();
        }

        public IRewardedAdClient BuildRewardedAdClient()
        {
            return new RewardedAdClient();
        }

        public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient()
        {
            return new RewardedAdClient();
        }

        public IMobileAdsClient MobileAdsInstance()
        {
            return new MobileAdsClient();
        }
    }
}
