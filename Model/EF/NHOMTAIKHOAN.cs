using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    [Table("NHOMTAIKHOAN")]
    public partial class NHOMTAIKHOAN
    {
        [Key]
        public string ma_Nhom { get; set; }

        [StringLength(15)]
        public string tenNhom { get; set; }
    }
}
