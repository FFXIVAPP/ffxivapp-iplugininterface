// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PartyMembersEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2020 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   PartyMembersEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;
    using System.Collections.Concurrent;

    using Sharlayan.Core;

    public class PartyMembersEvent : EventArgs {
        public PartyMembersEvent(object sender, ConcurrentDictionary<uint, PartyMember> partyMembers) {
            this.Sender = sender;
            this.PartyMembers = partyMembers;
        }

        public ConcurrentDictionary<uint, PartyMember> PartyMembers { get; set; }

        public object Sender { get; set; }
    }
}