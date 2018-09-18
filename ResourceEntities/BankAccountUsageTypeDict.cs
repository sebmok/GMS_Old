namespace ResourceEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankAccountUsageTypeDict")]
    public partial class BankAccountUsageTypeDict
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UsageTypeName { get; set; }

        public int? ObjId { get; set; }
    }
}
