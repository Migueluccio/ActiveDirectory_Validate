using System;
using System.Collections.Generic;
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

        public static UserPrincipal GetUserInformation(string domain, string username, string password)
        {
            try
            {
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain, username, password))
                {
                    UserPrincipal user = UserPrincipal.FindByIdentity(pc, username);
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la información del usuario: " + ex.Message);
                return null;
            }
        }

        public static List<UserPrincipal> GetAllUsers(string domain, string username, string password)
        {
            List<UserPrincipal> users = new List<UserPrincipal>();

            try
            {
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain, username, password))
                {
                    UserPrincipal userPrincipal = new UserPrincipal(pc);
                    using (PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal))
                    {
                        foreach (var result in searcher.FindAll())
                        {
                            UserPrincipal user = result as UserPrincipal;
                            if (user != null)
                            {
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el listado de usuarios: " + ex.Message);
            }

            return users;
        }


    }
}
