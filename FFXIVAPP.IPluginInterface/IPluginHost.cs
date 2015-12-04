// FFXIVAPP.IPluginInterface ~ IPluginHost.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using FFXIVAPP.Common.Models;
using FFXIVAPP.IPluginInterface.Events;

namespace FFXIVAPP.IPluginInterface
{
    public interface IPluginHost
    {
        void PopupMessage(string pluginName, PopupContent content);
        event EventHandler<ConstantsEntityEvent> NewConstantsEntity;
        event EventHandler<ChatLogEntryEvent> NewChatLogEntry;
        event EventHandler<ActorEntitiesAddedEvent> NewMonsterEntriesAdded;
        event EventHandler<ActorEntitiesAddedEvent> NewNPCEntriesAdded;
        event EventHandler<ActorEntitiesAddedEvent> NewPCEntriesAdded;
        event EventHandler<ActorEntitiesEvent> NewMonsterEntries;
        event EventHandler<ActorEntitiesEvent> NewNPCEntries;
        event EventHandler<ActorEntitiesEvent> NewPCEntries;
        event EventHandler<ActorEntitiesRemovedEvent> NewMonsterEntriesRemoved;
        event EventHandler<ActorEntitiesRemovedEvent> NewNPCEntriesRemoved;
        event EventHandler<ActorEntitiesRemovedEvent> NewPCEntriesRemoved;
        event EventHandler<PlayerEntityEvent> NewPlayerEntity;
        event EventHandler<TargetEntityEvent> NewTargetEntity;
        event EventHandler<PartyEntitiesAddedEvent> NewPartyEntriesAdded;
        event EventHandler<PartyEntitiesEvent> NewPartyEntries;
        event EventHandler<PartyEntitiesRemovedEvent> NewPartyEntriesRemoved;
        event EventHandler<InventoryEntitiesEvent> NewInventoryEntries;
        event EventHandler<NetworkPacketEvent> NewNetworkPacket;
    }
}
