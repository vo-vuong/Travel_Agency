using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>TourViewModel</c> class.
    /// Contains all properties of Tour entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class TourViewModel
    {
        public int IDTour { get; set; }

        [DisplayName("Tên Tour")]
        [Required]
        [StringLength(255)]
        public string TourName { get; set; }

        [DisplayName("Mô tả")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [DisplayName("Mô tả ngắn")]
        [StringLength(500)]
        [Required]
        public string Shortbody { get; set; }

        [DisplayName("Hình ảnh")]
        [StringLength(255)]
        public string Image { get; set; }

        [DisplayName("Chính sách")]
        public string policy { get; set; }

        [DisplayName("Điều khoản")]
        public string termsProvisions { get; set; }

        [DisplayName("Giá")]
        [Range(0,double.MaxValue,ErrorMessage ="Vui lòng nhập số tiền phù hợp")]
        public decimal? Price { get; set; }

        [DisplayName("Số lượng")]
        [Range(0,int.MaxValue,ErrorMessage ="Vui lòng nhập số lượng phù hợp")]
        public int Quantity { get; set; }

        [DisplayName("Lượt xem")]
        public int? Views { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? DateCreated { get; set; }

        [DisplayName("Ngày sửa")]
        public DateTime? DateModified { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        [DisplayName("Ngày khởi hành")]
        public DateTime DateStart { get; set; }

        [DisplayName("Thời gian đi")]
        [Required]
        [StringLength(100)]
        public string Time { get; set; }

        [DisplayName("Địa điểm khởi hành")]
        [StringLength(255)]
        public string LocationStart { get; set; }

        [DisplayName("Danh mục tour")]
        public int? IDCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillViewModel> BILLs { get; set; }

        public virtual CategoryTourViewModel CATEGORY_TOUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentViewModel> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourEvaluationViewModel> TOUREVALUATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourSaleViewModel> TOURSALEs { get; set; }
    }
}