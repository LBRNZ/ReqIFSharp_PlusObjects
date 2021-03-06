﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ReqIFToolExtension.cs" company="RHEA System S.A.">
//
//   Copyright 2017 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace ReqIFSharp
{
    using System.Xml;
    using System.Xml.Serialization;
    
    /// <summary>
    /// The <see cref="ReqIFToolExtension"/> class allows the optional inclusion of tool-specific information into a ReqIF Exchange Document.
    /// </summary>
    public class ReqIFToolExtension : IXmlSerializable
    {
        /// <summary>
        /// Gets or sets the InnerXml of the <see cref="ReqIFToolExtension"/>
        /// </summary>
        public string InnerXml { get; set; }

        /// <summary>
        /// Generates a <see cref="ReqIFContent"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/>
        /// </param>
        public void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    this.InnerXml = reader.ReadInnerXml();
                }
            }
        }

        /// <summary>
        /// Converts a <see cref="ReqIFToolExtension"/> object into its XML representation.
        /// </summary>
        /// <param name="writer">
        /// an instance of <see cref="XmlWriter"/>
        /// </param>
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteRaw(this.InnerXml);
        }

        /// <summary>
        /// This method is reserved and should not be used.
        /// </summary>
        /// <returns>returns null</returns>
        /// <remarks>
        /// When implementing the IXmlSerializable interface, you should return null
        /// </remarks>
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
    }
}
