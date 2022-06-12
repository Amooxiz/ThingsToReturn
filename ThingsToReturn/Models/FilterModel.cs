namespace ThingsToReturn.Models
{
    public class FilterModel
    {
        public string CategoryId { get; set; }
        [DataType("Date")]
        public DateTime? CreationDateFrom { get; set; }
        [DataType("Date")]
        public DateTime? CreationDateTo { get; set; }
        [DataType("Date")]
        public DateTime? ExpirationDateFrom { get; set; }
        [DataType("Date")]
        public DateTime? ExpirationDateTo { get; set; }

    }
}
