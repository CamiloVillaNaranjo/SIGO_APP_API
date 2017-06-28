/*
 * Carvajal Sigo-Facturizate
 *
 * Este es un ejemplo de como luciría la Api de Integración entre Facturizate y SIGO.
 *
 * OpenAPI spec version: beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Cities :  IEquatable<Cities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cities" /> class.
        /// </summary>
        /// <param name="CityId">CityId.</param>
        /// <param name="DepertmentId">DepertmentId.</param>
        /// <param name="CityName">CityName.</param>
        public Cities(string CityId = null, string DepertmentId = null, string CityName = null)
        {
            this.CityId = CityId;
            this.DepertmentId = DepertmentId;
            this.CityName = CityName;
            
        }

        /// <summary>
        /// Gets or Sets CityId
        /// </summary>
        [DataMember(Name="cityId")]
        public string CityId { get; set; }

        /// <summary>
        /// Gets or Sets DepertmentId
        /// </summary>
        [DataMember(Name="depertmentId")]
        public string DepertmentId { get; set; }

        /// <summary>
        /// Gets or Sets CityName
        /// </summary>
        [DataMember(Name="cityName")]
        public string CityName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cities {\n");
            sb.Append("  CityId: ").Append(CityId).Append("\n");
            sb.Append("  DepertmentId: ").Append(DepertmentId).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Cities)obj);
        }

        /// <summary>
        /// Returns true if Cities instances are equal
        /// </summary>
        /// <param name="other">Instance of Cities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cities other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CityId == other.CityId ||
                    this.CityId != null &&
                    this.CityId.Equals(other.CityId)
                ) && 
                (
                    this.DepertmentId == other.DepertmentId ||
                    this.DepertmentId != null &&
                    this.DepertmentId.Equals(other.DepertmentId)
                ) && 
                (
                    this.CityName == other.CityName ||
                    this.CityName != null &&
                    this.CityName.Equals(other.CityName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CityId != null)
                    hash = hash * 59 + this.CityId.GetHashCode();
                if (this.DepertmentId != null)
                    hash = hash * 59 + this.DepertmentId.GetHashCode();
                if (this.CityName != null)
                    hash = hash * 59 + this.CityName.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Cities left, Cities right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Cities left, Cities right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
