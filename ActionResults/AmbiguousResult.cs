using Microsoft.AspNetCore.Mvc;

namespace Energetic.WebApis.ActionResults
{
    public class AmbiguousResult : StatusCodeResult
    {
        public AmbiguousResult(string? explanation = null) : base(300)
        {
            Message = explanation ?? "The requested object has multiple representations on the server.";
        }

        public string Message { get; }
    }
}
