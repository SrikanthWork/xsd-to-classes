//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by the XsdToClasses tool.
//     Tool Version:    1.2.23.0
//     Runtime Version: 4.0.30319.18052
//     Generated on:    02/08/2013 15:21:16
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
// Workaround for bug http://lab.msdn.microsoft.com/productfeedback/viewfeedback.aspx?feedbackid=d457a36e-0ce8-4368-9a27-92762860d8e1
#pragma warning disable 1591
namespace BlueToque.XmlLibrary.CodeModifiers.Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18054")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://BlueToque.ca/CodeGeneration/CodeModifiers/CategoryProperty.Options")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://BlueToque.ca/CodeGeneration/CodeModifiers/CategoryProperty.Options", IsNullable=false)]
    public partial class CategoryPropertyOptions : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private CategoryTypeCollection propertyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public CategoryTypeCollection Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
                this.RaisePropertyChanged("Property");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18054")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://BlueToque.ca/CodeGeneration/CodeModifiers/CategoryProperty.Options")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://BlueToque.ca/CodeGeneration/CodeModifiers/CategoryProperty.Options", IsNullable=true)]
    public partial class CategoryType : PropertyType {
        
        /// <summary />
        private string categoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("Category");
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://BlueToque.ca/CodeGeneration/CodeModifiers/CategoryProperty.Options")]
    public partial class CategoryTypeCollection : System.Collections.Generic.List<CategoryType> {
    }
}
#pragma warning restore 1591