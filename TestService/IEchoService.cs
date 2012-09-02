using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


/*
 * Want more WCF tips?
 * Visit http://webservices20.blogspot.com/
 */


namespace WebServices20.SampleService
{
    [ServiceContract]
    interface IEchoService
    {
        [OperationContract]
        String EchoString(String s);
    }
}
