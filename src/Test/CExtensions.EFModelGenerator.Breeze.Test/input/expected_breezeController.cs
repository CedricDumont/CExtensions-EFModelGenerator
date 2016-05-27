// This code was generated with CExtensions.EFModelGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c770eb04a54cf477 on 27/05/2016 10:46:54
// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator
// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)

using System;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Linq;
using Newtonsoft.Json.Linq;
using Breeze.WebApi2;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;

namespace MyNamespace
{
   [BreezeController]
   [EnableCors(origins: "*", headers: "*", methods: "*")]
   public partial class MyBreezeController : ApiController
   {
      readonly EFContextProvider<MyContext> _contextProvider;

      public MyBreezeController(EFContextProvider<MyContext> contextProvider)
      {
         _contextProvider = contextProvider;
      }

      [HttpGet]
      public string Metadata()
      {
         var metadata = _contextProvider.Metadata();
         return metadata;
      }

      [HttpGet]
      public IQueryable<Person> People()
      {
         return _contextProvider.Context.People;
      }

      [HttpGet]
      public IQueryable<Orders> Orders()
      {
         return _contextProvider.Context.Orders;
      }

      [HttpGet]
      public IQueryable<OrderLines> OrderLines()
      {
         return _contextProvider.Context.OrderLines;
      }

      [HttpPost]
      public SaveResult SaveChanges(JObject saveBundle)
      {
         return _contextProvider.SaveChanges(saveBundle);
      }
   }
}
