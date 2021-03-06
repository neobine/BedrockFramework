// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Bedrock.Framework.Protocols.Http2.HPack
{
    internal sealed class HuffmanDecodingException : Exception
    {
        public HuffmanDecodingException(string message)
            : base(message)
        {
        }
    }
}
