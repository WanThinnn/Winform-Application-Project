using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_NekoCoffeeApp
{
    public class VerificationCodeInfo
    {
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }

        public static VerificationCodeInfo GenerateVerificationCode()
        {
            Random random = new Random();
            int code = random.Next(100000, 999999);
            DateTime createdAt = DateTime.Now;
            return new VerificationCodeInfo { Code = code.ToString(), CreatedAt = createdAt };
        }
    }
}
