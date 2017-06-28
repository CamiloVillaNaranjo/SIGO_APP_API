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
    public partial class Portfolios :  IEquatable<Portfolios>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Portfolios" /> class.
        /// </summary>
        /// <param name="AgreementsOwned">AgreementsOwned.</param>
        /// <param name="ComplementsContracted">ComplementsContracted.</param>
        /// <param name="PaperSheetsOwned">PaperSheetsOwned.</param>
        public Portfolios(List<Agreements> AgreementsOwned = null, List<Complements> ComplementsContracted = null, List<Billings> PaperSheetsOwned = null)
        {
            this.AgreementsOwned = AgreementsOwned;
            this.ComplementsContracted = ComplementsContracted;
            this.PaperSheetsOwned = PaperSheetsOwned;
            
        }

        /// <summary>
        /// Gets or Sets AgreementsOwned
        /// </summary>
        [DataMember(Name="AgreementsOwned")]
        public List<Agreements> AgreementsOwned { get; set; }

        /// <summary>
        /// Gets or Sets ComplementsContracted
        /// </summary>
        [DataMember(Name="ComplementsContracted")]
        public List<Complements> ComplementsContracted { get; set; }

        /// <summary>
        /// Gets or Sets PaperSheetsOwned
        /// </summary>
        [DataMember(Name="PaperSheetsOwned")]
        public List<Billings> PaperSheetsOwned { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Portfolios {\n");
            sb.Append("  AgreementsOwned: ").Append(AgreementsOwned).Append("\n");
            sb.Append("  ComplementsContracted: ").Append(ComplementsContracted).Append("\n");
            sb.Append("  PaperSheetsOwned: ").Append(PaperSheetsOwned).Append("\n");
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
            return Equals((Portfolios)obj);
        }

        /// <summary>
        /// Returns true if Portfolios instances are equal
        /// </summary>
        /// <param name="other">Instance of Portfolios to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Portfolios other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.AgreementsOwned == other.AgreementsOwned ||
                    this.AgreementsOwned != null &&
                    this.AgreementsOwned.SequenceEqual(other.AgreementsOwned)
                ) && 
                (
                    this.ComplementsContracted == other.ComplementsContracted ||
                    this.ComplementsContracted != null &&
                    this.ComplementsContracted.SequenceEqual(other.ComplementsContracted)
                ) && 
                (
                    this.PaperSheetsOwned == other.PaperSheetsOwned ||
                    this.PaperSheetsOwned != null &&
                    this.PaperSheetsOwned.SequenceEqual(other.PaperSheetsOwned)
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
                if (this.AgreementsOwned != null)
                    hash = hash * 59 + this.AgreementsOwned.GetHashCode();
                if (this.ComplementsContracted != null)
                    hash = hash * 59 + this.ComplementsContracted.GetHashCode();
                if (this.PaperSheetsOwned != null)
                    hash = hash * 59 + this.PaperSheetsOwned.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Portfolios left, Portfolios right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Portfolios left, Portfolios right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
