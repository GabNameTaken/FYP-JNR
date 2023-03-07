using System;
using UnityEngine;

[CreateAssetMenu()]
public class SessionInfo : ScriptableObject
{
    [SerializeField] private string voucherCode;
    [SerializeField] private int maxPlayers;
    [SerializeField] private int gameDurationMinutes;
    [SerializeField] private int voucherDurationMinutes;
    private DateTime startTime;
    private DateTime expireTime;


    public string VoucherCode { get => voucherCode; }
    public int MaxPlayers { get => maxPlayers; }
    public int GameDurationMinutes { get => gameDurationMinutes; }
    public int VoucherDurationMinutes { get => voucherDurationMinutes; }
    public DateTime StartTime { get => startTime; }
    public DateTime ExpireTime { get => expireTime; }
    public void StoreVoucherData(string voucherCode, VoucherData voucherData)
    {
        this.voucherCode = voucherCode;
        maxPlayers = voucherData.maxPlayers;
        gameDurationMinutes = voucherData.gameDuration;
        voucherDurationMinutes = voucherData.voucherDuration;
        startTime = DateTime.MinValue;
        expireTime = DateTime.MaxValue;
        //expireTime = DateTime.Parse(voucherData.endTime);
    }
}
