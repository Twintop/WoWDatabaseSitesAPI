using System;
using System.Xml.Serialization;
using System.Data;
using System.Globalization;
using System.Xml;
using System.Runtime.Serialization;

namespace WoWDatabaseSitesAPI.Framework.Core
{
    [Serializable()]
    public abstract class WoWDBAPIObject : ICloneable
    {
        #region Properties

        #endregion

        public WoWDBAPIObject()
        {

        }

        public new virtual object Clone()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetBaseProperty(XmlTextReader reader)
        {
            /*
            switch (reader.Name.ToUpper(CultureInfo.CurrentCulture))
            {
                case "ID":
                    this.Id = reader.IsEmptyElement ? -1 : Convert.ToInt32(reader.Value);
                    break;
            }*/
        }
    }
}
