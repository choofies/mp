using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slime_Dedicated_Server
{
    public class EventData : NetDataWriter
    {
        public EventData(byte slimeEvent)
        {
            Put(slimeEvent);
        }
        public DeliveryMethod DeliveryMethod { get; set; }
        public byte SlimeEvent
        {
            get
            {
                return _data[0];
            }
            set
            {
                _data[0] = value;
            }
        }
        }
    }
}
