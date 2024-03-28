//--------------------------------------------------
// Tarteeb School (c) All rights reserved
//--------------------------------------------------

using EShop.Models.Auth;

namespace EShop.Services.Login
{
    public interface ILoginService
    {
        bool CheckUserLogin(string name, Credential credential);
        bool CheckUserLogin(Credential credential);
    }
}