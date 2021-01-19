using Model.EF;
using TravelAgency.Models;

namespace TravelAgency.Infrastructure.Extensions
{
    public static class EntityExtencions
    {
        public static void UpdateTour(this TOUR tour, TourViewModel tourViewModel)
        {
            tour.IDTour = tourViewModel.IDTour;
            tour.TourName = tourViewModel.TourName;
            tour.Description = tourViewModel.Description;
            tour.Shortbody = tourViewModel.Shortbody;
            tour.Image = tourViewModel.Image;
            tour.policy = tourViewModel.policy;
            tour.termsProvisions = tourViewModel.termsProvisions;
            tour.Price = tourViewModel.Price;
            tour.Quantity = tourViewModel.Quantity;
            tour.Views = tourViewModel.Views;
            tour.DateCreated = tourViewModel.DateCreated;
            tour.DateModified = tourViewModel.DateModified;
            tour.Status = tourViewModel.Status;
            tour.DateStart = tourViewModel.DateStart;
            tour.Time = tourViewModel.Time;
            tour.LocationStart = tourViewModel.LocationStart;
            tour.IDCategory = tourViewModel.IDCategory;
        }
    }
}