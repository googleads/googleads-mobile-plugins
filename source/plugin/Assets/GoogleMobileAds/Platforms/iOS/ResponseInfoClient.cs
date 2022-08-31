#if UNITY_IOS
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

using System;
using System.Collections.Generic;
using UnityEngine;

using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System.Collections.Generic;

namespace GoogleMobileAds.iOS
{
    [System.Obsolete("Use JsonResponseInfoClient")]
    internal class ResponseInfoClient : IResponseInfoClient
    {
        private IntPtr adFormat;
        private IntPtr iosResponseInfo;

        public ResponseInfoClient(ResponseInfoClientType type, IntPtr ptr)
        {
            if(type == ResponseInfoClientType.AdLoaded)
            {
                this.adFormat = adFormat;
                iosResponseInfo = Externs.GADUGetResponseInfo(ptr);
            }
            else if(type == ResponseInfoClientType.AdError)
            {
                iosResponseInfo = Externs.GADUGetAdErrorResponseInfo(ptr);
            }
        }

        public ResponseInfoClient(IntPtr adFormat, IntPtr iOSClient)
        {
            this.adFormat = adFormat;
            iosResponseInfo = iOSClient;
        }

        public IAdapterResponseInfoClient GetLoadedAdapterResponseInfo()
        {
            return null;
        }

        public IAdapterResponseInfoClient[] GetAdapterResponses()
        {
            return null;
        }

        public Dictionary<string,string> GetResponseExtras()
        {
            return null;
        }

        public string GetMediationAdapterClassName()
        {
            if (iosResponseInfo != IntPtr.Zero)
            {
                return Externs.GADUResponseInfoMediationAdapterClassName(iosResponseInfo);
            }
            return null;
        }

        public string GetResponseId()
        {
            if (iosResponseInfo != IntPtr.Zero)
            {
                return Externs.GADUResponseInfoResponseId(iosResponseInfo);
            }
            return null;
        }

        public override string ToString()
        {
            return Externs.GADUGetResponseInfoDescription(iosResponseInfo);
        }
    }
}
#endif
