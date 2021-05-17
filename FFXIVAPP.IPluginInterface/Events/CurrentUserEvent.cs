// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CurrentUserEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   CurrentUserEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using Sharlayan.Core;

    public class CurrentUserEvent : EventArgs {
        public CurrentUserEvent(object sender, ActorItem currentUser) {
            this.Sender = sender;
            this.CurrentUser = currentUser;
        }

        public ActorItem CurrentUser { get; set; }

        public object Sender { get; set; }
    }
}