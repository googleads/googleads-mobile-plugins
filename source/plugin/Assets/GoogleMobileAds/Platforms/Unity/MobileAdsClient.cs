// Copyright (C) 2015 Google, Inc.
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
using System.Reflection;
using GoogleMobileAds.Unity;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Unity
{
    public class MobileAdsClient : BaseAdClient, IMobileAdsClient
    {
        public MobileAdsClient()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        // Disable warnings for unused dummy ad events.
#pragma warning disable 67

        public event EventHandler<EventArgs> OnAdLoaded;

        public event EventHandler<LoadAdErrorClientEventArgs> OnAdFailedToLoad;

        public event EventHandler<EventArgs> OnAdOpening;

        public event EventHandler<EventArgs> OnAdStarted;

        public event EventHandler<EventArgs> OnAdClosed;

        public event EventHandler<Reward> OnAdRewarded;

        public event EventHandler<EventArgs> OnAdLeavingApplication;

        public event EventHandler<EventArgs> OnAdCompleted;

        public event EventHandler<AdValueEventArgs> OnPaidEvent;

        public event EventHandler<AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;

        public event EventHandler<EventArgs> OnAdDidPresentFullScreenContent;

        public event EventHandler<EventArgs> OnAdDidDismissFullScreenContent;

        public event EventHandler<EventArgs> OnAdDidRecordImpression;

        private ButtonBehaviour buttonBehaviour;

        private void AddClickBehavior(GameObject dummyAd)
        {
            Image[] images = dummyAd.GetComponentsInChildren<Image>();
            Image adInspectorImage = images[1];

            Button[] innerButtons = adInspectorImage.GetComponentsInChildren<Button>();

            innerButtons[1].onClick.AddListener(() =>
            {
                DestroyAdInspector();
                AdBehaviour.ResumeGame();
            });
        }

        private void CreateButtonBehavior()
        {
            buttonBehaviour = base.dummyAd.AddComponent<ButtonBehaviour>();
        }

#pragma warning restore 67

        public string UserId
        {
            get
            {
                Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
                return "UserId";
            }

            set
            {
                Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            }
        }

        public void Initialize(string appId)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void Initialize(Action<IInitializationStatusClient> initCompleteAction)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            var initStatusClient = new InitializationStatusClient();
            initCompleteAction(initStatusClient);
        }

        public void DisableMediationInitialization()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetApplicationMuted(bool muted)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetRequestConfiguration(RequestConfiguration requestConfiguration)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public RequestConfiguration GetRequestConfiguration()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return null;

        }

        public void SetApplicationVolume(float volume)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetiOSAppPauseOnBackground(bool pause)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public float GetDeviceScale()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return 0;
        }

        public int GetDeviceSafeWidth()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return 0;
        }

        public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void CreateBannerView(string adUnitId, AdSize adSize, int positionX, int positionY)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void LoadAd(AdRequest request)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void ShowBannerView()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void HideBannerView()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void DestroyBannerView()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public float GetHeightInPixels()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return 0;
        }

        public float GetWidthInPixels()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return 0;
        }

        public void SetPosition(AdPosition adPosition)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetPosition(int x, int y)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void CreateInterstitialAd()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void Show()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void DestroyInterstitial()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetUserId(string userId)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void LoadAd(string adUnitId, AdRequest request)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void Load(AdRequest request)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetAdSize(AdSize adSize)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public string MediationAdapterClassName()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return null;
        }

        public IResponseInfoClient GetResponseInfoClient()
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            return null;
        }

        public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions)
        {
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
        }

        public void OpenAdInspector(Action<AdInspectorErrorClientEventArgs> onAdInspectorClosed)
        {
            LoadAndSetPrefabAd("PlaceholderAds/AdInspector/768x1024");
            if (prefabAd != null)
            {
                dummyAd = AdBehaviour.ShowAd(prefabAd, new Vector3(0, 0, 1));
                CreateButtonBehavior();
                AddClickBehavior(dummyAd);
                AdBehaviour.PauseGame();
                if (OnAdDidPresentFullScreenContent != null)
                {
                  OnAdDidPresentFullScreenContent.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                Debug.Log("No Ad Loaded");
            }
            Debug.Log("Placeholder " + MethodBase.GetCurrentMethod().Name);
            onAdInspectorClosed(null);
        }

        // Destroys Ad Inspector.
        public void DestroyAdInspector()
        {
            AdBehaviour.DestroyAd(dummyAd);
            prefabAd = null;
        }
    }
}
