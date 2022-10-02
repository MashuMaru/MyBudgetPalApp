namespace MyBudgetPal.Models
{
    public class HandlerResultModel<T>
    {
        public T Data { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
    }
}