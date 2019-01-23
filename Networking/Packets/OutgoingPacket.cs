﻿using ENet;
using System.Collections.Generic;

namespace ImperialStudio.Core.Networking.Packets
{
    public struct OutgoingPacket
    {
        public IEnumerable<Peer> Peers { get; set; }
        public PacketType PacketType { get; set; }
        public byte[] Data { get; set; }
    }
}