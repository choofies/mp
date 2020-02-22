using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Slime_Dedicated_Server
{
    public class SlimePeer
    {
        internal readonly NetPeer PlayerPeer;
        public int Ping => PlayerPeer.Ping;
        public bool IsConnected
            => PlayerPeer.ConnectionState == ConnectionState.Connected;
        public IPAddress IPAddress 
            => PlayerPeer.EndPoint.Address;
        internal SlimePeer(NetPeer peer)
        {
            PlayerPeer = peer;
        }
        public bool SendEvent(EventData data)
        {

        }
        public bool Send(NetDataWriter data, DeliveryMethod deliveryMethod)
        {
            if (!IsConnected)
                return false;
            PlayerPeer.Send(data, deliveryMethod);
            return true;
        }
    }
}
