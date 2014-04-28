/**
 * TInfoShop.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package de.epages.ws.shopconfig7.stub;


/**
 * shop data output by getInfo and getAllInfo operations
 */
public class TInfoShop  implements java.io.Serializable {
    /* unique shop name for the provider */
    private java.lang.String alias;

    /* shop type alias */
    private java.lang.String shopType;

    /* store database identifier */
    private java.lang.String database;

    /* provider of shop */
    private java.lang.String provider;

    /* object path of the shop within the store database */
    private java.lang.String objectPath;

    /* true if the shop is closed by provider */
    private boolean isClosed;

    /* true if the shop is deleted in the store database */
    private boolean isDeleted;

    /* datetime when the shop is marked for delete */
    private java.util.Calendar markedForDelOn;

    /* alias of shop object in store database */
    private java.lang.String objectAlias;

    /* true if the shop is in trial period */
    private boolean isTrialShop;

    /* true if the shop is used for test or support purposes */
    private boolean isInternalTestShop;

    /* domain name to access the shop */
    private java.lang.String domainName;

    /* secondary domain names to access the shop */
    private java.lang.String[] secondaryDomains;

    /* true if the web server has an SSL certificate for the shop */
    private boolean hasSSLCertificate;

    /* script name part that identifies the shop */
    private java.lang.String webServerScriptNamePart;

    /* login of the primary shop administrator */
    private java.lang.String merchantLogin;

    /* e-mail address of the primary shop administrator */
    private java.lang.String merchantEMail;

    /* list of requested shop attributes (see epagestypes:ListOfAttributes) */
    private de.epages.ws.common.model.TAttribute[] attributes;

    public TInfoShop() {
    }

    public TInfoShop(
           java.lang.String alias,
           java.lang.String shopType,
           java.lang.String database,
           java.lang.String provider,
           java.lang.String objectPath,
           boolean isClosed,
           boolean isDeleted,
           java.util.Calendar markedForDelOn,
           java.lang.String objectAlias,
           boolean isTrialShop,
           boolean isInternalTestShop,
           java.lang.String domainName,
           java.lang.String[] secondaryDomains,
           boolean hasSSLCertificate,
           java.lang.String webServerScriptNamePart,
           java.lang.String merchantLogin,
           java.lang.String merchantEMail,
           de.epages.ws.common.model.TAttribute[] attributes) {
           this.alias = alias;
           this.shopType = shopType;
           this.database = database;
           this.provider = provider;
           this.objectPath = objectPath;
           this.isClosed = isClosed;
           this.isDeleted = isDeleted;
           this.markedForDelOn = markedForDelOn;
           this.objectAlias = objectAlias;
           this.isTrialShop = isTrialShop;
           this.isInternalTestShop = isInternalTestShop;
           this.domainName = domainName;
           this.secondaryDomains = secondaryDomains;
           this.hasSSLCertificate = hasSSLCertificate;
           this.webServerScriptNamePart = webServerScriptNamePart;
           this.merchantLogin = merchantLogin;
           this.merchantEMail = merchantEMail;
           this.attributes = attributes;
    }


    /**
     * Gets the alias value for this TInfoShop.
     * 
     * @return alias   * unique shop name for the provider
     */
    public java.lang.String getAlias() {
        return alias;
    }


    /**
     * Sets the alias value for this TInfoShop.
     * 
     * @param alias   * unique shop name for the provider
     */
    public void setAlias(java.lang.String alias) {
        this.alias = alias;
    }


    /**
     * Gets the shopType value for this TInfoShop.
     * 
     * @return shopType   * shop type alias
     */
    public java.lang.String getShopType() {
        return shopType;
    }


    /**
     * Sets the shopType value for this TInfoShop.
     * 
     * @param shopType   * shop type alias
     */
    public void setShopType(java.lang.String shopType) {
        this.shopType = shopType;
    }


    /**
     * Gets the database value for this TInfoShop.
     * 
     * @return database   * store database identifier
     */
    public java.lang.String getDatabase() {
        return database;
    }


    /**
     * Sets the database value for this TInfoShop.
     * 
     * @param database   * store database identifier
     */
    public void setDatabase(java.lang.String database) {
        this.database = database;
    }


    /**
     * Gets the provider value for this TInfoShop.
     * 
     * @return provider   * provider of shop
     */
    public java.lang.String getProvider() {
        return provider;
    }


    /**
     * Sets the provider value for this TInfoShop.
     * 
     * @param provider   * provider of shop
     */
    public void setProvider(java.lang.String provider) {
        this.provider = provider;
    }


