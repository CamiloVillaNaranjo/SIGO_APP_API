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
    public class PorfolioApiController : Controller
    { 

        /// <summary>
        /// Verifies that the status of the current relationship between receiver and emitter.
        /// </summary>
        /// <remarks>From an RFC emsior - RFC receptor relationship is queried whether the relationship is in tests or production.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="numberReceiver">References to the RFC of Receiver</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{numberEmitter}/getRelationStatus")]
        [SwaggerOperation("GetRelationStatus")]
        [SwaggerResponse(200, type: typeof(RelationShips))]
        public virtual IActionResult GetRelationStatus([FromQuery]string country, [FromRoute]string numberEmitter, [FromQuery]string numberReceiver)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RelationShips>(exampleJson)
            : default(RelationShips);
            return new ObjectResult(example);
        }


        /// <summary>
        /// List of complements purchased by the Emitter.
        /// </summary>
        /// <remarks>Complements purchased. This option lets you know which add-ons are configured for the client and must be enabled within facturizate</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{numberEmitter}")]
        [SwaggerOperation("PortfolioNumberEmitterGet")]
        [SwaggerResponse(200, type: typeof(Complements))]
        public virtual IActionResult PortfolioNumberEmitterGet([FromQuery]string country, [FromRoute]string numberEmitter)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Complements>(exampleJson)
            : default(Complements);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Return the service catalog
        /// </summary>
        /// <remarks>Consultation by RFC Issuer of contracted services</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="serviceType">Optional - references to the posible type of services contracted by Issuer</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{numberEmitter}/portfolios")]
        [SwaggerOperation("PortfolioNumberEmitterPortfoliosGet")]
        [SwaggerResponse(200, type: typeof(Portfolios))]
        public virtual IActionResult PortfolioNumberEmitterPortfoliosGet([FromQuery]string country, [FromRoute]string numberEmitter, [FromQuery]string serviceType)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Portfolios>(exampleJson)
            : default(Portfolios);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Inform to the system the purchase of an add-on.
        /// </summary>
        /// <remarks>this method is used to inform the system of a purchased add-on.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="code">References to the Code of the add-on.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{numberEmitter}")]
        [SwaggerOperation("PortfolioNumberEmitterPost")]
        [SwaggerResponse(200, type: typeof(Complements))]
        public virtual IActionResult PortfolioNumberEmitterPost([FromQuery]string country, [FromRoute]string numberEmitter, [FromQuery]string code)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Complements>(exampleJson)
            : default(Complements);
            return new ObjectResult(example);
        }
    }
}
