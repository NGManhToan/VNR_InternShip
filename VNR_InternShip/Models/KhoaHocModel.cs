using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VNR_InternShip.Models
{
    public class KhoaHocModel
    {
        [Key]
        public int Id { get; set; }
        [Column("TenKhoaHoc", TypeName = "Varchar(30)")]
        public string NameCourse { get; set; }

        public string Image { get; set; }
    }
}
