// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActorItemsAddedEvent.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ActorItemsAddedEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;
    using System.Collections.Concurrent;

    using Sharlayan.Core;

    public class ActorItemsAddedEvent : EventArgs {
        public ActorItemsAddedEvent(object sender, ConcurrentDictionary<uint, ActorItem> actorItems) {
            this.Sender = sender;
            this.ActorItems = actorItems;
        }

        public ConcurrentDictionary<uint, ActorItem> ActorItems { get; set; }

        public object Sender { get; set; }
    }
}