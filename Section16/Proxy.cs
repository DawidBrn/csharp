using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16
{
    public interface IInformation
    {
        int getInformation();
    }
    public class SecretInformation : IInformation
    {
        public int getInformation()
        {
            Random info = new Random();
            int SecretInfo = info.Next(0, 100);
            return SecretInfo;
        }
    }
    public class SecurityProxy
    {
        IInformation secretInfo;

        public int getInformation(bool hasSecretAccess = false)
        {
            if (hasSecretAccess)
            {
                secretInfo = new SecretInformation();
                return secretInfo.getInformation();
            }
            else return -1;
        }
    }
}
