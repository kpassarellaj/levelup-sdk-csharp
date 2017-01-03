﻿#region Copyright (Apache 2.0)
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// <copyright file="IRetrievePaymentTokenUnitTests.cs" company="SCVNGR, Inc. d/b/a LevelUp">
//   Copyright(c) 2016 SCVNGR, Inc. d/b/a LevelUp. All rights reserved.
// </copyright>
// <license publisher="Apache Software Foundation" date="January 2004" version="2.0">
//   Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
//   in compliance with the License. You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software distributed under the License
//   is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
//   or implied. See the License for the specific language governing permissions and limitations under
//   the License.
// </license>
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
#endregion

extern alias ThirdParty;
using System.Net;
using LevelUp.Api.Client.ClientInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdParty.RestSharp;


namespace LevelUp.Api.Client.Test.Client
{
    [TestClass]
    public class IRetrievePaymentTokenUnitTests
    {
        [TestMethod]
        [TestCategory(LevelUp.Api.Utilities.Test.TestCategories.UnitTests)]
        public void GetPaymentTokenShouldSucceed()
        {
            const string expectedRequestUrl = "https://sandbox.thelevelup.com/v15/payment_token";

            RestResponse expectedResponse = new RestResponse
            {
                StatusCode = HttpStatusCode.OK,
                Content = 
                "{" +
                    "\"payment_token\": {" +
                        "\"data\": \"LU02000008ZS9OJFUBNEL6ZM\"," +
                        "\"id\": 323" +
                    "}" +
                "}"
            };

            IRetrievePaymentToken client = ClientModuleUnitTestingUtilities.GetMockedLevelUpModule<IRetrievePaymentToken>(
                expectedResponse, expectedRequestUrl: expectedRequestUrl);
            var paymentToken = client.GetPaymentToken("not_checking_this");
            Assert.AreEqual(paymentToken.Id, 323);
            Assert.AreEqual(paymentToken.Data, "LU02000008ZS9OJFUBNEL6ZM");
        }
    }
}
