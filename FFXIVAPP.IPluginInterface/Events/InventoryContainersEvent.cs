// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryContainersEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   InventoryContainersEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using Sharlayan.Core;

    public class InventoryContainersEvent : EventArgs {
        public InventoryContainersEvent(object sender, ConcurrentBag<InventoryContainer> inventoryContainers) {
            this.Sender = sender;
            this.InventoryContainers = inventoryContainers;
        }

        public ConcurrentBag<InventoryContainer> InventoryContainers { get; set; }

        public object Sender { get; set; }
    }
}