﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActorItemsEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2020 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ActorItemsEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;
    using System.Collections.Concurrent;

    using Sharlayan.Core;

    public class ActorItemsEvent : EventArgs {
        public ActorItemsEvent(object sender, ConcurrentDictionary<uint, ActorItem> actorItems) {
            this.Sender = sender;
            this.ActorItems = actorItems;
        }

        public ConcurrentDictionary<uint, ActorItem> ActorItems { get; set; }

        public object Sender { get; set; }
    }
}