using System;

namespace Zayvka.model
{
    public class Applications
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string ClientNumber { get; set; }
        public string Staff { get; set; }
        public string StaffNumber { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Fault { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Equipment { get; set; }
        public string Problem { get; set; }
        public string Comment { get; set; }
        public DateTime FinishDate { get; set; }
        public bool isNewStatus { get; set; }
    }
}
