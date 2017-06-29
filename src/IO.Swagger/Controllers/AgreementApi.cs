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
    public class AgreementApiController : Controller
    { 

        /// <summary>
        /// List of addendums acquired by the Emitter.
        /// </summary>
        /// <remarks>Addendums acquired. This option lets you know which add-ons are configured for the client and must be enabled within facturizate.</remarks>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume).</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/Agreement/{numberEmitter}")]
        [SwaggerOperation("AgreementNumberEmitterGet")]
        [SwaggerResponse(200, type: typeof(Agreements))]
        public virtual IActionResult AgreementNumberEmitterGet([FromRoute]string numberEmitter, [FromQuery]string country)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Agreements>(exampleJson)
            : default(Agreements);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Allows you to create an Addendum
        /// </summary>
        /// <remarks>That should create the business relationship and inherit the attributes of the purchased addendum. That is, if the addendum indicates that it requires implementation, the relationship in test status must be created.</remarks>
        /// <param name="body">Addendum object to be added inside the system.</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume).</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid operation</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/Agreement/{numberEmitter}")]
        [SwaggerOperation("AgreementNumberEmitterPost")]
        public virtual void AgreementNumberEmitterPost([FromBody]Agreements body, [FromRoute]string numberEmitter, [FromQuery]string country)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Inform SIGO about the addendum acquired
        /// </summary>
        /// <remarks>That should create the business relationship and inherit the attributes of the purchased addendum. That is, if the addendum indicates that it requires implementation, the relationship in test status must be created.</remarks>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="body">Addendum object to be added inside the system.</param>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid operation</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/Agreement/{numberEmitter}/set")]
        [SwaggerOperation("AgreementNumberEmitterSetPost")]
        [SwaggerResponse(200, type: typeof(Agreements))]
        public virtual IActionResult AgreementNumberEmitterSetPost([FromRoute]string numberEmitter, [FromBody]Agreements body, [FromQuery]string country)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Agreements>(exampleJson)
            : default(Agreements);
            return new ObjectResult(example);
        }
    }
}
