using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("pi_dep")]
    public partial class PiDep
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("mr_ml", TypeName = "character varying")]
        public string MrMl { get; set; }
        [Column("расшифровка", TypeName = "character varying")]
        public string Расшифровка { get; set; }
        [Column("mr_osl", TypeName = "character varying")]
        public string MrOsl { get; set; }
        [Column("field_4", TypeName = "character varying")]
        public string Field4 { get; set; }
        [Column("gr молчанов", TypeName = "character varying")]
        public string GrМолчанов { get; set; }
        [Column("cnt")]
        public int? Cnt { get; set; }
        [Column("исправить у нас", TypeName = "character varying")]
        public string ИсправитьУНас { get; set; }
    }
}
