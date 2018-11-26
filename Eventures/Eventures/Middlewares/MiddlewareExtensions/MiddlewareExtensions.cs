using Microsoft.AspNetCore.Builder;

namespace Eventures.Middlewares.MiddlewareExtensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSeedDataMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedDataMiddleware>();
        }
    }
}
