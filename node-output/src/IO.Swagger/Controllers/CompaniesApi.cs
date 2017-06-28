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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CompaniesApiController : Controller
    { 

        /// <summary>
        /// Validates if the RFC is a Client of Carvajal.
        /// </summary>
        /// <remarks>This function is intended to know if the RFC belongs to a Carvajal customer. Used in the migration or registration of clients Carvajal.</remarks>
        /// <param name="rfcEmitter">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">username invalid</response>
        /// <response code="404">user not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/companies/{rfcEmitter}")]
        [SwaggerOperation("CompaniesRfcEmitterGet")]
        [SwaggerResponse(200, type: typeof(Companies))]
        public virtual IActionResult CompaniesRfcEmitterGet([FromRoute]string rfcEmitter)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Companies>(exampleJson)
            : default(Companies);
            return new ObjectResult(example);
        }


        /// <summary>
        /// allows review the CFDI credentials for RFC.
        /// </summary>
        /// <remarks>This in order to be able to carry out the process of letterhead of the documents</remarks>
        /// <param name="rfcEmitter">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">username invalid</response>
        /// <response code="404">user not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/companies/{rfcEmitter}/getCfdiCredentials")]
        [SwaggerOperation("CompaniesRfcEmitterGetCfdiCredentialsGet")]
        [SwaggerResponse(200, type: typeof(CfdiCredential))]
        public virtual IActionResult CompaniesRfcEmitterGetCfdiCredentialsGet([FromRoute]string rfcEmitter)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CfdiCredential>(exampleJson)
            : default(CfdiCredential);
            return new ObjectResult(example);
        }


        /// <summary>
        /// verifies that the status of the current relationship between receiver and emitter.
        /// </summary>
        /// <remarks>From an RFC emsior - RFC receptor relationship is queried whether the relationship is in tests or production.</remarks>
        /// <param name="rfcEmitter">References to RFC of Emitter.</param>
        /// <param name="rfcReceiver">References to the RFC of Receiver</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/companies/{rfcEmitter}/relationships/{rfcReceiver}")]
        [SwaggerOperation("CompaniesRfcEmitterRelationshipsRfcReceiverGet")]
        [SwaggerResponse(200, type: typeof(RelationShips))]
        public virtual IActionResult CompaniesRfcEmitterRelationshipsRfcReceiverGet([FromRoute]string rfcEmitter, [FromRoute]string rfcReceiver)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RelationShips>(exampleJson)
            : default(RelationShips);
            return new ObjectResult(example);
        }
    }
}
