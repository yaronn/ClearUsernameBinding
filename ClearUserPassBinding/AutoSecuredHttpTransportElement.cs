using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;


/*
 * Want more WCF tips?
 * Visit http://webservices20.blogspot.com/
 */


namespace WebServices20.BindingExtenions
{
    public class AutoSecuredHttpTransportElement : HttpTransportBindingElement, 
                        ITransportTokenAssertionProvider
    {
        public override T GetProperty<T>(BindingContext context)
        {
            if (typeof(T) == typeof(ISecurityCapabilities))            
                return (T) (ISecurityCapabilities) new AutoSecuredHttpSecurityCapabilities();                            

            return base.GetProperty<T>(context);
        }

        public System.Xml.XmlElement GetTransportTokenAssertion()
        {
            return null;
        }
    }
}
