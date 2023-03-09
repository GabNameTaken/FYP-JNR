using System;

public class SessionInfo
{
    public string VoucherCode { get; }
    public int MaxPlayers { get; }
    public DateTime StartTime { get; }
    public DateTime ExpireTime { get; }

    public SessionInfo(string voucherCode, int maxPlayers, DateTime startTime, DateTime expireTime)
    {
        VoucherCode = voucherCode;
        MaxPlayers = maxPlayers;
        StartTime = startTime;
        ExpireTime = expireTime;
    }
}
