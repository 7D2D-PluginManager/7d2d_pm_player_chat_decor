using System.Collections.Generic;

namespace PlayerChatDecor;

public class PlayerConfig
{
    public Dictionary<string, PlayerInfo> Players { get; set; } = new();
}