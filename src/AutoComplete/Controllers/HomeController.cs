using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AutoComplete.Models;
//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Cloudsearch.v1;
//using Google.Apis.Datastore.v1beta1;
//using Google.Apis.Datastore.v1beta1.Data;
//using Google.Apis.Services;
using Microsoft.AspNet.Mvc;
//using QueryResultBatch = Google.Apis.Datastore.v1beta1.Data.QueryResultBatch;
//using Enyim.Caching;
//using Enyim.Caching.Configuration;
//using Enyim.Caching.Memcached;
using System.Net;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        AutoCompleteModel model = new AutoCompleteModel();
        //private DatastoreService service;
        //private MemcachedClient memcachedClient;

        public HomeController()
        {
            InitDataStoreService();
            InitMemcachedClient();
        }

        public IActionResult Index()
        {
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Autocomplete(string term)
        {
            //GqlQuery q = new GqlQuery();
            //q.QueryString = $"select * from product where nm >= '{term}' limit 10";
            //q.AllowLiteral = true;

            //RunQueryRequest request = new RunQueryRequest();

            //request.GqlQuery = q;

            //var obj = service.Datasets.RunQuery(request, "containerdemo-1190");
            //RunQueryResponse resp = null;
            //try
            //{
            //    resp = obj.Execute();
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //    throw;
            //}

            //var list = resp.Batch.EntityResults.Select(entityResult => new Product
            //{
            //    Name = entityResult.Entity.Properties["nm"].Values.First().StringValue,
            //    Id = int.Parse(entityResult.Entity.Key.Path.First().Id.ToString())
            //}).ToList();


            ////test memcache
            //foreach (var item in list)
            //{
            //    memcachedClient.Store(StoreMode.Set, item.Id.ToString(), item.Name);
            //    var cacheItem = memcachedClient.Get(item.Id.ToString());
            //    Debug.WriteLine(cacheItem);
            //}

            var list = new List<Product>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(new Product()
                {
                    Id = i,
                    Name = $"product{i}"
                });
            }
            return Json(list);
        }

        void InitDataStoreService()
        {
            //const string serviceAccountEmail = "containersvcacc@containerdemo-1190.iam.gserviceaccount.com";
            //var certificate = new X509Certificate2(@"ContainerDemo-65e90699b00f.p12", "notasecret", X509KeyStorageFlags.Exportable);

            //var credential = new ServiceAccountCredential(
            //       new ServiceAccountCredential.Initializer(serviceAccountEmail)
            //       {
            //           Scopes = new[] {
            //               DatastoreService.Scope.CloudPlatform.ToLower(),
            //               DatastoreService.Scope.Datastore.ToLower(),
            //               DatastoreService.Scope.UserinfoEmail.ToLower()
            //           }
            //       }.FromCertificate(certificate));

            //service = new DatastoreService(new BaseClientService.Initializer
            //{
            //    HttpClientInitializer = credential,
            //    ApplicationName = "***"
            //});
        }

        void InitMemcachedClient()
        {
            //MemcachedClientConfiguration config = new MemcachedClientConfiguration();

            //config.Servers.Add(new IPEndPoint(IPAddress.Parse("162.222.181.18"), 80));
            //config.Protocol = MemcachedProtocol.Binary;
            //config.Authentication.Type = typeof(PlainTextAuthenticator);
            //config.Authentication.Parameters["userName"] = "user";
            //config.Authentication.Parameters["password"] = "m9NFPbQ2 ";
            //config.Authentication.Parameters["zone"] = "us-central1-f";

            //memcachedClient = new MemcachedClient(config);
        }
    }
}
