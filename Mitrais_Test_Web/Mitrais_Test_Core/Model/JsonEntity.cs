using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Mitrais_Test_Core.Model
{
    public class JsonEntity
    {
        public bool error { get; set; }
        public Alert alerts { get; set; }
        public Object data { get; set; }

        public JsonEntity()
        {
            this.alerts = new Alert();
            this.data = new Object();
        }

        private void AddAlert(string code, string message, int errorCode = 0)
        {
            this.alerts.code = code;
            this.alerts.message = message;
            this.alerts.error_code = errorCode;
        }

        public O GetData<O>()
        {
            return (O)this.data;
        }

        public void AddErrorAlert(int Code, string Message)
        {
            this.alerts.code = Code.ToString();
            this.alerts.message = Message;
            this.alerts.error_code = 0;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(HttpStatusCode Code, string Message)
        {
            this.alerts.code = ((int)Code).ToString();
            this.alerts.message = Message;
            this.alerts.error_code = 0;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(string Code, string Message)
        {
            this.alerts.code = Code;
            this.alerts.message = Message;
            this.alerts.error_code = 0;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(HttpStatusCode Code, string Message, int ErrorCode)
        {
            this.alerts.code = ((int)Code).ToString();
            this.alerts.message = Message;
            this.alerts.error_code = ErrorCode;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(int Code, string Message, int ErrorCode)
        {
            this.alerts.code = (Code).ToString();
            this.alerts.message = Message;
            this.alerts.error_code = ErrorCode;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(string Code, string Message, int ErrorCode)
        {
            this.alerts.code = Code;
            this.alerts.message = Message;
            this.alerts.error_code = ErrorCode;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(HttpStatusCode Code, Messages message, params string[] msgArgs)
        {
            this.alerts.code = ((int)Code).ToString();
            this.alerts.message = string.Format(message.Message, msgArgs);
            this.alerts.error_code = message.Code;
            this.error = true;
            this.data = null;
        }

        public void AddErrorAlert(HttpStatusCode badRequest, object aLERT_COMMON_NOT_FOUND)
        {
            throw new NotImplementedException();
        }

        public void AddErrorAlert(HttpStatusCode Code, Messages message)
        {
            this.alerts.code = ((int)Code).ToString();
            this.alerts.message = message.Message;
            this.alerts.error_code = message.Code;
            this.error = true;
            this.data = null;
        }

        public void AddExceptionAlert()
        {
            Messages message = BaseApiMessage.ALERT_COMMON_ERROR;
            this.alerts.code = "400";
            this.alerts.message = message.Message;
            this.alerts.error_code = message.Code;
            this.error = true;
            this.data = null;
        }

        public void AddExceptionAlert(Exception ex)
        {
            Messages message = BaseApiMessage.ALERT_COMMON_ERROR;
            this.alerts.code = "400";
            this.alerts.message = message.Message;
            this.alerts.error_code = message.Code;
            this.error = true;
            this.data = null;
        }

        public void AddSuccessData(Object Data)
        {
            this.error = false;
            this.data = Data;
            AddAlert("200", "Request Success", 0);
        }

        public void AddSuccessData(Object Data, Messages message, params string[] msgArgs)
        {
            this.error = false;
            this.data = Data;
            this.alerts.code = ((int)HttpStatusCode.OK).ToString();
            this.alerts.message = string.Format(message.Message, msgArgs);
            this.alerts.error_code = message.Code;
        }

        public void AddSuccessData(Object Data, string Message)
        {
            this.error = false;
            this.data = Data;
            AddAlert("200", Message, 0);
        }
        public void AddSuccessData(string Message)
        {
            this.error = false;
            this.data = null;
            AddAlert("200", Message, 0);
        }

        public void AddSuccessData(Object Data, string Message, int ErrorCode)
        {
            this.error = false;
            this.data = Data;
            AddAlert("200", Message, ErrorCode);
        }
    }
}
