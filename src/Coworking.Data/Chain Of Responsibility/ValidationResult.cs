using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Chain_Of_Responsibility
{
    public class ValidationResult
    {
        public bool isValid { get; set; }
        public string? errorMessage { get; set; }

        public static ValidationResult Success() => new ValidationResult { isValid = true };
        public static ValidationResult Fail(string message) => new ValidationResult { isValid = false, errorMessage = message };
    }
}
