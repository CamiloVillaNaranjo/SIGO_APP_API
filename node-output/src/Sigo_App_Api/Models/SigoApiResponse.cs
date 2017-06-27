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
    public partial class SigoApiResponse :  IEquatable<SigoApiResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigoApiResponse" /> class.
        /// </summary>
        /// <param name="CurrentDatetime">current server date time, at the response moment.</param>
        /// <param name="Code">Identify the response request if it was processed successfully or not, there are codes to identify the error type , that can be classified as Client-User-Error, Client-App-Error or Server-Error.</param>
        /// <param name="Message">Code description, and can contain more details, can be empty or null.</param>
        /// <param name="Data">Data that represents the response to the request, Can be a String, an Array or an Object or can be null.</param>
        public SigoApiResponse(string CurrentDatetime = null, long? Code = null, string Message = null, string Data = null)
        {
            this.CurrentDatetime = CurrentDatetime;
            this.Code = Code;
            this.Message = Message;
            this.Data = Data;
            
        }

        /// <summary>
        /// current server date time, at the response moment
        /// </summary>
        /// <value>current server date time, at the response moment</value>
        [DataMember(Name="currentDatetime")]
        public string CurrentDatetime { get; set; }

        /// <summary>
        /// Identify the response request if it was processed successfully or not, there are codes to identify the error type , that can be classified as Client-User-Error, Client-App-Error or Server-Error
        /// </summary>
        /// <value>Identify the response request if it was processed successfully or not, there are codes to identify the error type , that can be classified as Client-User-Error, Client-App-Error or Server-Error</value>
        [DataMember(Name="code")]
        public long? Code { get; set; }

        /// <summary>
        /// Code description, and can contain more details, can be empty or null
        /// </summary>
        /// <value>Code description, and can contain more details, can be empty or null</value>
        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Data that represents the response to the request, Can be a String, an Array or an Object or can be null
        /// </summary>
        /// <value>Data that represents the response to the request, Can be a String, an Array or an Object or can be null</value>
        [DataMember(Name="data")]
        public string Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigoApiResponse {\n");
            sb.Append("  CurrentDatetime: ").Append(CurrentDatetime).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return Equals((SigoApiResponse)obj);
        }

        /// <summary>
        /// Returns true if SigoApiResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SigoApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigoApiResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CurrentDatetime == other.CurrentDatetime ||
                    this.CurrentDatetime != null &&
                    this.CurrentDatetime.Equals(other.CurrentDatetime)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                if (this.CurrentDatetime != null)
                    hash = hash * 59 + this.CurrentDatetime.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SigoApiResponse left, SigoApiResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SigoApiResponse left, SigoApiResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}