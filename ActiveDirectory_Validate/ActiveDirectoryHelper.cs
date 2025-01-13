using System;
using System.DirectoryServices.AccountManagement;


namespace ActiveDirectory_Validate
{
    public static class ActiveDirectoryHelper
    {
        public static bool ValidateUser(string domain, string username, string password)
        {
            try
            {
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                {
                    // Validate the credentials
                    return pc.ValidateCredentials(username, password);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error al validar las credenciales: " + ex.Message);
                throw new Exception(ex.Message);
                //return false;
            }
        }

    }
}
