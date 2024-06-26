//--------------------------------------------------
// Tarteeb School (c) All rights reserved
//--------------------------------------------------

using EShop.Brokers.Storages;
using EShop.Models.Auth;

namespace EShop.Services.Login  
{
    public class LoginService : ILoginService
    {
        private readonly IStorageBroker<Credential> storageBroker;

        public LoginService()
        {
            this.storageBroker = new FileStorageBroker();
        }

        public bool CheckUserLogin(Credential credential)
        {
            foreach (Credential credentialItem in storageBroker.GetAll())
            {
                if (credential.Username == credentialItem.Username && 
                    credential.Password == credentialItem.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}