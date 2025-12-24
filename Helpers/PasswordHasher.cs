using Microsoft.AspNetCore.Identity;

namespace Backend.Helpers
{
    public static class PasswordHasher
    {
        private static readonly PasswordHasher<object> _hasher = new();

        public static string Hash(string password)
            => _hasher.HashPassword(null!, password);

        public static bool Verify(string hash, string password)
            => _hasher.VerifyHashedPassword(null!, hash, password)
               == PasswordVerificationResult.Success;
    }
}
