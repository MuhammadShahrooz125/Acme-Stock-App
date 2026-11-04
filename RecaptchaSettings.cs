using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeStockModel
{
    public class RecaptchaSettings
    {
        public string SiteKey { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
        public float MinScore { get; set; } = 0.5f;
        public string VerifyUrl { get; set; } = string.Empty;
    }
}
