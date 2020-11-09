namespace Adapter
{
    public class XpayToPayD : IPayD
    {
        public string CustCardNo { get; set; }
        public string CardOwnerName { get; set; }
        public string CardExpMonthDate { get; set; }
        public int CvvNo { get; set; }
        public decimal TotalAmount { get; set; }       
        

        public static IPayD XpayToPayDAdapter(IXPay ixp)
        {
            var adapter = new XpayToPayD();
            adapter.CustCardNo = ixp.CreditCardNo;
            adapter.CardOwnerName = ixp.CustomerName;
            adapter.CardExpMonthDate = ixp.CardExpMonth;
            adapter.CvvNo = ixp.CardCvvNo;
            adapter.TotalAmount = (decimal)ixp.Amount;

            return adapter;
        }
    }
}