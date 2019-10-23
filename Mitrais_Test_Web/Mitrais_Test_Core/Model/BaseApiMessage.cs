using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Core.Model
{
    public abstract class BaseApiMessage
    {
        public static Messages INFO_COMMON_SUCCESS = new Messages(200,
          new MessageContent("en", "{0} success"),
          new MessageContent("id", "{0} berhasil"));

        public static Messages ALERT_COMMON_ERROR = new Messages(-100,
            new MessageContent("en", "Oops something went wrong, please try again"),
            new MessageContent("id", "Oops, Terjadi kesalahan, Silahkan dicoba kembali"));

        public static Messages ALERT_COMMON_DATA_NOT_FOUND = new Messages(-101,
           new MessageContent("en", "Data not found"),
           new MessageContent("id", "Data tidak ditemukan"));

        public static Messages ALERT_COMMON_NOT_FOUND = new Messages(-101,
         new MessageContent("en", "{0} not found"),
         new MessageContent("id", "{0} tidak ditemukan"));

        public static Messages ALERT_COMMON_FAILED = new Messages(-102,
         new MessageContent("en", "{0} failed"),
         new MessageContent("id", "{0} gagal"));

        public static Messages ERROR_COMMON_INVALID_PARAMETER = new Messages(-103,
         new MessageContent("en", "Invalid parameters."),
         new MessageContent("id", "Parameter yang anda masukkan salah."));
    }
}
