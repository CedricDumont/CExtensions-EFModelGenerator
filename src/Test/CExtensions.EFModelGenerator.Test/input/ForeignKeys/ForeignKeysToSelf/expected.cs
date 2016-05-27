// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator
// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ForeignKeys.ForeignKeysToSelf
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
      public long PERS_ID { get;set; }  // Person.PERS_ID (PrimaryKey)

      [Required]
      [Column("PERS_FIRST_NAME")]
      public string PERS_FIRST_NAME { get;set; }   // Person.PERS_FIRST_NAME

      [Column("PERS_PARENT_ID")]
      public long PERS_PARENT_ID_Key { get;set; }  // Person.PERS_PARENT_ID (ForeignKey)

      [Column("PERS_BROTHER_ID")]
      public long PERS_BROTHER_ID_Key { get;set; }  // Person.PERS_BROTHER_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PERS_PARENT_ID_Key")]
      public virtual Person Person_PERS_PARENT_ID_Key { get; set; }

      [ForeignKey("PERS_BROTHER_ID_Key")]
      public virtual Person Person_PERS_BROTHER_ID_Key { get; set; }

      // Reverse Navigation

      [InverseProperty("Person_PERS_PARENT_ID_Key")]
      public virtual List<Person> Person_1 { get; set; }

      [InverseProperty("Person_PERS_BROTHER_ID_Key")]
      public virtual List<Person> Person_2 { get; set; }

   }

}