    /**
     * Gets the objectPath value for this TInfoShop.
     * 
     * @return objectPath   * object path of the shop within the store database
     */
    public java.lang.String getObjectPath() {
        return objectPath;
    }


    /**
     * Sets the objectPath value for this TInfoShop.
     * 
     * @param objectPath   * object path of the shop within the store database
     */
    public void setObjectPath(java.lang.String objectPath) {
        this.objectPath = objectPath;
    }


    /**
     * Gets the isClosed value for this TInfoShop.
     * 
     * @return isClosed   * true if the shop is closed by provider
     */
    public boolean isIsClosed() {
        return isClosed;
    }


    /**
     * Sets the isClosed value for this TInfoShop.
     * 
     * @param isClosed   * true if the shop is closed by provider
     */
    public void setIsClosed(boolean isClosed) {
        this.isClosed = isClosed;
    }


    /**
     * Gets the isDeleted value for this TInfoShop.
     * 
     * @return isDeleted   * true if the shop is deleted in the store database
     */
    public boolean isIsDeleted() {
        return isDeleted;
    }


    /**
     * Sets the isDeleted value for this TInfoShop.
     * 
     * @param isDeleted   * true if the shop is deleted in the store database
     */
    public void setIsDeleted(boolean isDeleted) {
        this.isDeleted = isDeleted;
    }


    /**
     * Gets the markedForDelOn value for this TInfoShop.
     * 
     * @return markedForDelOn   * datetime when the shop is marked for delete
     */
    public java.util.Calendar getMarkedForDelOn() {
        return markedForDelOn;
    }


    /**
     * Sets the markedForDelOn value for this TInfoShop.
     * 
     * @param markedForDelOn   * datetime when the shop is marked for delete
     */
    public void setMarkedForDelOn(java.util.Calendar markedForDelOn) {
        this.markedForDelOn = markedForDelOn;
    }


    /**
     * Gets the objectAlias value for this TInfoShop.
     * 
     * @return objectAlias   * alias of shop object in store database
     */
    public java.lang.String getObjectAlias() {
        return objectAlias;
    }


    /**
     * Sets the objectAlias value for this TInfoShop.
     * 
     * @param objectAlias   * alias of shop object in store database
     */
    public void setObjectAlias(java.lang.String objectAlias) {
        this.objectAlias = objectAlias;
    }


    /**
     * Gets the isTrialShop value for this TInfoShop.
     * 
     * @return isTrialShop   * true if the shop is in trial period
     */
    public boolean isIsTrialShop() {
        return isTrialShop;
    }


    /**
     * Sets the isTrialShop value for this TInfoShop.
     * 
     * @param isTrialShop   * true if the shop is in trial period
     */
    public void setIsTrialShop(boolean isTrialShop) {
        this.isTrialShop = isTrialShop;
    }


    /**
     * Gets the isInternalTestShop value for this TInfoShop.
     * 
     * @return isInternalTestShop   * true if the shop is used for test or support purposes
     */
    public boolean isIsInternalTestShop() {
        return isInternalTestShop;
    }


    /**
     * Sets the isInternalTestShop value for this TInfoShop.
     * 
     * @param isInternalTestShop   * true if the shop is used for test or support purposes
     */
    public void setIsInternalTestShop(boolean isInternalTestShop) {
        this.isInternalTestShop = isInternalTestShop;
    }


    /**
     * Gets the domainName value for this TInfoShop.
     * 
     * @return domainName   * domain name to access the shop
     */
    public java.lang.String getDomainName() {
        return domainName;
    }


    /**
     * Sets the domainName value for this TInfoShop.
     * 
     * @param domainName   * domain name to access the shop
     */
    public void setDomainName(java.lang.String domainName) {
        this.domainName = domainName;
    }


    /**
     * Gets the secondaryDomains value for this TInfoShop.
     * 
     * @return secondaryDomains   * secondary domain names to access the shop
     */
    public java.lang.String[] getSecondaryDomains() {
        return secondaryDomains;
    }


    /**
     * Sets the secondaryDomains value for this TInfoShop.
     * 
     * @param secondaryDomains   * secondary domain names to access the shop
     */
    public void setSecondaryDomains(java.lang.String[] secondaryDomains) {
        this.secondaryDomains = secondaryDomains;
    }


    /**
     * Gets the hasSSLCertificate value for this TInfoShop.
     * 
     * @return hasSSLCertificate   * true if the web server has an SSL certificate for the shop
     */
    public boolean isHasSSLCertificate() {
        return hasSSLCertificate;
    }


