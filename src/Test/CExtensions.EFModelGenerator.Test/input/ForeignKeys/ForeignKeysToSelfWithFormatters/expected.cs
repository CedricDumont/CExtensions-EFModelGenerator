using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ForeignKeys.ForeignKeysToSelfWithFormatters
{

   [Table("Person")]
   public partial class Person
   {

      public Person()
      {
         Person_1 = new List<Person>();
         Person_2 = new List<Person>();
         InitializePartial();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("PERS_ID")]
      public long ID { get;set; }  // Person.PERS_ID (PrimaryKey)

      [Required]
      [Column("PERS_FIRST_NAME")]
      public string FirstName { get;set; }   // Person.PERS_FIRST_NAME

      [Column("PERS_PARENT_ID")]
      public long ParentId_Key { get;set; }  // Person.PERS_PARENT_ID (ForeignKey)

      [Column("PERS_BROTHER_ID")]
      public long BrotherId_Key { get;set; }  // Person.PERS_BROTHER_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("ParentId_Key")]
      public virtual Person Person_ParentId_Key { get; set; }

      [ForeignKey("BrotherId_Key")]
      public virtual Person Person_BrotherId_Key { get; set; }

      // Reverse Navigation

      [InverseProperty("ParentId_Key")]
      public virtual List<Person> Person_1 { get; set; }

      [InverseProperty("BrotherId_Key")]
      public virtual List<Person> Person_2 { get; set; }

   }

}
