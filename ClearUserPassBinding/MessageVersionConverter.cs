using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.ServiceModel;
using System.Globalization;
using System.ServiceModel.Channels;
using System.Linq;
using System.Text;


/*
 * Want more WCF tips?
 * Visit http://webservices20.blogspot.com/
 */


namespace WebServices20.BindingExtenions
{
    /// <summary>
    /// This code is a copy of System.ServiceModel.Configuration.MessageVersionConverter.
    /// That class is internal so it needs to be duplicated here.
    /// </summary>
    class MessageVersionConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return ((typeof(string) == sourceType) || base.CanConvertFrom(context, sourceType));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return ((typeof(InstanceDescriptor) == destinationType) || base.CanConvertTo(context, destinationType));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (!(value is string))
            {
                return base.ConvertFrom(context, culture, value);
            }
            string str = (string)value;
            switch (str)
            {
                case "Soap11WSAddressing10":
                    return MessageVersion.Soap11WSAddressing10;

                case "Soap12WSAddressing10":
                    return MessageVersion.Soap12WSAddressing10;

                case "Soap11WSAddressingAugust2004":
                    return MessageVersion.Soap11WSAddressingAugust2004;

                case "Soap12WSAddressingAugust2004":
                    return MessageVersion.Soap12WSAddressingAugust2004;

                case "Soap11":
                    return MessageVersion.Soap11;

                case "Soap12":
                    return MessageVersion.Soap12;

                case "None":
                    return MessageVersion.None;

                case "Default":
                    return MessageVersion.Default;
            }
            throw new ArgumentOutOfRangeException("messageVersion", str, "The argument must be of type System.ServiceModel.Channels.MessageVersion");
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if ((typeof(string) != destinationType) || !(value is MessageVersion))
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }
            MessageVersion version = (MessageVersion)value;
            if (version == MessageVersion.Default)
            {
                return "Default";
            }
            if (version == MessageVersion.Soap11WSAddressing10)
            {
                return "Soap11WSAddressing10";
            }
            if (version == MessageVersion.Soap12WSAddressing10)
            {
                return "Soap12WSAddressing10";
            }
            if (version == MessageVersion.Soap11WSAddressingAugust2004)
            {
                return "Soap11WSAddressingAugust2004";
            }
            if (version == MessageVersion.Soap12WSAddressingAugust2004)
            {
                return "Soap12WSAddressingAugust2004";
            }
            if (version == MessageVersion.Soap11)
            {
                return "Soap11";
            }
            if (version == MessageVersion.Soap12)
            {
                return "Soap12";
            }
            if (version != MessageVersion.None)
            {
                throw new ArgumentOutOfRangeException("messageVersion", value, "The argument must be of type System.ServiceModel.Channels.MessageVersion");
            }
            return "None";
        }
    }
}
