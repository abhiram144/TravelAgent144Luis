using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Website.Data_Models
{

    public class BusSearchResult
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public object[] returnflights { get; set; }
        public Onwardflight[] onwardflights { get; set; }
    }

    public class Onwardflight
    {
        public string origin { get; set; }
        public string rating { get; set; }
        public string DepartureTime { get; set; }
        public string cancellationPolicy { get; set; }
        public int avlWindowSeats { get; set; }
        public int impulse_perc_seats { get; set; }
        public string BusServiceID { get; set; }
        public string totalReviews { get; set; }
        public string seat { get; set; }
        public string duration { get; set; }
        public string qtype { get; set; }
        public bool AvailCatCard { get; set; }
        public string skey { get; set; }
        public string busCondition { get; set; }
        public string src_voyager_id { get; set; }
        public float levyFee { get; set; }
        public string destination { get; set; }
        public Bpprims BPPrims { get; set; }
        public string amenities { get; set; }
        public string src_vendor_id { get; set; }
        public string dest_voyager_id { get; set; }
        public string ArrivalTime { get; set; }
        public float zeroCancellationTime { get; set; }
        public string gps { get; set; }
        public Fare fare { get; set; }
        public string dst_vendor_id { get; set; }
        public string OperatorID { get; set; }
        public Dpprims DPPrims { get; set; }
        public string mTicket { get; set; }
        public string row_type { get; set; }
        public string BusType { get; set; }
        public Routeseattypedetail RouteSeatTypeDetail { get; set; }
        public DateTime depdate { get; set; }
        public string idRequired { get; set; }
        public int ServiceID { get; set; }
        public string busCompany { get; set; }
        public bool bpDpSeatLayout { get; set; }
        public string TravelsName { get; set; }
        public string tbrequired { get; set; }
        public string farebasis { get; set; }
        public string RouteID { get; set; }
        public string ServiceName { get; set; }
        public float srtFee { get; set; }
        public string partialCancellationAllowed { get; set; }
        public string ugcid { get; set; }
        public DateTime arrdate { get; set; }
        public string impulse_text { get; set; }
        public string impulse_color { get; set; }
        public Reddeal reddeal { get; set; }
    }

    public class Bpprims
    {
        public List[] list { get; set; }
    }

    public class List
    {
        public string BPId { get; set; }
        public string BPContactNumber { get; set; }
        public string BPName { get; set; }
        public DateTime BPTime { get; set; }
        public string BPLandmark { get; set; }
        public string BPLocation { get; set; }
        public string BPAddress { get; set; }
        public string BPCoordinates { get; set; }
    }

    public class Fare
    {
        public string adultservicetax { get; set; }
        public string adultcommission { get; set; }
        public string adultbasefare { get; set; }
        public string adultsurcharge { get; set; }
        public string totalfare { get; set; }
        public string discount { get; set; }
        public string totalsurcharge { get; set; }
        public string totalcommission { get; set; }
        public string transactionfee { get; set; }
        public string totalbasefare { get; set; }
        public string adulttotalfare { get; set; }
        public string servicetax { get; set; }
    }

    public class Dpprims
    {
        public List1[] list { get; set; }
    }

    public class List1
    {
        public DateTime DPTime { get; set; }
        public string BPContactNumber { get; set; }
        public string DPName { get; set; }
        public string DPAddress { get; set; }
        public string DPLandmark { get; set; }
        public string DPId { get; set; }
        public string DPContactNumber { get; set; }
        public string BPLandmark { get; set; }
        public string DPCoordinates { get; set; }
        public string BPAddress { get; set; }
        public string DPLocation { get; set; }
    }

    public class Routeseattypedetail
    {
        public List2[] list { get; set; }
    }

    public class List2
    {
        public string SellFare { get; set; }
        public string busCondition { get; set; }
        public string seatType { get; set; }
        public string seatTypeSpecific { get; set; }
        public int SeatsAvailable { get; set; }
        public string availabilityStatus { get; set; }
    }

    public class Reddeal
    {
        public string[] offerNoteApps { get; set; }
        public float[] op { get; set; }
        public string offerDesc { get; set; }
        public float[] dp { get; set; }
        public string offerNote { get; set; }
    }

}