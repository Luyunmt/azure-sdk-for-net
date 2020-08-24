// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> The error code. </summary>
    public readonly partial struct AnomalyDetectorErrorCodes : IEquatable<AnomalyDetectorErrorCodes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AnomalyDetectorErrorCodes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnomalyDetectorErrorCodes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidCustomIntervalValue = "InvalidCustomInterval";
        private const string BadArgumentValue = "BadArgument";
        private const string InvalidGranularityValue = "InvalidGranularity";
        private const string InvalidPeriodValue = "InvalidPeriod";
        private const string InvalidModelArgumentValue = "InvalidModelArgument";
        private const string InvalidSeriesValue = "InvalidSeries";
        private const string InvalidJsonFormatValue = "InvalidJsonFormat";
        private const string RequiredGranularityValue = "RequiredGranularity";
        private const string RequiredSeriesValue = "RequiredSeries";

        /// <summary> InvalidCustomInterval. </summary>
        public static AnomalyDetectorErrorCodes InvalidCustomInterval { get; } = new AnomalyDetectorErrorCodes(InvalidCustomIntervalValue);
        /// <summary> BadArgument. </summary>
        public static AnomalyDetectorErrorCodes BadArgument { get; } = new AnomalyDetectorErrorCodes(BadArgumentValue);
        /// <summary> InvalidGranularity. </summary>
        public static AnomalyDetectorErrorCodes InvalidGranularity { get; } = new AnomalyDetectorErrorCodes(InvalidGranularityValue);
        /// <summary> InvalidPeriod. </summary>
        public static AnomalyDetectorErrorCodes InvalidPeriod { get; } = new AnomalyDetectorErrorCodes(InvalidPeriodValue);
        /// <summary> InvalidModelArgument. </summary>
        public static AnomalyDetectorErrorCodes InvalidModelArgument { get; } = new AnomalyDetectorErrorCodes(InvalidModelArgumentValue);
        /// <summary> InvalidSeries. </summary>
        public static AnomalyDetectorErrorCodes InvalidSeries { get; } = new AnomalyDetectorErrorCodes(InvalidSeriesValue);
        /// <summary> InvalidJsonFormat. </summary>
        public static AnomalyDetectorErrorCodes InvalidJsonFormat { get; } = new AnomalyDetectorErrorCodes(InvalidJsonFormatValue);
        /// <summary> RequiredGranularity. </summary>
        public static AnomalyDetectorErrorCodes RequiredGranularity { get; } = new AnomalyDetectorErrorCodes(RequiredGranularityValue);
        /// <summary> RequiredSeries. </summary>
        public static AnomalyDetectorErrorCodes RequiredSeries { get; } = new AnomalyDetectorErrorCodes(RequiredSeriesValue);
        /// <summary> Determines if two <see cref="AnomalyDetectorErrorCodes"/> values are the same. </summary>
        public static bool operator ==(AnomalyDetectorErrorCodes left, AnomalyDetectorErrorCodes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnomalyDetectorErrorCodes"/> values are not the same. </summary>
        public static bool operator !=(AnomalyDetectorErrorCodes left, AnomalyDetectorErrorCodes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnomalyDetectorErrorCodes"/>. </summary>
        public static implicit operator AnomalyDetectorErrorCodes(string value) => new AnomalyDetectorErrorCodes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnomalyDetectorErrorCodes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnomalyDetectorErrorCodes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}