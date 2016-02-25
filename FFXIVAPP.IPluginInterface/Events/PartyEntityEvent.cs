// FFXIVAPP.IPluginInterface ~ PartyEntityEvent.cs
// 
// Copyright © 2007 - 2016 Ryan Wilson - All Rights Reserved
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
using System.Collections.Concurrent;
using FFXIVAPP.Memory.Core;

namespace FFXIVAPP.IPluginInterface.Events
{
    public class PartyEntitiesEvent : EventArgs
    {
        public PartyEntitiesEvent(object sender, ConcurrentDictionary<UInt32, PartyEntity> partyEntities)
        {
            Sender = sender;
            PartyEntities = partyEntities;
        }

        public object Sender { get; set; }
        public ConcurrentDictionary<UInt32, PartyEntity> PartyEntities { get; set; }
    }
}
