﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class SiteSlotConfigWebCollectionTests : AppServiceTestBase
    {
        public SiteSlotConfigWebCollectionTests(bool isAsync)
           : base(isAsync)
        {
        }

        private async Task<WebSiteSlotConfig> GetSiteSlotConfigWebCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var SiteName = Recording.GenerateAssetName("testSite");
            var SiteSlotName = Recording.GenerateAssetName("testSiteSlot");
            var SiteInput = ResourceDataHelper.GetBasicSiteData(DefaultLocation);
            var lro = await resourceGroup.GetWebSites().CreateOrUpdateAsync(WaitUntil.Completed, SiteName, SiteInput);
            var Site = lro.Value;
            var lroSiteSlot = await Site.GetSiteSlots().CreateOrUpdateAsync(WaitUntil.Completed, SiteSlotName, SiteInput);
            var siteSlot = lroSiteSlot.Value;
            return siteSlot.GetWebSiteSlotConfig();
        }

        [TestCase]
        [RecordedTest]
        [Ignore("Cannot complete the operation because the site will exceed the number of slots allowed for the 'Free' SKU")]
        public async Task CreateOrUpdate()
        {
            var container = await GetSiteSlotConfigWebCollectionAsync();
            var name = Recording.GenerateAssetName("testSiteSlotConfigWeb");
            var Input = ResourceDataHelper.GetBasicSiteConfigResourceData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(WaitUntil.Completed, Input);
            WebSiteSlotConfig siteSlotConfigWeb = lro.Value;
            Assert.AreEqual(name, siteSlotConfigWeb.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        [Ignore("Cannot complete the operation because the site will exceed the number of slots allowed for the 'Free' SKU")]
        public async Task Get()
        {
            var container = await GetSiteSlotConfigWebCollectionAsync();
            var siteName = Recording.GenerateAssetName("testSiteSlotConfigWeb");
            var input = ResourceDataHelper.GetBasicSiteConfigResourceData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(WaitUntil.Completed, input);
            WebSiteSlotConfig site1 = lro.Value;
            WebSiteSlotConfig site2 = await container.GetAsync();
            ResourceDataHelper.AssertSiteSlotConfigWeb(site1.Data, site2.Data);
        }
    }
}
