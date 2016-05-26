using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Relations.MultipleRelationsWithFormatters
{

   [Table("Person")]
   public partial class Person
   {

      public Person()
      {
         Orders = new List<Orders>();
         OrderLines = new List<OrderLines>();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("PERS_ID")]
      public long ID { get;set; }  // Person.PERS_ID (PrimaryKey)

      [Column("PERS_FIRST_NAME")]
      public string FirstName { get;set; }   // Person.PERS_FIRST_NAME

      // Reverse Navigation

      [InverseProperty("PersId_Key")]
      public virtual List<Orders> Orders { get; set; }

      [InverseProperty("Person_Key")]
      public virtual List<OrderLines> OrderLines { get; set; }

   }

   [Table("Orders")]
   public partial class Orders
   {

      public Orders()
      {
         OrderLines = new List<OrderLines>();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("ORDER_ID")]
      public long ID { get;set; }  // Orders.ORDER_ID (PrimaryKey)

      [Required]
      [Column("Amount")]
      public string Amount { get;set; }   // Orders.Amount

      [Column("OR_PERS_ID")]
      public long? PersId_Key { get;set; }  // Orders.OR_PERS_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PersId_Key")]
      public virtual Person Person { get; set; }

      // Reverse Navigation

      [InverseProperty("Orders_Key")]
      public virtual List<OrderLines> OrderLines { get; set; }

   }

   [Table("OrderLines")]
   public partial class OrderLines
   {

      public OrderLines()
      {
      }
      
      partial void InitializePartial();

      [Key]
      [Column("OL_ID")]
      public long? ID { get;set; }  // OrderLines.OL_ID (PrimaryKey)

      [Column("count")]
      public long? Count { get;set; }   // OrderLines.count

      [Column("OL_Person")]
      public long? Person_Key { get;set; }  // OrderLines.OL_Person (ForeignKey)

      [Column("OL_Orders")]
      public long? Orders_Key { get;set; }  // OrderLines.OL_Orders (ForeignKey)

      // ForeignKeys

      [ForeignKey("Person_Key")]
      public virtual Person Person { get; set; }

      [ForeignKey("Orders_Key")]
      public virtual Orders Orders { get; set; }

   }

}
