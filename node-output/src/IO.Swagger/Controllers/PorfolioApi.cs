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
        /// List of addendums acquired by the Emitter.
        /// </summary>
        /// <remarks>Addendums acquired. This option lets you know which add-ons are configured for the client and must be enabled within facturizate.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/agreements")]
        [SwaggerOperation("PortfolioCountryAgreementsGet")]
        [SwaggerResponse(200, type: typeof(Billings))]
        public virtual IActionResult PortfolioCountryAgreementsGet([FromRoute]string country, [FromQuery]string emitterNumber)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Billings>(exampleJson)
            : default(Billings);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Allows you to create an Addendum
        /// </summary>
        /// <remarks>That should create the business relationship and inherit the attributes of the purchased addendum. That is, if the addendum indicates that it requires implementation, the relationship in test status must be created.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <param name="body">Addendum object to be added inside the system.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid operation</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/agreements")]
        [SwaggerOperation("PortfolioCountryAgreementsPost")]
        public virtual void PortfolioCountryAgreementsPost([FromRoute]string country, [FromQuery]string emitterNumber, [FromBody]Billings body)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// shows the quantity of sheets are available for the Emitter
        /// </summary>
        /// <remarks>Folios available. Lets know how many sheets are available on the platform</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/billings")]
        [SwaggerOperation("PortfolioCountryBillingsGet")]
        [SwaggerResponse(200, type: typeof(Billings))]
        public virtual IActionResult PortfolioCountryBillingsGet([FromRoute]string country, [FromQuery]string emitterNumber)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Billings>(exampleJson)
            : default(Billings);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Increases or decreases the quantity of folios avalibles
        /// </summary>
        /// <remarks>This method unifies the operation of inform when a folio was used, and when a quantity of folios was purchased.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <param name="opType">Especifies if increase or decrease the quantity of folios (IN &#x3D; Increase; OUT &#x3D; decrease).</param>
        /// <param name="qtySheets">Especifies the quantity to be incremented or decresed to that special emitter in the system.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/billings")]
        [SwaggerOperation("PortfolioCountryBillingsPatch")]
        public virtual void PortfolioCountryBillingsPatch([FromRoute]string country, [FromQuery]string emitterNumber, [FromQuery]string opType, [FromQuery]int? qtySheets)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// list of complements purchased by the Emitter.
        /// </summary>
        /// <remarks>Complements purchased. This option lets you know which add-ons are configured for the client and must be enabled within facturizate</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/complements")]
        [SwaggerOperation("PortfolioCountryComplementsGet")]
        [SwaggerResponse(200, type: typeof(Complements))]
        public virtual IActionResult PortfolioCountryComplementsGet([FromRoute]string country, [FromQuery]string emitterNumber)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Complements>(exampleJson)
            : default(Complements);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Inform the system of a purchased add-on.
        /// </summary>
        /// <remarks>this method is used to inform the system of a purchased add-on.</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <param name="code">References to the Code of the add-on.</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/complements")]
        [SwaggerOperation("PortfolioCountryComplementsPost")]
        [SwaggerResponse(200, type: typeof(Complements))]
        public virtual IActionResult PortfolioCountryComplementsPost([FromRoute]string country, [FromQuery]string emitterNumber, [FromQuery]string code)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Complements>(exampleJson)
            : default(Complements);
            return new ObjectResult(example);
        }


        /// <summary>
        /// return the service catalog
        /// </summary>
        /// <remarks>Consultation by RFC Issuer of contracted services</remarks>
        /// <param name="country">Refrences to the country that will use the web service (meanwhile only MX is allowed to consume)</param>
        /// <param name="emitterNumber">References to RFC of Emitter.</param>
        /// <param name="serviceType">Optional - references to the posible type of services contracted by Issuer</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/portfolio/{country}/portfolios")]
        [SwaggerOperation("PortfolioCountryPortfoliosGet")]
        [SwaggerResponse(200, type: typeof(Portfolios))]
        public virtual IActionResult PortfolioCountryPortfoliosGet([FromRoute]string country, [FromQuery]string emitterNumber, [FromQuery]string serviceType)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Portfolios>(exampleJson)
            : default(Portfolios);
            return new ObjectResult(example);
        }
    }
}
