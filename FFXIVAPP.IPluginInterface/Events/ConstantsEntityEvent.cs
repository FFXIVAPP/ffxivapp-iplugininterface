// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstantsEntityEvent.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ConstantsEntityEvent.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.IPluginInterface.Events {
    using System;

    using FFXIVAPP.Common.Core.Constant;

    public class ConstantsEntityEvent : EventArgs {
        public ConstantsEntityEvent(object sender, ConstantsEntity constantsEntity) {
            this.Sender = sender;
            this.ConstantsEntity = constantsEntity;
        }

        public ConstantsEntity ConstantsEntity { get; set; }

        public object Sender { get; set; }
    }
}