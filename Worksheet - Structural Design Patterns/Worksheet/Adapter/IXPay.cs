namespace Adapter
{
    public interface IXPay
    {
        public string CreditCardNo { get; set; } //public string CustCardNo { get; set; }
        public string CustomerName { get; set; } //public string CardOwnerName { get; set; }
        public string CardExpMonth { get; set; } //public string CardExpMonthDate { get; set; }
        public string CardExpYear { get; set; }
        public short CardCvvNo { get; set; } //public int CvvNo { get; set; }
        public double Amount { get; set; } //public decimal TotalAmount { get; set; }
    }
}





