// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryContainersEvent.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   InventoryContainersEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;
    using System.Collections.Generic;

    using Sharlayan.Core;

    public class InventoryContainersEvent : EventArgs {
        public InventoryContainersEvent(object sender, List<InventoryContainer> inventoryContainers) {
            this.Sender = sender;
            this.InventoryContainers = inventoryContainers;
        }

        public List<InventoryContainer> InventoryContainers { get; set; }

        public object Sender { get; set; }
    }
}