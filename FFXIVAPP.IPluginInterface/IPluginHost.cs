// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPluginHost.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   IPluginHost.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface {
    using System;

    using FFXIVAPP.Common.Models;
    using FFXIVAPP.IPluginInterface.Events;

    public interface IPluginHost {
        event EventHandler<ActionContainersEvent> ActionContainersUpdated;

        event EventHandler<ChatLogItemEvent> ChatLogItemReceived;

        event EventHandler<ConstantsEntityEvent> ConstantsUpdated;

        event EventHandler<CurrentPlayerEvent> CurrentPlayerUpdated;

        event EventHandler<InventoryContainersEvent> InventoryContainersUpdated;

        event EventHandler<ActorItemsAddedEvent> MonsterItemsAdded;

        event EventHandler<ActorItemsRemovedEvent> MonsterItemsRemoved;

        event EventHandler<ActorItemsEvent> MonsterItemsUpdated;

        event EventHandler<NetworkPacketEvent> NetworkPacketReceived;

        event EventHandler<ActorItemsAddedEvent> NPCItemsAdded;

        event EventHandler<ActorItemsRemovedEvent> NPCItemsRemoved;

        event EventHandler<ActorItemsEvent> NPCItemsUpdated;

        event EventHandler<PartyMembersAddedEvent> PartyMembersAdded;

        event EventHandler<PartyMembersRemovedEvent> PartyMembersRemoved;

        event EventHandler<PartyMembersEvent> PartyMembersUpdated;

        event EventHandler<ActorItemsAddedEvent> PCItemsAdded;

        event EventHandler<ActorItemsRemovedEvent> PCItemsRemoved;

        event EventHandler<ActorItemsEvent> PCItemsUpdated;

        event EventHandler<TargetInfoEvent> TargetInfoUpdated;

        void PopupMessage(string pluginName, PopupContent content);
    }
}