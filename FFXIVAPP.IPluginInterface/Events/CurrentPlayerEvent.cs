// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CurrentPlayerEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   CurrentPlayerEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using Sharlayan.Core;

    public class CurrentPlayerEvent : EventArgs {
        public CurrentPlayerEvent(object sender, CurrentPlayer currentPlayer) {
            this.Sender = sender;
            this.CurrentPlayer = currentPlayer;
        }

        public CurrentPlayer CurrentPlayer { get; set; }

        public object Sender { get; set; }
    }
}