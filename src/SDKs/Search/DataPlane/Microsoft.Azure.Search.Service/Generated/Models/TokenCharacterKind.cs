// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TokenCharacterKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenCharacterKind
    {
        [EnumMember(Value = "letter")]
        Letter,
        [EnumMember(Value = "digit")]
        Digit,
        [EnumMember(Value = "whitespace")]
        Whitespace,
        [EnumMember(Value = "punctuation")]
        Punctuation,
        [EnumMember(Value = "symbol")]
        Symbol
    }
    internal static class TokenCharacterKindEnumExtension
    {
        internal static string ToSerializedValue(this TokenCharacterKind? value)
        {
            return value == null ? null : ((TokenCharacterKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TokenCharacterKind value)
        {
            switch( value )
            {
                case TokenCharacterKind.Letter:
                    return "letter";
                case TokenCharacterKind.Digit:
                    return "digit";
                case TokenCharacterKind.Whitespace:
                    return "whitespace";
                case TokenCharacterKind.Punctuation:
                    return "punctuation";
                case TokenCharacterKind.Symbol:
                    return "symbol";
            }
            return null;
        }

        internal static TokenCharacterKind? ParseTokenCharacterKind(this string value)
        {
            switch( value )
            {
                case "letter":
                    return TokenCharacterKind.Letter;
                case "digit":
                    return TokenCharacterKind.Digit;
                case "whitespace":
                    return TokenCharacterKind.Whitespace;
                case "punctuation":
                    return TokenCharacterKind.Punctuation;
                case "symbol":
                    return TokenCharacterKind.Symbol;
            }
            return null;
        }
    }
}
