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
    public class UsersApiController : Controller
    { 

        /// <summary>
        /// Validates credentials from issuer monitor.
        /// </summary>
        /// <remarks>This function exists to make sure that the user trying to activate the facturizate solution is who he claims to be. From the user of the sending monitor and the password are validated against SIGO if it is what is registered.</remarks>
        /// <param name="body">Credential to be validated</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/users")]
        [SwaggerOperation("GetSigoCredentials")]
        [SwaggerResponse(200, type: typeof(Users))]
        public virtual IActionResult GetSigoCredentials([FromBody]LoginCredentials body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Users>(exampleJson)
            : default(Users);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Creates a SIGO user.
        /// </summary>
        /// <remarks>Allows you to create a user of Sigo.</remarks>
        /// <param name="country"></param>
        /// <param name="body">The user to be created</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/cvillanexos/NexosSigostore/beta/users/{country}")]
        [SwaggerOperation("UsersCountryPost")]
        [SwaggerResponse(200, type: typeof(Users))]
        public virtual IActionResult UsersCountryPost([FromRoute]string country, [FromBody]Users body)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Users>(exampleJson)
            : default(Users);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Validates that the user exist in SIGO
        /// </summary>
        /// <remarks>Validates the existence of the user in SIGO, and also verifies the permission upon Facturizate</remarks>
        /// <param name="userName">user for whom privileges are sought</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid user name</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/cvillanexos/NexosSigostore/beta/users/{userName}/privileges")]
        [SwaggerOperation("ValidateCredential")]
        [SwaggerResponse(200, type: typeof(Users))]
        public virtual IActionResult ValidateCredential([FromRoute]string userName)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Users>(exampleJson)
            : default(Users);
            return new ObjectResult(example);
        }
    }
}
