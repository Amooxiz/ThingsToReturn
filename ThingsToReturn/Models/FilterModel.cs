namespace ThingsToReturn.Models
{
    public class FilterModel
    {
        public IList<int> Categories { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
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
