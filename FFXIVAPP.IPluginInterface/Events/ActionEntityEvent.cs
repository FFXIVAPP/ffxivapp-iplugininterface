﻿// FFXIVAPP.IPluginInterface ~ ActionEntityEvent.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
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
using System.Collections.Generic;
using Sharlayan.Core;

namespace FFXIVAPP.IPluginInterface.Events
{
    public class ActionEntityEvent : EventArgs
    {
        public ActionEntityEvent(object sender, List<ActionEntity> actionEntities)
        {
            Sender = sender;
            ActionEntities = actionEntities;
        }

        public object Sender { get; set; }
        public List<ActionEntity> ActionEntities { get; set; }
    }
}