using Mitrais_Test_Core.Model;
using Mitrais_Test_Core.Repository;
using Mitrais_Test_DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Service.Interface
{
    public interface IUserService
    {
        JsonEntity CreateNewUser(IMitraisEntity mitraisEntity, UserDTO model);
    }
}
