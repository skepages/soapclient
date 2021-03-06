/**
 * TCreate_Return.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package de.epages.ws.basket.model;


/**
 * a single return value of a create() basket call.
 *         the alias will be always returned.
 *         the error element will be returned in case of error.
 *         the created flag and path will be returned if no error has
 * occured.
 */
public class TCreate_Return  implements java.io.Serializable {
    private java.lang.String alias;

    private java.lang.String path;

    /* a boolean flag indicating that this basket was created */
    private java.lang.Boolean created;

    /* error object (see epagestypes:TError) */
    private de.epages.ws.common.model.TError error;

    /* list of form error objects (see formtypes:TListOfFormErrors).
     * special form error objects when updating/setting the billing- or shipping-address
     * could have the following error codings:
     *              VATIDIsNotValid
     *              VATIDIsNotFromSameCountry
     *              ZIPCODE_NOT_VALID */
    private de.epages.ws.form.model.TFormError[] formErrors;

    public TCreate_Return() {
    }

    public TCreate_Return(
           java.lang.String alias,
           java.lang.String path,
           java.lang.Boolean created,
           de.epages.ws.common.model.TError error,
           de.epages.ws.form.model.TFormError[] formErrors) {
           this.alias = alias;
           this.path = path;
           this.created = created;
           this.error = error;
           this.formErrors = formErrors;
    }


    /**
     * Gets the alias value for this TCreate_Return.
     * 
     * @return alias
     */
    public java.lang.String getAlias() {
        return alias;
    }


    /**
     * Sets the alias value for this TCreate_Return.
     * 
     * @param alias
     */
    public void setAlias(java.lang.String alias) {
        this.alias = alias;
    }


    /**
     * Gets the path value for this TCreate_Return.
     * 
     * @return path
     */
    public java.lang.String getPath() {
        return path;
    }


    /**
     * Sets the path value for this TCreate_Return.
     * 
     * @param path
     */
    public void setPath(java.lang.String path) {
        this.path = path;
    }


    /**
     * Gets the created value for this TCreate_Return.
     * 
     * @return created   * a boolean flag indicating that this basket was created
     */
    public java.lang.Boolean getCreated() {
        return created;
    }


    /**
     * Sets the created value for this TCreate_Return.
     * 
     * @param created   * a boolean flag indicating that this basket was created
     */
    public void setCreated(java.lang.Boolean created) {
        this.created = created;
    }


    /**
     * Gets the error value for this TCreate_Return.
     * 
     * @return error   * error object (see epagestypes:TError)
     */
    public de.epages.ws.common.model.TError getError() {
        return error;
    }


    /**
     * Sets the error value for this TCreate_Return.
     * 
     * @param error   * error object (see epagestypes:TError)
     */
    public void setError(de.epages.ws.common.model.TError error) {
        this.error = error;
    }


    /**
     * Gets the formErrors value for this TCreate_Return.
     * 
     * @return formErrors   * list of form error objects (see formtypes:TListOfFormErrors).
     * special form error objects when updating/setting the billing- or shipping-address
     * could have the following error codings:
     *              VATIDIsNotValid
     *              VATIDIsNotFromSameCountry
     *              ZIPCODE_NOT_VALID
     */
    public de.epages.ws.form.model.TFormError[] getFormErrors() {
        return formErrors;
    }


    /**
     * Sets the formErrors value for this TCreate_Return.
     * 
     * @param formErrors   * list of form error objects (see formtypes:TListOfFormErrors).
     * special form error objects when updating/setting the billing- or shipping-address
     * could have the following error codings:
     *              VATIDIsNotValid
     *              VATIDIsNotFromSameCountry
     *              ZIPCODE_NOT_VALID
     */
    public void setFormErrors(de.epages.ws.form.model.TFormError[] formErrors) {
        this.formErrors = formErrors;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof TCreate_Return)) return false;
        TCreate_Return other = (TCreate_Return) obj;
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
            ((this.path==null && other.getPath()==null) || 
             (this.path!=null &&
              this.path.equals(other.getPath()))) &&
            ((this.created==null && other.getCreated()==null) || 
             (this.created!=null &&
              this.created.equals(other.getCreated()))) &&
            ((this.error==null && other.getError()==null) || 
             (this.error!=null &&
              this.error.equals(other.getError()))) &&
            ((this.formErrors==null && other.getFormErrors()==null) || 
             (this.formErrors!=null &&
              java.util.Arrays.equals(this.formErrors, other.getFormErrors())));
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
        if (getPath() != null) {
            _hashCode += getPath().hashCode();
        }
        if (getCreated() != null) {
            _hashCode += getCreated().hashCode();
        }
        if (getError() != null) {
            _hashCode += getError().hashCode();
        }
        if (getFormErrors() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getFormErrors());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getFormErrors(), i);
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
        new org.apache.axis.description.TypeDesc(TCreate_Return.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("urn://epages.de/WebService/BasketTypes/2013/11", "TCreate_Return"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("alias");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Alias"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("path");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Path"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("created");
        elemField.setXmlName(new javax.xml.namespace.QName("", "created"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("error");
        elemField.setXmlName(new javax.xml.namespace.QName("", "Error"));
        elemField.setXmlType(new javax.xml.namespace.QName("urn://epages.de/WebService/EpagesTypes/2005/01", "TError"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("formErrors");
        elemField.setXmlName(new javax.xml.namespace.QName("", "FormErrors"));
        elemField.setXmlType(new javax.xml.namespace.QName("urn://epages.de/WebService/FormTypes/2014/02", "TFormError"));
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
