namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MENU")]
    public partial class MENU
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string Text { get; set; }

        [StringLength(255)]
        public string Link { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(50)]
        public string Target { get; set; }

        public bool? Status { get; set; }

        public int? TypeID { get; set; }

        public virtual MENUTYPE MENUTYPE { get; set; }
    }
}
