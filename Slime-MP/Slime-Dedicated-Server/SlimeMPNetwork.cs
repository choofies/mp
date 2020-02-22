using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;

namespace Slime_Dedicated_Server
{
    public class SlimeMPNetwork
    {
        public readonly int Port;
        internal NetManager netManager;
        internal EventBasedNetListener netListener;
        public SlimeMPNetwork(int port = 8055)
        {
            Port = port;
            netListener = new EventBasedNetListener();
            netListener.ConnectionRequestEvent += OnConnectionRequest;
            netListener.PeerConnectedEvent += OnPeerConnected;
            netListener.PeerDisconnectedEvent += OnPeerDisconnected;
            netListener.NetworkReceiveEvent += OnPeerDataReceived;
            netManager = new NetManager(netListener);
        }
        public IEnumerable<SlimePeer> ConnectedPeers 
            => netManager.ConnectedPeerList.Select(x => (SlimePeer)x.Tag);
        internal SlimePeer NetPeerToSlimePeer(NetPeer peer) 
            => (SlimePeer)peer.Tag;
        public bool Start() => netManager.Start(Port);
        public bool Stop() 
        {
            if (!netManager.IsRunning)
                return false;
            netManager.Stop();
            return true;
        }
        public void PollEvents() => netManager.PollEvents();
        internal void OnConnectionRequest(ConnectionRequest request)
        {

        }
        internal void OnPeerConnected(NetPeer peer)
        {

        }
        internal void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {

        }
        internal void OnPeerDataReceived(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
        {

        }
    }
}
