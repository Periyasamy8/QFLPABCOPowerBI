﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Net;
using System.Text.RegularExpressions;
using System.Configuration;

namespace ExportVINDataAPI
{
    public class DistributorValidator : ServiceAuthorizationManager
    {
  
            protected override bool CheckAccessCore(OperationContext operationContext)

            {

                var loc = operationContext.Channel.LocalAddress.Uri.LocalPath;

                var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
           
                if ((authHeader != null) && (authHeader != string.Empty) && (authHeader != "null"))

                {



                var svcCredentials = System.Text.ASCIIEncoding.ASCII

         .GetString(Convert.FromBase64String(authHeader.Substring(6)))

         .Split(':');

                var user = new

                {

                    Name = svcCredentials[0],

                    Password = svcCredentials[1]

                };



                if ((user.Name == Convert.ToString(ConfigurationManager.AppSettings["TokenUser"]) && user.Password == Convert.ToString(ConfigurationManager.AppSettings["TokenPass"])))

                {



                    return true;

                }

                else

                {



                    throw new WebFaultException(HttpStatusCode.Unauthorized);

                }


               // return true;




                }

                else

                {

                WebOperationContext.Current.OutgoingResponse.Headers.Add("WWW-Authenticate: Basic realm=\"Unauthorized\"");

                throw new WebFaultException(HttpStatusCode.Unauthorized);



               // return true;



                }







            }

     }


 }
