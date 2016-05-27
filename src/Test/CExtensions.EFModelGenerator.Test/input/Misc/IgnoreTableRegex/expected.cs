// This code was generated with CExtensions.EFModelGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c770eb04a54cf477 on 27/05/2016 10:46:56
// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator
// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Misc.IgnoreTableRegex
{

   [Table("Person")]
   public partial class Person
   {

      public Person()
      {
         InitializePartial();
      }
      
      partial void InitializePartial();

      [Key]
      [Column("PERS_ID")]
      public long PERS_ID { get;set; }  // Person.PERS_ID (PrimaryKey)

      [Column("PERS_FIRST_NAME")]
      public string PERS_FIRST_NAME { get;set; }   // Person.PERS_FIRST_NAME

      [Required]
      [Column("PERS_LAST_NAME")]
      public string PERS_LAST_NAME { get;set; }   // Person.PERS_LAST_NAME

      [Column("PERS_ADRESS")]
      public string PERS_ADRESS { get;set; }   // Person.PERS_ADRESS

      [Column("OTHER_ADRESS")]
      public string OTHER_ADRESS { get;set; }   // Person.OTHER_ADRESS

   }

}
