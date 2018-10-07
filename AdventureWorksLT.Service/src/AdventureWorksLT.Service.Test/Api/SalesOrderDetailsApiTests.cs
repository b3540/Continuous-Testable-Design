/* 
 * AdventureWorksLT
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using AdventureWorksLT.Service.Client;
using AdventureWorksLT.Service.Api;
using AdventureWorksLT.Service.Model;

namespace AdventureWorksLT.Service.Test
{
    /// <summary>
    ///  Class for testing SalesOrderDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SalesOrderDetailsApiTests
    {
        private SalesOrderDetailsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SalesOrderDetailsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SalesOrderDetailsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SalesOrderDetailsApi
            //Assert.IsInstanceOfType(typeof(SalesOrderDetailsApi), instance, "instance is a SalesOrderDetailsApi");
        }

        
        /// <summary>
        /// Test SalesOrderDetailsGet
        /// </summary>
        [Test]
        public void SalesOrderDetailsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SalesOrderDetailsGet();
            //Assert.IsInstanceOf<List<SalesOrderDetail>> (response, "response is List<SalesOrderDetail>");
        }
        
    }

}
