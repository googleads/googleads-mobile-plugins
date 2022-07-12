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
using UnityEngine;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
    /// <summary>
    /// Error information about why an ad load operation failed.
    /// </summary>
    public class AdError
    {
        /// <summary>
        /// The error code.
        /// See https://support.google.com/admob/thread/3494603/admob-error-codes-logs
        /// for explanations of error codes.
        /// </summary>
        public int Code { get { return _client.Code; } }

        /// <summary>
        /// The domain from which the error came.
        /// </summary>
        /// <returns>Ad Error Domain. </returns>
        public string Domain { get { return _client.Domain; } }

        /// <summary>
        /// The error message.
        /// See https://support.google.com/admob/answer/9905175
        /// for explanations of common errors.
        /// <summary>
        public string Message { get { return _client.Message; } }

        /// <summary>
        /// The underlying error cause if exists.
        /// <summary>
        public AdError Cause
        {
            get { return _client.Cause == null ? null : new AdError(_client.Cause); }
        }

        /// <summary>
        /// Returns a log friendly string of the ad error.
        /// </summary>
        public string Description { get { return _client.Description; } }

        private IAdErrorClient _client;

        internal AdError(IAdErrorClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        /// <returns>Ad Error Code. </returns>
        [Obsolete("Use Code")]
        public int GetCode()
        {
            return Code;
        }

        /// <summary>
        /// Gets the domain from which the error came.
        /// </summary>
        /// <returns>Ad Error Domain. </returns>
        [Obsolete("Use Domain")]
        public string GetDomain()
        {
            return Domain;
        }

        /// <summary>
        /// Gets the error message.
        /// See https://support.google.com/admob/answer/9905175
        /// for explanations of common errors.
        /// <summary>
        /// <returns>Ad Error Message. </returns>
        [Obsolete("Use Message")]
        public string GetMessage()
        {
            return Message;
        }

        ///<summary>
        /// Gets the underlying error cause if exists
        /// <summary>
        /// <returns>Ad Error Cause. </returns>
        [Obsolete("Use Cause")]
        public AdError GetCause()
        {
            return Cause;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
