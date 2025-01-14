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
                bool valido = false;

                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                {
                    // Validate the credentials
                    valido = pc.ValidateCredentials(username, password);

                    //If(valido)
                    //Obtener Objeto que contenga Usuario, Personal, Sucursal de tengan relacion con el usuario AD validado

                    return valido;
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
