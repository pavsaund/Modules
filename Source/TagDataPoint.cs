/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Dolittle.TimeSeries.Modules
{
    /// <summary>
    /// Represents an data point for a <see cref="Tag"/> on a <see cref="ControlSystem"/>
    /// </summary>
    public class TagDataPoint<TValue>
    {
        /// <summary>
        /// Gets or sets the <see cref="ControlSystem"/> this value belong to
        /// </summary>
        public ControlSystem ControlSystem { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Tag"/> this value belong to
        /// </summary>
        public Tag Tag { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public TValue Value { get; set; }

        /// <summary>
        /// Gets or sets the timestamp in the form of EPOCH milliseconds granularity
        /// </summary>
        public Timestamp Timestamp { get; set; }
    }
}