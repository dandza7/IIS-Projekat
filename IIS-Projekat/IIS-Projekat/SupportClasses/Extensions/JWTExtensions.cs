using System.Security.Claims;

namespace IIS_Projekat.SupportClasses.Extensions
{
    public static class JWTExtensions
    {
        public static string GetEmail(this ClaimsPrincipal claims)
        {
            return claims.FindFirstValue(ClaimTypes.Email);
        }
    }
}
