//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace FairMark.Xsd.ON_NSCHFDOPPR
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ФайлДокументСвПродПерИнфПолФХЖ3", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлДокументСвПродПерИнфПолФХЖ3
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ТекстИнфТип> _текстИнф;
        
        /// <summary>
        /// <para>Текстовая информация</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Текстовая информация")]
        [System.Xml.Serialization.XmlElementAttribute("ТекстИнф", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ТекстИнфТип> ТекстИнф
        {
            get
            {
                return this._текстИнф;
            }
            private set
            {
                this._текстИнф = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ТекстИнф collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ТекстИнфSpecified
        {
            get
            {
                return (this.ТекстИнф.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ФайлДокументСвПродПерИнфПолФХЖ3" /> class.</para>
        /// </summary>
        public ФайлДокументСвПродПерИнфПолФХЖ3()
        {
            this._текстИнф = new System.Collections.ObjectModel.Collection<ТекстИнфТип>();
        }
        
        /// <summary>
        /// <para>Идентификатор файла информационного поля</para>
        /// <para xml:lang="en">Minimum length: 36.</para>
        /// <para xml:lang="en">Maximum length: 36.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Идентификатор файла информационного поля")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(36)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(36)]
        [System.Xml.Serialization.XmlAttributeAttribute("ИдФайлИнфПол")]
        public string ИдФайлИнфПол { get; set; }
    }
}
