﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Identity.Client;
#if (NETFRAMEWORK)
using Microsoft.Identity.Client.Desktop;
#endif

namespace Azure.Identity.BrokeredAuthentication
{
    /// <summary>
    /// Options to configure the <see cref="InteractiveBrowserCredential"/> to use the system authentication broker in lieu of the system browser if available.
    /// </summary>
    public class InteractiveBrowserCredentialBrokerOptions : InteractiveBrowserCredentialOptions
    {
        /// <summary>
        /// Creates a new instance of <see cref="InteractiveBrowserCredentialBrokerOptions"/>.
        /// </summary>
        public InteractiveBrowserCredentialBrokerOptions()
        {
            this.BeforeBuildClient = AddBroker;
        }

        private void AddBroker(PublicClientApplicationBuilder builder)
        {
#if (NETFRAMEWORK)
            builder.WithWindowsBroker();
#else
            builder.WithBroker();
#endif
        }
    }
}
