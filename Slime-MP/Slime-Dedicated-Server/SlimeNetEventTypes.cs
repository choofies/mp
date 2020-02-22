using System;
using System.Collections.Generic;
using System.Text;

namespace Slime_Dedicated_Server
{
    public enum SlimeNetEvent : byte
    {
        PlayerNetSync = 1,
        RPC,
        ObjectsSync = 100,
        TransitionScene,
        PlayerDisconnected,
        PlayerConnected
    }
}
