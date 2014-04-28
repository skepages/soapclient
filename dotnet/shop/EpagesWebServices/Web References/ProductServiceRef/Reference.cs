//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpagesWebServices.ProductServiceRef {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_Product_SOAP", Namespace="urn://epages.de/WebService/ProductService/2005/01")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TCreate_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TCreate_Input))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TUpdate_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TUpdate_Input))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TDelete_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TExists_Return))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TProductPrice))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TAttribute))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TLocalizedValue))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TGetInfo_Return))]
    public partial class ProductService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ProductService() {
            this.Url = "http://localhost/epages/Store.soap";
        }
        
        public ProductService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductService/2005/01#getInfo", RequestNamespace="urn://epages.de/WebService/ProductService/2005/01", ResponseNamespace="urn://epages.de/WebService/ProductService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Products")]
        public TGetInfo_Return[] getInfo(string[] Products, string[] Attributes, string[] LanguageCodes) {
            object[] results = this.Invoke("getInfo", new object[] {
                        Products,
                        Attributes,
                        LanguageCodes});
            return ((TGetInfo_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetInfo(string[] Products, string[] Attributes, string[] LanguageCodes, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getInfo", new object[] {
                        Products,
                        Attributes,
                        LanguageCodes}, callback, asyncState);
        }
        
        /// <remarks/>
        public TGetInfo_Return[] EndgetInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TGetInfo_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductService/2005/01#exists", RequestNamespace="urn://epages.de/WebService/ProductService/2005/01", ResponseNamespace="urn://epages.de/WebService/ProductService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Products")]
        public TExists_Return[] exists(string[] Products) {
            object[] results = this.Invoke("exists", new object[] {
                        Products});
            return ((TExists_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexists(string[] Products, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exists", new object[] {
                        Products}, callback, asyncState);
        }
        
        /// <remarks/>
        public TExists_Return[] Endexists(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TExists_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductService/2005/01#delete", RequestNamespace="urn://epages.de/WebService/ProductService/2005/01", ResponseNamespace="urn://epages.de/WebService/ProductService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Products")]
        public TDelete_Return[] delete(string[] Products) {
            object[] results = this.Invoke("delete", new object[] {
                        Products});
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begindelete(string[] Products, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("delete", new object[] {
                        Products}, callback, asyncState);
        }
        
        /// <remarks/>
        public TDelete_Return[] Enddelete(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TDelete_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductService/2005/01#update", RequestNamespace="urn://epages.de/WebService/ProductService/2005/01", ResponseNamespace="urn://epages.de/WebService/ProductService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Products")]
        public TUpdate_Return[] update(TUpdate_Input[] Products) {
            object[] results = this.Invoke("update", new object[] {
                        Products});
            return ((TUpdate_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginupdate(TUpdate_Input[] Products, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("update", new object[] {
                        Products}, callback, asyncState);
        }
        
        /// <remarks/>
        public TUpdate_Return[] Endupdate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TUpdate_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductService/2005/01#create", RequestNamespace="urn://epages.de/WebService/ProductService/2005/01", ResponseNamespace="urn://epages.de/WebService/ProductService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Products")]
        public TCreate_Return[] create(TCreate_Input[] Products) {
            object[] results = this.Invoke("create", new object[] {
                        Products});
            return ((TCreate_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Begincreate(TCreate_Input[] Products, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("create", new object[] {
                        Products}, callback, asyncState);
        }
        
        /// <remarks/>
        public TCreate_Return[] Endcreate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TCreate_Return[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductService/2005/01#find", RequestNamespace="urn://epages.de/WebService/ProductService/2005/01", ResponseNamespace="urn://epages.de/WebService/ProductService/2005/01")]
        [return: System.Xml.Serialization.SoapElementAttribute("Products")]
        public string[] find(TFind_Input SearchParameters) {
            object[] results = this.Invoke("find", new object[] {
                        SearchParameters});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginfind(TFind_Input SearchParameters, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("find", new object[] {
                        SearchParameters}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] Endfind(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
    public partial class TGetInfo_Return {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string Class;
        
        /// <remarks/>
        public TLocalizedValue[] Name;
        
        /// <remarks/>
        public TLocalizedValue[] Description;
        
        /// <remarks/>
        public TLocalizedValue[] LongDescription;
        
        /// <remarks/>
        public TLocalizedValue[] Keywords;
        
        /// <remarks/>
        public string TaxClass;
        
        /// <remarks/>
        public bool IsVisible;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsVisibleSpecified;
        
        /// <remarks/>
        public bool IsNew;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsNewSpecified;
        
        /// <remarks/>
        public bool IsDailyPrice;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsDailyPriceSpecified;
        
        /// <remarks/>
        public string OrderUnit;
        
        /// <remarks/>
        public float PriceQuantity;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool PriceQuantitySpecified;
        
        /// <remarks/>
        public float MinOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool MinOrderSpecified;
        
        /// <remarks/>
        public float IntervalOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IntervalOrderSpecified;
        
        /// <remarks/>
        public string WeightUnit;
        
        /// <remarks/>
        public float Weight;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WeightSpecified;
        
        /// <remarks/>
        public string RefUnit;
        
        /// <remarks/>
        public float RefAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool RefAmountSpecified;
        
        /// <remarks/>
        public float RefContentAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool RefContentAmountSpecified;
        
        /// <remarks/>
        public float StockLevel;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool StockLevelSpecified;
        
        /// <remarks/>
        public float StockLevelAlert;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool StockLevelAlertSpecified;
        
        /// <remarks/>
        public string Manufacturer;
        
        /// <remarks/>
        public string ManufacturerSKU;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        public string DeliveryPeriod;
        
        /// <remarks/>
        public float Length;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool LengthSpecified;
        
        /// <remarks/>
        public float Width;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WidthSpecified;
        
        /// <remarks/>
        public float Height;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HeightSpecified;
        
        /// <remarks/>
        public string WebUrl;
        
        /// <remarks/>
        public string SuperProduct;
        
        /// <remarks/>
        public string[] SubProducts;
        
        /// <remarks/>
        public string DefaultSubProduct;
        
        /// <remarks/>
        public bool IsDefault;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsDefaultSpecified;
        
        /// <remarks/>
        public bool HasSubOwnPrices;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HasSubOwnPricesSpecified;
        
        /// <remarks/>
        public TAttribute[] VariationAttributes;
        
        /// <remarks/>
        public TProductPrice[] ProductPrices;
        
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductService/2005/01")]
    public partial class TFind_Input {
        
        /// <remarks/>
        public string Text;
        
        /// <remarks/>
        public string LanguageCode;
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string Class;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
    public partial class TCreate_Input {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string Class;
        
        /// <remarks/>
        public TLocalizedValue[] Name;
        
        /// <remarks/>
        public TLocalizedValue[] Description;
        
        /// <remarks/>
        public TLocalizedValue[] LongDescription;
        
        /// <remarks/>
        public TLocalizedValue[] Keywords;
        
        /// <remarks/>
        public string TaxClass;
        
        /// <remarks/>
        public bool IsVisible;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsVisibleSpecified;
        
        /// <remarks/>
        public bool IsNew;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsNewSpecified;
        
        /// <remarks/>
        public bool IsDailyPrice;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsDailyPriceSpecified;
        
        /// <remarks/>
        public string OrderUnit;
        
        /// <remarks/>
        public float PriceQuantity;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool PriceQuantitySpecified;
        
        /// <remarks/>
        public float MinOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool MinOrderSpecified;
        
        /// <remarks/>
        public float IntervalOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IntervalOrderSpecified;
        
        /// <remarks/>
        public string WeightUnit;
        
        /// <remarks/>
        public float Weight;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WeightSpecified;
        
        /// <remarks/>
        public string RefUnit;
        
        /// <remarks/>
        public float RefAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool RefAmountSpecified;
        
        /// <remarks/>
        public float RefContentAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool RefContentAmountSpecified;
        
        /// <remarks/>
        public float StockLevel;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool StockLevelSpecified;
        
        /// <remarks/>
        public float StockLevelAlert;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool StockLevelAlertSpecified;
        
        /// <remarks/>
        public string Manufacturer;
        
        /// <remarks/>
        public string ManufacturerSKU;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        public string DeliveryPeriod;
        
        /// <remarks/>
        public float Length;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool LengthSpecified;
        
        /// <remarks/>
        public float Width;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WidthSpecified;
        
        /// <remarks/>
        public float Height;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HeightSpecified;
        
        /// <remarks/>
        public string SuperProduct;
        
        /// <remarks/>
        public string DefaultSubProduct;
        
        /// <remarks/>
        public bool IsDefault;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsDefaultSpecified;
        
        /// <remarks/>
        public bool HasSubOwnPrices;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HasSubOwnPricesSpecified;
        
        /// <remarks/>
        public TAttribute[] VariationAttributes;
        
        /// <remarks/>
        public TProductPrice[] ProductPrices;
        
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
    public partial class TProductPrice {
        
        /// <remarks/>
        public float Price;
        
        /// <remarks/>
        public string CurrencyID;
        
        /// <remarks/>
        public string TaxModel;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
    public partial class TUpdate_Input {
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public string Class;
        
        /// <remarks/>
        public TLocalizedValue[] Name;
        
        /// <remarks/>
        public TLocalizedValue[] Description;
        
        /// <remarks/>
        public TLocalizedValue[] LongDescription;
        
        /// <remarks/>
        public TLocalizedValue[] Keywords;
        
        /// <remarks/>
        public string TaxClass;
        
        /// <remarks/>
        public bool IsVisible;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsVisibleSpecified;
        
        /// <remarks/>
        public bool IsNew;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsNewSpecified;
        
        /// <remarks/>
        public bool IsDailyPrice;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsDailyPriceSpecified;
        
        /// <remarks/>
        public string OrderUnit;
        
        /// <remarks/>
        public float PriceQuantity;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool PriceQuantitySpecified;
        
        /// <remarks/>
        public float MinOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool MinOrderSpecified;
        
        /// <remarks/>
        public float IntervalOrder;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IntervalOrderSpecified;
        
        /// <remarks/>
        public string WeightUnit;
        
        /// <remarks/>
        public float Weight;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WeightSpecified;
        
        /// <remarks/>
        public string RefUnit;
        
        /// <remarks/>
        public float RefAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool RefAmountSpecified;
        
        /// <remarks/>
        public float RefContentAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool RefContentAmountSpecified;
        
        /// <remarks/>
        public float StockLevel;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool StockLevelSpecified;
        
        /// <remarks/>
        public float StockLevelAlert;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool StockLevelAlertSpecified;
        
        /// <remarks/>
        public string Manufacturer;
        
        /// <remarks/>
        public string ManufacturerSKU;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType="integer")]
        public string DeliveryPeriod;
        
        /// <remarks/>
        public float Length;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool LengthSpecified;
        
        /// <remarks/>
        public float Width;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool WidthSpecified;
        
        /// <remarks/>
        public float Height;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HeightSpecified;
        
        /// <remarks/>
        public string DefaultSubProduct;
        
        /// <remarks/>
        public bool IsDefault;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsDefaultSpecified;
        
        /// <remarks/>
        public bool HasSubOwnPrices;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool HasSubOwnPricesSpecified;
        
        /// <remarks/>
        public TProductPrice[] ProductPrices;
        
        /// <remarks/>
        public TAttribute[] Attributes;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductTypes/2005/01")]
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
