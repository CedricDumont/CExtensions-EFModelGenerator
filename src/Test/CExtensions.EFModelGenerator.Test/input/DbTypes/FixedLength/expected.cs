// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator
// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DbTypes.FixedLength
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
        [StringLength(5, MinimumLength = 5)]
        [Column("PERS_SHORT_NAME")]
        public string PERS_SHORT_NAME { get; set; }   // Person.PERS_SHORT_NAME

        [Required]
        [MaxLength(20)]
        [Column("PERS_LAST_NAME")]
        public string PERS_LAST_NAME { get; set; }   // Person.PERS_LAST_NAME

    }

}
