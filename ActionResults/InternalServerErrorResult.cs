using Microsoft.AspNetCore.Mvc;

namespace Energetic.WebApis.ActionResults
{
    public class InternalServerErrorResult : StatusCodeResult
    {
        public InternalServerErrorResult(string? explanation = null) : base(500)
        {
            Message = explanation ?? "An internal server error occurred";
        }

        public string Message { get; }
    }
}
