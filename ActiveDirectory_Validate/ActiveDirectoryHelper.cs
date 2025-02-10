using DevExpress.Data.Mask.Internal;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;


namespace ActiveDirectory_Validate
{
    public class ActiveDirectoryHelper
    {
        private readonly PrincipalContext _context;

        public ActiveDirectoryHelper(string domain, string adminUsername, string adminPassword)
        {
            _context = new PrincipalContext(ContextType.Domain, domain, adminUsername, adminPassword);
        }

        public bool ValidateUser(string domain, string username, string password)
        {
            try
            {
                bool valido = false;

                //using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                //{
                    // Validate the credentials
                    UserPrincipal user = UserPrincipal.FindByIdentity(_context, username);

                    if(user != null)
                    {
                        if (user.IsAccountLockedOut())
                        {
                            Console.WriteLine("Usuario Bloqueado");
                            if (UnlockAccount(username))
                            {
                                valido = _context.ValidateCredentials(username, password);
                            }
                            //user.UnlockAccount();
                            //user.Save();
                        }
                        else
                        {
                        valido = true;
                        }
                    }
                    return valido;
                //}
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error al validar las credenciales: " + ex.Message);
                throw new Exception(ex.Message);
                //return false;
            }
        }

        public UserPrincipal GetUserInformation(string username)
        {
            try
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(_context, username);
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la información del usuario: " + ex.Message);
                return null;
            }
        }

        public List<UserPrincipal> GetAllUsers(string domain, string username, string password)
        {
            List<UserPrincipal> users = new List<UserPrincipal>();

            try
            {
                UserPrincipal userPrincipal = new UserPrincipal(_context);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el listado de usuarios: " + ex.Message);
            }

            return users;
        }

        public List<UserPrincipal> GetAllUsers(string domain)
        {
            List<UserPrincipal> users = new List<UserPrincipal>();

            try
            {
                UserPrincipal userPrincipal = new UserPrincipal(_context);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el listado de usuarios: " + ex.Message);
            }

            return users;
        }

        private bool UnlockAccount(string username)
        {
            bool _state = false;

            UserPrincipal user = UserPrincipal.FindByIdentity(_context, username);
            if (user != null && user.IsAccountLockedOut())
            {
                user.UnlockAccount();
                user.Save();
                _state = true;
            }

            return _state;
        }




    }
}
