/*
   Copyright 2011 Microsoft Corp.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

*/

/*******************************************************************************
 *  AWS SDK for WP7
 */

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Sets an attribute of a queue. Currently, you can set only one attribute per request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2009-02-01/", IsNullable = false)]
    public class SetQueueAttributesRequest
    {
        private string queueUrlField;
        private List<Attribute> attributes;

        /// <summary>
        /// Gets and sets the QueueUrl property.
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the QueueUrl property
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public SetQueueAttributesRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// Gets the Attribute property.
        /// Name and value pair of an attribute associated with the queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public List<Attribute> Attribute
        {
            get
            {
                if (this.attributes == null)
                {
                    this.attributes = new List<Attribute>();
                }
                return this.attributes;
            }
        }

        /// <summary>
        /// Sets the Attribute property
        /// </summary>
        /// <param name="list">Name and value pair of an attribute associated with the queue.</param>
        /// <returns>this instance</returns>
        public SetQueueAttributesRequest WithAttribute(params Attribute[] list)
        {
            foreach (Attribute item in list)
            {
                Attribute.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return (Attribute.Count > 0);
        }

    }
}
