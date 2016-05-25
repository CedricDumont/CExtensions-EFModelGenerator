﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Relations.SimpleRelation
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

        // Reverse Navigation

        [InverseProperty("pers_id_Key")]
        public virtual List<Orders> Orders { get; set; }

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

        [Column("pers_id")]
        public long pers_id_Key { get; set; }  // Orders.pers_id (ForeignKey)

        // ForeignKeys

        [ForeignKey("pers_id_Key")]
        public virtual Person Person { get; set; }

    }

}
