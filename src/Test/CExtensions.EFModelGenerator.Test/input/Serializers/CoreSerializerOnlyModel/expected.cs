// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator
// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Serializers.CoreSerializerOnlyModel
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

      [InverseProperty("Person")]
      public virtual List<Orders> Orders { get; set; }

      [InverseProperty("Person")]
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

      [InverseProperty("Orders")]
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

}
