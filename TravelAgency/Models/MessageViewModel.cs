using System;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>MessageViewModel</c> class.
    /// Contains all properties of Message entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class MessageViewModel
    {
        public int IDMessage { get; set; }
        public string body { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? IDAccount { get; set; }
        public virtual AccountViewModel ACCOUNT { get; set; }
    }
}