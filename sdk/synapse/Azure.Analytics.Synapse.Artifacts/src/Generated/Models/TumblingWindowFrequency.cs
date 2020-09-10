// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Enumerates possible frequency option for the tumbling window trigger. </summary>
    public readonly partial struct TumblingWindowFrequency : IEquatable<TumblingWindowFrequency>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TumblingWindowFrequency"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TumblingWindowFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MinuteValue = "Minute";
        private const string HourValue = "Hour";

        /// <summary> Minute. </summary>
        public static TumblingWindowFrequency Minute { get; } = new TumblingWindowFrequency(MinuteValue);
        /// <summary> Hour. </summary>
        public static TumblingWindowFrequency Hour { get; } = new TumblingWindowFrequency(HourValue);
        /// <summary> Determines if two <see cref="TumblingWindowFrequency"/> values are the same. </summary>
        public static bool operator ==(TumblingWindowFrequency left, TumblingWindowFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TumblingWindowFrequency"/> values are not the same. </summary>
        public static bool operator !=(TumblingWindowFrequency left, TumblingWindowFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TumblingWindowFrequency"/>. </summary>
        public static implicit operator TumblingWindowFrequency(string value) => new TumblingWindowFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TumblingWindowFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TumblingWindowFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}