// Licensed under the MIT License.
// Copyright (C) 2018 Jumar A. Macato, All Rights Reserved.

using System;

namespace Avalonia.Gif.Decoding;

[Serializable]
public class InvalidGifStreamException : Exception
{
    public InvalidGifStreamException(string message) : base(message)
    {
    }
}