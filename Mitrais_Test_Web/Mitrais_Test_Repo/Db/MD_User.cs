using NPoco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Repo.Db
{
    [TableName("MD_USER")]
    [PrimaryKey("ID")]
    public class MD_User
    {
        public int id { get; set; }
        public String phone { get; set; }
        public String dob { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }
        public String gender { get; set; }
    }
}
