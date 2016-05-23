using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace my.business.space.one
{

    [Table("Person")]
    public partial class Person
    {

        [Key]
        [Column("PERS_ID")]
        public long PERS_ID { get; set; }  // Person.PERS_ID (PrimaryKey)

        [Column("PERS_FIRST_NAME")]
        public string PERS_FIRST_NAME { get; set; }   // Person.PERS_FIRST_NAME

        [Required]
        [Column("PERS_LAST_NAME")]
        public string PERS_LAST_NAME { get; set; }   // Person.PERS_LAST_NAME

        [Column("PERS_ADRESS")]
        public string PERS_ADRESS { get; set; }   // Person.PERS_ADRESS

        [Column("OTHER_ADRESS")]
        public string OTHER_ADRESS { get; set; }   // Person.OTHER_ADRESS

    }

    [Table("Orders")]
    public partial class Orders
    {

        [Key]
        [Column("Id")]
        public long Id { get; set; }  // Orders.Id (PrimaryKey)

        [Required]
        [Column("Amount")]
        public string Amount { get; set; }   // Orders.Amount

        [Column("lines")]
        public long lines { get; set; }   // Orders.lines

        [Column("pers_id")]
        public long pers_id { get; set; }  // Orders.pers_id (ForeignKey)

        // ForeignKeys

        [ForeignKey("pers_id")]
        public virtual Person Person { get; set; }

    }

}
