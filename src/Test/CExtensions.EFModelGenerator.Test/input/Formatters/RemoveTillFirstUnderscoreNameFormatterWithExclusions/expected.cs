using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Formatters.RemoveTillFirstUnderscoreNameFormatterWithExclusions
{

   [Table("Person")]
   public partial class Person
   {

      public Person()
      {
         InitializePartial();
      }
      
      partial void InitializePartial();

      [Required]
      [Column("Pers_Id")]
      public long Id { get;set; }   // Person.Pers_Id

      [Required]
      [Column("PERS_LAST_NAME")]
      public string LAST_NAME { get;set; }   // Person.PERS_LAST_NAME

      [Required]
      [Column("My_Adress")]
      public string My_Adress { get;set; }   // Person.My_Adress

      [Required]
      [Column("MyOther_Adress")]
      public string MyOther_Adress { get;set; }   // Person.MyOther_Adress

   }

}
