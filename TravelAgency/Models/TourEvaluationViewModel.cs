using System;

namespace TravelAgency.Models
{
    /// <summary>
    /// The main <c>TourEvaluationViewModel</c> class.
    /// Contains all properties of TourEvaluation entity
    /// Author: VoXuanQuocVuong
    /// Email: vovuong1025@gmail.com
    /// Date Create: 19/01/2021
    /// </summary>
    public class TourEvaluationViewModel
    {
        public int IDEvaluation { get; set; }
        public int Point { get; set; }
        public string content { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? IDTour { get; set; }
        public virtual TourViewModel TOUR { get; set; }
    }
}