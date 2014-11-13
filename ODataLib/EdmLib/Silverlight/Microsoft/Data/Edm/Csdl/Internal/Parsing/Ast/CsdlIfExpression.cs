//   OData .NET Libraries ver. 5.6.3
//   Copyright (c) Microsoft Corporation
//   All rights reserved. 
//   MIT License
//   Permission is hereby granted, free of charge, to any person obtaining a copy of
//   this software and associated documentation files (the "Software"), to deal in
//   the Software without restriction, including without limitation the rights to use,
//   copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
//   Software, and to permit persons to whom the Software is furnished to do so,
//   subject to the following conditions:

//   The above copyright notice and this permission notice shall be included in all
//   copies or substantial portions of the Software.

//   THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
//   FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
//   COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
//   IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//   CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Data.Edm.Csdl.Internal.Parsing.Ast
{
    internal class CsdlIfExpression : CsdlExpressionBase
    {
        private readonly CsdlExpressionBase test;
        private readonly CsdlExpressionBase ifTrue;
        private readonly CsdlExpressionBase ifFalse;

        public CsdlIfExpression(CsdlExpressionBase test, CsdlExpressionBase ifTrue, CsdlExpressionBase ifFalse, CsdlLocation location)
            : base(location)
        {
            this.test = test;
            this.ifTrue = ifTrue;
            this.ifFalse = ifFalse;
        }

        public override Expressions.EdmExpressionKind ExpressionKind
        {
            get { return Expressions.EdmExpressionKind.If; }
        }

        public CsdlExpressionBase Test
        {
            get { return this.test; }
        }

        public CsdlExpressionBase IfTrue
        {
            get { return this.ifTrue; }
        }

        public CsdlExpressionBase IfFalse
        {
            get { return this.ifFalse; }
        }
    }
}