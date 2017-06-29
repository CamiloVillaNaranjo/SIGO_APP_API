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
    public partial class LoginCredentials :  IEquatable<LoginCredentials>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCredentials" /> class.
        /// </summary>
        /// <param name="UserName">UserName.</param>
        /// <param name="UserPassword">UserPassword.</param>
        /// <param name="UserCountry">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)..</param>
        public LoginCredentials(string UserName = null, string UserPassword = null, string UserCountry = null)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserCountry = UserCountry;
            
        }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets UserPassword
        /// </summary>
        [DataMember(Name="userPassword")]
        public string UserPassword { get; set; }

        /// <summary>
        /// Refrences to the country that will use the web service (meanwhile only MX is allowed to consume).
        /// </summary>
        /// <value>Refrences to the country that will use the web service (meanwhile only MX is allowed to consume).</value>
        [DataMember(Name="userCountry")]
        public string UserCountry { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginCredentials {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  UserCountry: ").Append(UserCountry).Append("\n");
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
            return Equals((LoginCredentials)obj);
        }

        /// <summary>
        /// Returns true if LoginCredentials instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginCredentials other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.UserPassword == other.UserPassword ||
                    this.UserPassword != null &&
                    this.UserPassword.Equals(other.UserPassword)
                ) && 
                (
                    this.UserCountry == other.UserCountry ||
                    this.UserCountry != null &&
                    this.UserCountry.Equals(other.UserCountry)
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
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.UserPassword != null)
                    hash = hash * 59 + this.UserPassword.GetHashCode();
                if (this.UserCountry != null)
                    hash = hash * 59 + this.UserCountry.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(LoginCredentials left, LoginCredentials right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoginCredentials left, LoginCredentials right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}