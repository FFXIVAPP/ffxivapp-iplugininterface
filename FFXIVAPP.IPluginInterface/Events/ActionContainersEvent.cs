// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionContainersEvent.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ActionContainersEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;
    using System.Collections.Generic;

    using Sharlayan.Core;

    public class ActionContainersEvent : EventArgs {
        public ActionContainersEvent(object sender, List<ActionContainer> actionContainers) {
            this.Sender = sender;
            this.ActionContainers = actionContainers;
        }

        public List<ActionContainer> ActionContainers { get; set; }

        public object Sender { get; set; }
    }
}