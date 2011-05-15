using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Recomende.Util
{
    public class ExtJSAjaxResponse
    {
        private object myErrors = null;
        private object myData = null;
        private bool mySuccess = true;
        private object myfoundRows = 0;
        private string MyMessage = null;

        public ExtJSAjaxResponse()
        {
        }

        public ExtJSAjaxResponse(string Message, object errors, object data, bool success, long foundRows)
        {
            MyMessage = Message;
            myErrors = errors;
            mySuccess = success;
            myfoundRows = foundRows;
            myData = data;
        }

        public object errors
        {
            get { return myErrors; }
            set { myErrors = value; }
        }

        public object data
        {
            get { return myData; }
            set { myData = value; }
        }

        public bool success
        {
            get { return mySuccess; }
            set { mySuccess = value; }
        }

        public object foundRows
        {
            get { return myfoundRows; }
            set { myfoundRows = value; }
        }

        public string message
        {
            get { return MyMessage; }
            set { MyMessage = value; }
        }
    }
}