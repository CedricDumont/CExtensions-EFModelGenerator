// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator
// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)

using System;
using System.Data.Entity;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GenerationWithDbContext
{

   [Table("Person")]
   public partial class Person
   {

      public Person()
      {
         Orders = new List<Orders>();
         OrderLines = new List<OrderLines>();
         InitializePartial();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("PERS_ID")]
      public long PERS_ID { get;set; }  // Person.PERS_ID (PrimaryKey)

      [Column("PERS_FIRST_NAME")]
      public string PERS_FIRST_NAME { get;set; }   // Person.PERS_FIRST_NAME

      // Reverse Navigation

      [InverseProperty("OR_PERS_ID_Key")]
      public virtual List<Orders> Orders { get; set; }

      [InverseProperty("OL_Person_Key")]
      public virtual List<OrderLines> OrderLines { get; set; }

   }

   [Table("Orders")]
   public partial class Orders
   {

      public Orders()
      {
         OrderLines = new List<OrderLines>();
         InitializePartial();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("ORDER_ID")]
      public long ORDER_ID { get;set; }  // Orders.ORDER_ID (PrimaryKey)

      [Required]
      [Column("Amount")]
      public string Amount { get;set; }   // Orders.Amount

      [Column("OR_PERS_ID")]
      public long? OR_PERS_ID_Key { get;set; }  // Orders.OR_PERS_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("OR_PERS_ID_Key")]
      public virtual Person Person { get; set; }

      // Reverse Navigation

      [InverseProperty("OL_Orders_Key")]
      public virtual List<OrderLines> OrderLines { get; set; }

   }

   [Table("OrderLines")]
   public partial class OrderLines
   {

      public OrderLines()
      {
         InitializePartial();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("OL_ID")]
      public long? OL_ID { get;set; }  // OrderLines.OL_ID (PrimaryKey)

      [Column("count")]
      public long? count { get;set; }   // OrderLines.count

      [Column("OL_Person")]
      public long? OL_Person_Key { get;set; }  // OrderLines.OL_Person (ForeignKey)

      [Column("OL_Orders")]
      public long? OL_Orders_Key { get;set; }  // OrderLines.OL_Orders (ForeignKey)

      // ForeignKeys

      [ForeignKey("OL_Person_Key")]
      public virtual Person Person { get; set; }

      [ForeignKey("OL_Orders_Key")]
      public virtual Orders Orders { get; set; }

   }

   public partial class SampleDbContext: DbContext {

      public IDbSet<Person> People { get; set; } // Person 

      public IDbSet<Orders> Orders { get; set; } // Orders 

      public IDbSet<OrderLines> OrderLines { get; set; } // OrderLines 

      // Constructors
      static SampleDbContext()
      {
            Database.SetInitializer<SampleDbContext>(null);
      }
      public SampleDbContext() : base("Name=SampleDbContext")
      {
            InitializePartial();
      }
      
      public SampleDbContext(string connectionString) : base(connectionString)
      {
            InitializePartial();
      }
      
      public SampleDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
      {
            InitializePartial();
      }
      
      public SampleDbContext(DbConnection existingConn) : base(existingConn, true)
      {
            InitializePartial();
      }
      
      protected override void Dispose(bool disposing)
      {
            base.Dispose(disposing);
      }

      partial void InitializePartial();

   }
}
