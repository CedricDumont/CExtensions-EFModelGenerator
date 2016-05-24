using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace customNameFormatters
{

    [Table("Person")]
    public partial class Person
    {

        [Key]
        [Column("Pers_Id")]
        public long pers_id { get; set; }  // Person.Pers_Id (PrimaryKey)

        [Required]
        [Column("LAST_NAME")]
        public string FamilyName { get; set; }   // Person.LAST_NAME

        [Required]
        [Column("PERS_FIRST_NAME")]
        public string pers_first_name { get; set; }   // Person.PERS_FIRST_NAME

    }

    [Table("Friend")]
    public partial class Friend
    {

        [Required]
        [Column("LAST_NAME")]
        public string last_name { get; set; }   // Friend.LAST_NAME

    }

}
