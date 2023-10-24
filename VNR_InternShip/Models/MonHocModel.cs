using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNR_InternShip.Models
{
    public class MonHocModel
    {
        [Key]
        public int Id { get; set; }
        [Column("TenMonHoc", TypeName = "nvarchar(100)")]
        public string NameTitle { get; set; }
        [Column("MoTa", TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        public string ImageKH { get; set; }
    }
}
