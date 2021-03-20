using Microsoft.AspNetCore.Mvc;
using Energetic.WebApis.ActionResults;

namespace Energetic.WebApis
{
    public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Creates an <see cref="Energetic.WebApis.ActionResults.InternalServerErrorResult" /> that produces
        /// a <see cref="Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError" /> response.
        /// </summary>
        /// <param name="explanation"></param>
        /// <returns></returns>
        protected virtual InternalServerErrorResult InternalServerError(string? explanation = null)
        {
            return new InternalServerErrorResult(explanation);
        }

        /// <summary>
        /// Creates an <see cref="Microsoft.AspNetCore.Mvc.UnauthorizedResult" /> that produces
        /// a <see cref="Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized" /> response.
        /// </summary>
        /// <remarks>The official name for the 401 HTTP Status Code response is "Unauthorized" but the explanation of the status
        /// code in the HTTP specification makes it clear that it means "Unauthenticated" (something quite different). That is why we have named our method 
        /// "NotAuthenticated" instead of "NotAuthorized" or "Unauthorized". A true not-authorized response is represented by status code 403 - Forbidden, and
        /// you can use the <see cref="Microsoft.AspNetCore.Mvc.ControllerBase.Forbid" /> method to create one if you need to.</remarks>
        protected virtual UnauthorizedResult NotAuthenticated(string? explanation = null)
        {
            return new UnauthorizedResult();
        }

        protected virtual AmbiguousResult Ambiguous(string? explanation = null)
        {
            return new AmbiguousResult(explanation);
        }
    }
}
