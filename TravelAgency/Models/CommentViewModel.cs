using System;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>CommentViewModel</c> class.
    /// Contains all properties of Commment entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class CommentViewModel
    {
        public int IDComment { get; set; }
        public string content { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? IDAccount { get; set; }
        public int? IDTour { get; set; }
        public virtual AccountViewModel ACCOUNT { get; set; }
        public virtual TourViewModel TOUR { get; set; }
    }
}