//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

#pragma warning disable 1591

using System.Collections.Generic;

namespace Microsoft.IdentityModel.Protocols.WsUtility
{
    public abstract class WsUtilityConstants<T> : WsUtilityConstants where T : new()
    {
        private static T _instance;

        internal static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new T();

                return _instance;
            }
        }
    }

    public abstract class WsUtilityConstants : WsConstantsBase
    {
        private static IList<string> _knownNamespaces = null;

        public static IList<string> KnownNamespaces
        {
            get
            {
                if (_knownNamespaces == null)
                    _knownNamespaces = new List<string> { "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" };

                return _knownNamespaces;
            }
        }

        public static WsUtility10Constants WsUtility10 => WsUtility10Constants.Instance;

        public WsUtilityConstants() { }
    }

    public class WsUtility10Constants : WsUtilityConstants<WsUtility10Constants>
    {

        public WsUtility10Constants()
        {
            Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
            Prefix = "wsu";
        }
    }
}
 
