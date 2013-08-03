﻿//=============================================================================
//
// Copyright (C) 2013 Michael Coyle, Blue Toque
// http://www.BlueToque.ca/Products/XmlGridControl2.html
// michael.coyle@BlueToque.ca
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// http://www.gnu.org/licenses/gpl.txt
//
//=============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeGeneration.CodeModifiers;
using BlueToque.XmlLibrary.CodeModifiers.Schemas;
using System.CodeDom;

namespace BlueToque.XmlLibrary.CodeModifiers
{
    class BrowsableProperty : BaseCodeModifier
    {
        BrowsablePropertyOptions m_options;

        public BrowsablePropertyOptions Options
        {
            get
            {
                if (m_options == null)
                    m_options = GetOptions<BrowsablePropertyOptions>();
                return m_options;
            }
        }

        #region ICodeModifier Members
        public override void Execute(CodeNamespace codeNamespace)
        {
            if (Options == null || Options.Property == null || Options.Property.Count == 0)
                return;

            // foreach datatype in the codeNamespace
            foreach (CodeTypeDeclaration type in codeNamespace.Types)
            {
                // if the qualified name doesn't start with the name of the class, continue.
                PropertyType propertyType = Options.Property.Find(x => x.QualifiedName.StartsWith(type.Name));
                if (propertyType == null)
                    continue;

                // for each property in the type
                foreach (CodeTypeMember member in type.Members)
                {
                    if (!(member is CodeMemberProperty))
                        continue;

                    CodeMemberProperty property = (member as CodeMemberProperty);
                    if (propertyType.QualifiedName.EndsWith(property.Name) ||
                        propertyType.QualifiedName.EndsWith("*"))
                    {
                        // add the custom type editor attribute
                        CodeAttributeDeclaration attr = new CodeAttributeDeclaration("System.ComponentModel.Browsable");
                        attr.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(false)));
                        property.CustomAttributes.Add(attr);
                    }
                }
            }
        }

        #endregion
    }
}
