namespace WindowsFormsApp_ID3.mdoels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entropy")]
    public partial class Entropy
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string HinhDang { get; set; }

        [StringLength(50)]
        public string ChieuCao { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string KetQua { get; set; }
    }
}