    /**
     * Sets the hasSSLCertificate value for this TInfoShop.
     * 
     * @param hasSSLCertificate   * true if the web server has an SSL certificate for the shop
     */
    public void setHasSSLCertificate(boolean hasSSLCertificate) {
        this.hasSSLCertificate = hasSSLCertificate;
    }


    /**
     * Gets the webServerScriptNamePart value for this TInfoShop.
     * 
     * @return webServerScriptNamePart   * script name part that identifies the shop
     */
    public java.lang.String getWebServerScriptNamePart() {
        return webServerScriptNamePart;
    }


    /**
     * Sets the webServerScriptNamePart value for this TInfoShop.
     * 
     * @param webServerScriptNamePart   * script name part that identifies the shop
     */
    public void setWebServerScriptNamePart(java.lang.String webServerScriptNamePart) {
        this.webServerScriptNamePart = webServerScriptNamePart;
    }


    /**
     * Gets the merchantLogin value for this TInfoShop.
     * 
     * @return merchantLogin   * login of the primary shop administrator
     */
    public java.lang.String getMerchantLogin() {
        return merchantLogin;
    }


    /**
     * Sets the merchantLogin value for this TInfoShop.
     * 
     * @param merchantLogin   * login of the primary shop administrator
     */
    public void setMerchantLogin(java.lang.String merchantLogin) {
        this.merchantLogin = merchantLogin;
    }


    /**
     * Gets the merchantEMail value for this TInfoShop.
     * 
     * @return merchantEMail   * e-mail address of the primary shop administrator
     */
    public java.lang.String getMerchantEMail() {
        return merchantEMail;
    }


    /**
     * Sets the merchantEMail value for this TInfoShop.
     * 
     * @param merchantEMail   * e-mail address of the primary shop administrator
     */
    public void setMerchantEMail(java.lang.String merchantEMail) {
        this.merchantEMail = merchantEMail;
    }


    /**
     * Gets the attributes value for this TInfoShop.
     * 
     * @return attributes   * list of requested shop attributes (see epagestypes:ListOfAttributes)
     */
    public de.epages.ws.common.model.TAttribute[] getAttributes() {
        return attributes;
    }


