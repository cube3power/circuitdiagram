﻿// DocumentLoadResult.cs
//
// Circuit Diagram http://www.circuit-diagram.org/
//
// Copyright (C) 2012  Sam Fisher
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircuitDiagram.IO
{
    /// <summary>
    /// Holds information about the load operation of a document.
    /// </summary>
    public class DocumentLoadResult
    {
        /// <summary>
        /// The type of result.
        /// </summary>
        public DocumentLoadResultType Type { get; set; }

        /// <summary>
        /// The file format of the document.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// A list of errors that occurred while loading.
        /// </summary>
        public List<string> Errors { get; private set; }

        /// <summary>
        /// Creates a new DocumentLoadResult.
        /// </summary>
        public DocumentLoadResult()
        {
            Type = DocumentLoadResultType.None;
            Errors = new List<string>();
        }
    }
}