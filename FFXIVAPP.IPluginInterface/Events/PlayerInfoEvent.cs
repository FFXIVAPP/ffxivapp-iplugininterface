// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerInfoEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   PlayerInfoEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using Sharlayan.Core;

    public class PlayerInfoEvent : EventArgs {
        public PlayerInfoEvent(object sender, PlayerInfo playerInfo) {
            this.Sender = sender;
            this.PlayerInfo = playerInfo;
        }

        public PlayerInfo PlayerInfo { get; set; }

        public object Sender { get; set; }
    }
}