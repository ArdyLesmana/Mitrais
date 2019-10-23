using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mitrais_Test_Core.Model;
using Mitrais_Test_Core.MVC;
using Mitrais_Test_Core.Repository;
using Mitrais_Test_DTO;
using Mitrais_Test_Repo.UnitOfWork;
using Mitrais_Test_Service.Interface;

namespace Mitrais_Test_Web.Controllers
{
    public class AccountController : BaseController
    {

        private readonly IDBEntityProvider dBEntityProvider;
        private readonly IUserService user_service;

        public AccountController(IUserService user_service, IDBEntityProvider dBEntityProvider)
        {
            this.user_service = user_service;
            this.dBEntityProvider = dBEntityProvider;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        public JsonEntity AddUser(UserDTO user)
        {
            JsonEntity _json = new JsonEntity();
            try
            {
                using (IMitraisEntity mitraisEntity = dBEntityProvider.GetMitraisEntity())
                {
                    _json = user_service.CreateNewUser(mitraisEntity, user);
                    mitraisEntity.IsRollback |= _json.error;
                }
            }
            catch (Exception ex)
            {
                _json.AddExceptionAlert(ex);
            }
            return _json;
        }

    }
}