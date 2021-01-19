using System;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>ContentViewModel</c> class.
    /// Contains all properties of Content entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class ContentViewModel
    {
        public int IDContent { get; set; }
        public string ContentName { get; set; }
        public string body { get; set; }
        public string shortBody { get; set; }
        public string Image { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool status { get; set; }
        public int views { get; set; }
        public DateTime dateShow { get; set; }
        public int? IDContentCategory { get; set; }
        public int? IDAccount { get; set; }
        public virtual AccountViewModel ACCOUNT { get; set; }
        public virtual ContentViewModel CONTENTCATEGORY { get; set; }
    }
}