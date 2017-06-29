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
    public class CompanyApiController : Controller
    { 

        /// <summary>
        /// Validates if the RFC is a Client of Carvajal.
        /// </summary>
        /// <remarks>This function is intended to know if the RFC belongs to a Carvajal customer. Used in the migration or registration of clients Carvajal.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to fiscal number of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">username invalid</response>
        /// <response code="404">user not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/company/{numberEmitter}")]
        [SwaggerOperation("CompanyNumberEmitterGet")]
        [SwaggerResponse(200, type: typeof(Companies))]
        public virtual IActionResult CompanyNumberEmitterGet([FromQuery]string country, [FromRoute]string numberEmitter)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Companies>(exampleJson)
            : default(Companies);
            return new ObjectResult(example);
        }


        /// <summary>
        /// PENDING - Architecture team decision. Allows review the CFDI credentials for RFC.
        /// </summary>
        /// <remarks>This in order to be able to carry out the process of letterhead of the documents</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">username invalid</response>
        /// <response code="404">user not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/company/{numberEmitter}/getCFDI")]
        [SwaggerOperation("GetCFDIbyRFC")]
        [SwaggerResponse(200, type: typeof(CfdiCredential))]
        public virtual IActionResult GetCFDIbyRFC([FromQuery]string country, [FromRoute]string numberEmitter)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CfdiCredential>(exampleJson)
            : default(CfdiCredential);
            return new ObjectResult(example);
        }
    }
}
