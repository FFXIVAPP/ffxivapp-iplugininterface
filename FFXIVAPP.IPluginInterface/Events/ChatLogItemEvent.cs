// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatLogItemEvent.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ChatLogItemEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using Sharlayan.Core;

    public class ChatLogItemEvent : EventArgs {
        public ChatLogItemEvent(object sender, in ChatLogItem chatLogItem) {
            this.Sender = sender;
            this.ChatLogItem = chatLogItem;
        }

        public ChatLogItem ChatLogItem { get; set; }

        public object Sender { get; set; }
    }
}