namespace MyBudgetPal.Data.Models
{
    public class NewUserDataModel
    {
        public Guid ID { get; set; }
        public Guid ACCESS_CODE { get; set; }
        public string USERNAME { get; set; }
        public string EMAIL { get; set; }
        public DateTime DATE_CREATED { get; set; }
    }
}