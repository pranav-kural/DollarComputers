namespace DollarComputers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        public short productID { get; set; }

        [Column(TypeName = "money")]
        public decimal? cost { get; set; }

        [StringLength(255)]
        public string manufacturer { get; set; }

        [StringLength(255)]
        public string model { get; set; }

        [StringLength(255)]
        public string RAM_type { get; set; }

        [StringLength(255)]
        public string RAM_size { get; set; }

        [StringLength(255)]
        public string displaytype { get; set; }

        [StringLength(255)]
        public string screensize { get; set; }

        [StringLength(255)]
        public string resolution { get; set; }

        [StringLength(255)]
        public string CPU_Class { get; set; }

        [StringLength(255)]
        public string CPU_brand { get; set; }

        [StringLength(255)]
        public string CPU_type { get; set; }

        [StringLength(255)]
        public string CPU_speed { get; set; }

        [StringLength(255)]
        public string CPU_number { get; set; }

        [StringLength(255)]
        public string condition { get; set; }

        [StringLength(255)]
        public string OS { get; set; }

        [StringLength(255)]
        public string platform { get; set; }

        [StringLength(255)]
        public string HDD_size { get; set; }

        [StringLength(255)]
        public string HDD_speed { get; set; }

        [StringLength(255)]
        public string GPU_Type { get; set; }

        [StringLength(255)]
        public string optical_drive { get; set; }

        [StringLength(255)]
        public string Audio_type { get; set; }

        [StringLength(255)]
        public string LAN { get; set; }

        [StringLength(255)]
        public string WIFI { get; set; }

        [StringLength(255)]
        public string width { get; set; }

        [StringLength(255)]
        public string height { get; set; }

        [StringLength(255)]
        public string depth { get; set; }

        [StringLength(255)]
        public string weight { get; set; }

        [StringLength(255)]
        public string moust_type { get; set; }

        [StringLength(255)]
        public string power { get; set; }

        [StringLength(255)]
        public string webcam { get; set; }
    }
}
