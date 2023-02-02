using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Model.Models;
using Web.Service;
using WebGrease.Activities;

namespace Web.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }
        protected HttpResponseMessage createHttpResponse(HttpRequestMessage RequestMessage, Func<HttpResponseMessage> func)
        {
            HttpResponseMessage response=null;
            try {
                response = func.Invoke();
            }
            catch(DbEntityValidationException ex)
            {
                foreach(var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \" {eve.Entry.State}\" has the following validation error.");
                    foreach(var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\",error: \"{ve.ErrorMessage}\"");

                    }
                }
            }
            catch(Exception ex) 
            {
                LogError(ex);
                response = RequestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return response;    
            
        }
        private void LogError(Exception ex)
        {
            try
            {
                Error error= new Error();
                error.Message=ex.Message;
                error.StackTrace=ex.StackTrace;
                error.CreateDate=DateTime.Now;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {

            }
        }
    }
}
