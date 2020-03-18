// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class AutocompleteModeExtensions
    {
        public static string ToSerialString(this AutocompleteMode value) => value switch
        {
            AutocompleteMode.OneTerm => "oneTerm",
            AutocompleteMode.TwoTerms => "twoTerms",
            AutocompleteMode.OneTermWithContext => "oneTermWithContext",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutocompleteMode value.")
        };

        public static AutocompleteMode ToAutocompleteMode(this string value)
        {
            if (string.Equals(value, "oneTerm", StringComparison.InvariantCultureIgnoreCase)) return AutocompleteMode.OneTerm;
            if (string.Equals(value, "twoTerms", StringComparison.InvariantCultureIgnoreCase)) return AutocompleteMode.TwoTerms;
            if (string.Equals(value, "oneTermWithContext", StringComparison.InvariantCultureIgnoreCase)) return AutocompleteMode.OneTermWithContext;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutocompleteMode value.");
        }
    }
}