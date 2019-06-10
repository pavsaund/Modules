/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Dolittle.TimeSeries.Modules
{
    /// <summary>
    /// Defines a system that is in charge of managing <see cref="IAmAPassiveConnector">passive connectors</see>
    /// </summary>
    public interface IPassiveConnectors
    {
        /// <summary>
        /// Start all connectors
        /// </summary>
        void Start();
    }
}