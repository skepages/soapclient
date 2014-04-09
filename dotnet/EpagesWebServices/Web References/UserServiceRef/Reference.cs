//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpagesWebServices.UserServiceRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_User_SOAP", Namespace="urn://epages.de/WebService/UserService/2005/01")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TCreate_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TCreate_Input))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TUpdate_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TUpdate_Input))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TDelete_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TExists_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TLocalizedValue))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TAttribute))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TGetInfo_Return))]
    public partial class UserService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public UserService() {
            this.Url = "http://localhost/epages/Store.soap";
        }
        
        public UserService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/UserService/2005/01#getInfo", RequestNamespace="urn://epages.de/WebService/UserService/2005/01", ResponseNamespace="urn://epages.de/WebService/UserService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Users")]
        public TGetInfo_Return[] getInfo(string[] Users, string[] Attributes) {
            object[] results = this.Invoke("getInfo", new object[] {
                        Users,
                        Attributes});
            return ((TGetInfo_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetInfo(string[] Users, string[] Attributes, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getInfo", new object[] {
                        Users,
                        Attributes}, callback, asyncState);
        }
        
        /// <remarks/>
        public TGetInfo_Return[] EndgetInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TGetInfo_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/UserService/2005/01#exists", RequestNamespace="urn://epages.de/WebService/UserService/2005/01", ResponseNamespace="urn://epages.de/WebService/UserService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Users")]
        public TExists_Return[] exists(string[] Users) {
            object[] results = this.Invoke("exists", new object[] {
                        Users});
            return ((TExists_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexists(string[] Users, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exists", new object[] {
                        Users}, callback, asyncState);
        }
        
        /// <remarks/>
        public TExists_Return[] Endexists(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TExists_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/UserService/2005/01#delete", RequestNamespace="urn://epages.de/WebService/UserService/2005/01", ResponseNamespace="urn://epages.de/WebService/UserService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Users")]
        public TDelete_Return[] delete(string[] Users) {
            object[] results = this.Invoke("delete", new object[] {
                        Users});
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begindelete(string[] Users, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("delete", new object[] {
                        Users}, callback, asyncState);
        }
        
        /// <remarks/>
        public TDelete_Return[] Enddelete(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/UserService/2005/01#update", RequestNamespace="urn://epages.de/WebService/UserService/2005/01", ResponseNamespace="urn://epages.de/WebService/UserService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Users")]
        public TUpdate_Return[] update(TUpdate_Input[] Users) {
            object[] results = this.Invoke("update", new object[] {
                        Users});
            return ((TUpdate_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginupdate(TUpdate_Input[] Users, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("update", new object[] {
                        Users}, callback, asyncState);
        }
        
        /// <remarks/>
        public TUpdate_Return[] Endupdate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TUpdate_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/UserService/2005/01#create", RequestNamespace="urn://epages.de/WebService/UserService/2005/01", ResponseNamespace="urn://epages.de/WebService/UserService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Users")]
        public TCreate_Return[] create(TCreate_Input[] Users) {
            object[] results = this.Invoke("create", new object[] {
                        Users});
            return ((TCreate_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begincreate(TCreate_Input[] Users, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("create", new object[] {
                        Users}, callback, asyncState);
        }
        
        /// <remarks/>
        public TCreate_Return[] Endcreate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TCreate_Return[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TGetInfo_Return {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string Class;
        
        /// <remarks/>
        public string LocaleID;
        
        /// <remarks/>
        public string LanguageCode;
        
        /// <remarks/>
        public string CurrencyID;
        
        /// <remarks/>
        public string Password;
        
        /// <remarks/>
        public bool IsActivated;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsActivatedSpecified;
        
        /// <remarks/>
        public bool DeleteConfirmation;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool DeleteConfirmationSpecified;
        
        /// <remarks/>
        public bool IsLoginCookieAllowed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsLoginCookieAllowedSpecified;
        
        /// <remarks/>
        public bool IsHtmlEMailAllowed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsHtmlEMailAllowedSpecified;
        
        /// <remarks/>
        public string ReminderQuestion;
        
        /// <remarks/>
        public string ChallengePhrase;
        
        /// <remarks/>
        public string EMail;
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public TAddress BillingAddress;
        
        /// <remarks/>
        public TAddress ShippingAddress;
        
        /// <remarks/>
        public string[] Customers;
        
        /// <remarks/>
        public TAttribute[] Attributes;
        
        /// <remarks/>
        public TError Error;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ShopTypes/2005/01")]
    public partial class TAddress {
        
        /// <remarks/>
        public string DisplayName;
        
        /// <remarks/>
        public string AddressExtension;
        
        /// <remarks/>
        public string Street;
        
        /// <remarks/>
        public string Zipcode;
        
        /// <remarks/>
        public string City;
        
        /// <remarks/>
        public string State;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        public string CountryID;
        
        /// <remarks/>
        public string EMail;
        
        /// <remarks/>
        public string Phone;
        
        /// <remarks/>
        public string Fax;
        
        /// <remarks/>
        public System.DateTime VerifiedOn;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool VerifiedOnSpecified;
        
        /// <remarks/>
        public string Salutation;
        
        /// <remarks/>
        public string Title;
        
        /// <remarks/>
        public string FirstName;
        
        /// <remarks/>
        public string MiddleName;
        
        /// <remarks/>
        public string LastName;
        
        /// <remarks/>
        public string EMailPrivate;
        
        /// <remarks/>
        public string EMailBusiness;
        
        /// <remarks/>
        public string PhonePrivate;
        
        /// <remarks/>
        public string PhoneBusiness;
        
        /// <remarks/>
        public string PhoneCell;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        public string Gender;
        
        /// <remarks/>
        public string Company;
        
        /// <remarks/>
        public string Department;
        
        /// <remarks/>
        public string JobTitle;
        
        /// <remarks/>
        public System.DateTime Birthday;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool BirthdaySpecified;
        
        /// <remarks/>
        public string VATID;
        
        /// <remarks/>
        public string BankCode;
        
        /// <remarks/>
        public string BankName;
        
        /// <remarks/>
        public string BankAccountNo;
        
        /// <remarks/>
        public string BankAccountHolder;
        
        /// <remarks/>
        public string URL;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TCreate_Return {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public bool created;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool createdSpecified;
        
        /// <remarks/>
        public TError Error;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TError {
        
        /// <remarks/>
        public string Message;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TCreate_Input {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string LocaleID;
        
        /// <remarks/>
        public string LanguageCode;
        
        /// <remarks/>
        public string CurrencyID;
        
        /// <remarks/>
        public string Password;
        
        /// <remarks/>
        public bool IsActivated;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsActivatedSpecified;
        
        /// <remarks/>
        public bool DeleteConfirmation;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool DeleteConfirmationSpecified;
        
        /// <remarks/>
        public bool IsLoginCookieAllowed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsLoginCookieAllowedSpecified;
        
        /// <remarks/>
        public bool IsHtmlEMailAllowed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsHtmlEMailAllowedSpecified;
        
        /// <remarks/>
        public string ReminderQuestion;
        
        /// <remarks/>
        public string ChallengePhrase;
        
        /// <remarks/>
        public string EMail;
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public TAddress BillingAddress;
        
        /// <remarks/>
        public TAddress ShippingAddress;
        
        /// <remarks/>
        public string[] Customers;
        
        /// <remarks/>
        public TAttribute[] Attributes;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TAttribute {
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public string Value;
        
        /// <remarks/>
        public TLocalizedValue[] LocalizedValues;
        
        /// <remarks/>
        public string Type;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TLocalizedValue {
        
        /// <remarks/>
        public string LanguageCode;
        
        /// <remarks/>
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TUpdate_Return {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public bool updated;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool updatedSpecified;
        
        /// <remarks/>
        public TError Error;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TUpdate_Input {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public string LocaleID;
        
        /// <remarks/>
        public string LanguageCode;
        
        /// <remarks/>
        public string CurrencyID;
        
        /// <remarks/>
        public string Password;
        
        /// <remarks/>
        public bool IsActivated;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsActivatedSpecified;
        
        /// <remarks/>
        public bool DeleteConfirmation;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool DeleteConfirmationSpecified;
        
        /// <remarks/>
        public bool IsLoginCookieAllowed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsLoginCookieAllowedSpecified;
        
        /// <remarks/>
        public bool IsHtmlEMailAllowed;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsHtmlEMailAllowedSpecified;
        
        /// <remarks/>
        public string ReminderQuestion;
        
        /// <remarks/>
        public string ChallengePhrase;
        
        /// <remarks/>
        public string EMail;
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public TAddress BillingAddress;
        
        /// <remarks/>
        public TAddress ShippingAddress;
        
        /// <remarks/>
        public string[] Customers;
        
        /// <remarks/>
        public TAttribute[] Attributes;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TDelete_Return {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public bool deleted;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool deletedSpecified;
        
        /// <remarks/>
        public TError Error;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/UserTypes/2005/01")]
    public partial class TExists_Return {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public bool exists;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool existsSpecified;
        
        /// <remarks/>
        public TError Error;
    }
}