    /**
     * Sets the attributes value for this TInfoShop.
     * 
     * @param attributes   * list of requested shop attributes (see epagestypes:ListOfAttributes)
     */
    public void setAttributes(de.epages.ws.common.model.TAttribute[] attributes) {
        this.attributes = attributes;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof TInfoShop)) return false;
        TInfoShop other = (TInfoShop) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.alias==null && other.getAlias()==null) || 
             (this.alias!=null &&
              this.alias.equals(other.getAlias()))) &&
            ((this.shopType==null && other.getShopType()==null) || 
             (this.shopType!=null &&
              this.shopType.equals(other.getShopType()))) &&
            ((this.database==null && other.getDatabase()==null) || 
             (this.database!=null &&
              this.database.equals(other.getDatabase()))) &&
            ((this.provider==null && other.getProvider()==null) || 
             (this.provider!=null &&
              this.provider.equals(other.getProvider()))) &&
            ((this.objectPath==null && other.getObjectPath()==null) || 
             (this.objectPath!=null &&
              this.objectPath.equals(other.getObjectPath()))) &&
            this.isClosed == other.isIsClosed() &&
            this.isDeleted == other.isIsDeleted() &&
            ((this.markedForDelOn==null && other.getMarkedForDelOn()==null) || 
             (this.markedForDelOn!=null &&
              this.markedForDelOn.equals(other.getMarkedForDelOn()))) &&
            ((this.objectAlias==null && other.getObjectAlias()==null) || 
             (this.objectAlias!=null &&
              this.objectAlias.equals(other.getObjectAlias()))) &&
            this.isTrialShop == other.isIsTrialShop() &&
            this.isInternalTestShop == other.isIsInternalTestShop() &&
            ((this.domainName==null && other.getDomainName()==null) || 
             (this.domainName!=null &&
              this.domainName.equals(other.getDomainName()))) &&
            ((this.secondaryDomains==null && other.getSecondaryDomains()==null) || 
             (this.secondaryDomains!=null &&
              java.util.Arrays.equals(this.secondaryDomains, other.getSecondaryDomains()))) &&
            this.hasSSLCertificate == other.isHasSSLCertificate() &&
            ((this.webServerScriptNamePart==null && other.getWebServerScriptNamePart()==null) || 
             (this.webServerScriptNamePart!=null &&
              this.webServerScriptNamePart.equals(other.getWebServerScriptNamePart()))) &&
            ((this.merchantLogin==null && other.getMerchantLogin()==null) || 
             (this.merchantLogin!=null &&
              this.merchantLogin.equals(other.getMerchantLogin()))) &&
            ((this.merchantEMail==null && other.getMerchantEMail()==null) || 
             (this.merchantEMail!=null &&
              this.merchantEMail.equals(other.getMerchantEMail()))) &&
            ((this.attributes==null && other.getAttributes()==null) || 
             (this.attributes!=null &&
              java.util.Arrays.equals(this.attributes, other.getAttributes())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getAlias() != null) {
            _hashCode += getAlias().hashCode();
        }
        if (getShopType() != null) {
            _hashCode += getShopType().hashCode();
        }
        if (getDatabase() != null) {
            _hashCode += getDatabase().hashCode();
        }
        if (getProvider() != null) {
            _hashCode += getProvider().hashCode();
        }
        if (getObjectPath() != null) {
            _hashCode += getObjectPath().hashCode();
        }
        _hashCode += (isIsClosed() ? Boolean.TRUE : Boolean.FALSE).hashCode();
        _hashCode += (isIsDeleted() ? Boolean.TRUE : Boolean.FALSE).hashCode();
        if (getMarkedForDelOn() != null) {
            _hashCode += getMarkedForDelOn().hashCode();
        }
        if (getObjectAlias() != null) {
            _hashCode += getObjectAlias().hashCode();
        }
        _hashCode += (isIsTrialShop() ? Boolean.TRUE : Boolean.FALSE).hashCode();
        _hashCode += (isIsInternalTestShop() ? Boolean.TRUE : Boolean.FALSE).hashCode();
        if (getDomainName() != null) {
            _hashCode += getDomainName().hashCode();
        }
        if (getSecondaryDomains() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getSecondaryDomains());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getSecondaryDomains(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        _hashCode += (isHasSSLCertificate() ? Boolean.TRUE : Boolean.FALSE).hashCode();
        if (getWebServerScriptNamePart() != null) {
            _hashCode += getWebServerScriptNamePart().hashCode();
        }
        if (getMerchantLogin() != null) {
            _hashCode += getMerchantLogin().hashCode();
        }
        if (getMerchantEMail() != null) {
            _hashCode += getMerchantEMail().hashCode();
        }
        if (getAttributes() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getAttributes());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getAttributes(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(TInfoShop.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("urn://epages.de/WebService/ShopConfigService/2014/03", "TInfoShop"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("alias");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Alias"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("shopType");
        elemField.setXmlName(new javax.xml.namespace.QName("", "ShopType"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("database");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Database"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("provider");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Provider"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("objectPath");
        elemField.setXmlName(new javax.xml.namespace.QName("", "ObjectPath"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("isClosed");
        elemField.setXmlName(new javax.xml.namespace.QName("", "IsClosed"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("isDeleted");
        elemField.setXmlName(new javax.xml.namespace.QName("", "IsDeleted"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("markedForDelOn");
        elemField.setXmlName(new javax.xml.namespace.QName("", "MarkedForDelOn"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("objectAlias");
        elemField.setXmlName(new javax.xml.namespace.QName("", "ObjectAlias"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("isTrialShop");
        elemField.setXmlName(new javax.xml.namespace.QName("", "IsTrialShop"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("isInternalTestShop");
        elemField.setXmlName(new javax.xml.namespace.QName("", "IsInternalTestShop"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("domainName");
        elemField.setXmlName(new javax.xml.namespace.QName("", "DomainName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("secondaryDomains");
        elemField.setXmlName(new javax.xml.namespace.QName("", "SecondaryDomains"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("hasSSLCertificate");
        elemField.setXmlName(new javax.xml.namespace.QName("", "HasSSLCertificate"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("webServerScriptNamePart");
        elemField.setXmlName(new javax.xml.namespace.QName("", "WebServerScriptNamePart"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("merchantLogin");
        elemField.setXmlName(new javax.xml.namespace.QName("", "MerchantLogin"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("merchantEMail");
        elemField.setXmlName(new javax.xml.namespace.QName("", "MerchantEMail"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("attributes");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Attributes"));
        elemField.setXmlType(new javax.xml.namespace.QName("urn://epages.de/WebService/EpagesTypes/2005/01", "TAttribute"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
