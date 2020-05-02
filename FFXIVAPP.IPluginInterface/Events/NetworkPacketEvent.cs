// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NetworkPacketEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2020 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   NetworkPacketEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using FFXIVAPP.Common.Core.Network;

    public class NetworkPacketEvent : EventArgs {
        public NetworkPacketEvent(object sender, NetworkPacket networkPacket) {
            this.Sender = sender;
            this.Packet = networkPacket;
        }

        public NetworkPacket Packet { get; set; }

        public object Sender { get; set; }
    }
}