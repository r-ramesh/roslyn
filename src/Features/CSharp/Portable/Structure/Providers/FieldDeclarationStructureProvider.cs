﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Structure;

namespace Microsoft.CodeAnalysis.CSharp.Structure
{
    internal class FieldDeclarationStructureProvider : AbstractSyntaxNodeStructureProvider<FieldDeclarationSyntax>
    {
        protected override void CollectBlockSpans(
            FieldDeclarationSyntax fieldDeclaration,
            ArrayBuilder<BlockSpan> spans,
            BlockStructureOptionProvider optionProvider,
            CancellationToken cancellationToken)
        {
            CSharpStructureHelpers.CollectCommentBlockSpans(fieldDeclaration, spans, optionProvider);
        }
    }
}
