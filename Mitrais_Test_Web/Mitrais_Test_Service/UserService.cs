using Microsoft.AspNetCore.Mvc;
using Mitrais_Test_Core.Model;
using Mitrais_Test_Core.Repository;
using Mitrais_Test_DTO;
using Mitrais_Test_Repo.Db;
using Mitrais_Test_Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<MD_User> user_repo;

        public UserService(IRepository<MD_User> user_repo)
        {
            this.user_repo = user_repo;
        }
        public JsonEntity CreateNewUser(IMitraisEntity mitraisEntity, UserDTO model)
        {
            JsonEntity _json = new JsonEntity();

            try
            {
                MD_User new_user = new MD_User()
                {
                    phone = model.Phone,
                    dob = (model.Dob == null) ? String.Empty : model.Dob,
                    first_name = model.First_Name,
                    last_name = model.Last_Name,
                    gender = model.Gender,
                    email = model.Email
                };

                user_repo.Insert(mitraisEntity, "ID", new_user);

                _json.AddSuccessData("Successfully added new user");
            }
            catch (Exception ex)
            {
                _json.AddExceptionAlert(ex);
            }
            return _json;
        }
    }
}
