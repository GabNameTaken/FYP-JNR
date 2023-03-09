public class VoucherCodeChecker
{
    public SessionInfo GetSessionInfoFromAPI(string voucherCode)
    {
        // No API yet;
        if (string.IsNullOrEmpty(voucherCode))
        {
            return null;
        }
        else
        {
            return new SessionInfo(voucherCode, 100, System.DateTime.Now, System.DateTime.MaxValue);
        }
    }
}
