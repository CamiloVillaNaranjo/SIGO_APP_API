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
    public class BillingsApiController : Controller
    { 

        /// <summary>
        /// Shows the quantity of sheets are available for the Emitter
        /// </summary>
        /// <remarks>Folios available. Lets know how many sheets are available on the platform</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/billing/{numberEmitter}")]
        [SwaggerOperation("BillingNumberEmitterGet")]
        [SwaggerResponse(200, type: typeof(Billings))]
        public virtual IActionResult BillingNumberEmitterGet([FromQuery]string country, [FromRoute]string numberEmitter)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Billings>(exampleJson)
            : default(Billings);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Inform SIGO about the use of a folio
        /// </summary>
        /// <remarks>Inform SIGO about the use of a folio (decrease the already existing quantity in the system)</remarks>
        /// <param name="numberEmitter">References to RFC of Emitter.</param>
        /// <param name="body">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="opType">Especifies if increase or decrease the quantity of folios (IN &#x3D; Increase; OUT &#x3D; decrease).</param>
        /// <param name="qtySheets">Especifies the quantity to be incremented or decresed to that special emitter in the system.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/cvillanexos/NexosSigostore/beta/billing/{numberEmitter}")]
        [SwaggerOperation("BillingNumberEmitterPatch")]
        public virtual void BillingNumberEmitterPatch([FromRoute]string numberEmitter, [FromBody]Billings body, [FromQuery]string opType, [FromQuery]int? qtySheets)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Inform SIGO about the purchased folios
        /// </summary>
        /// <remarks>This procedure must add the purchased quantity of folios the already existing in the SIGO app.</remarks>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/billing/{numberEmitter}")]
        [SwaggerOperation("BillingNumberEmitterPost")]
        public virtual void BillingNumberEmitterPost()
        { 
            throw new NotImplementedException();
        }
    }
}
