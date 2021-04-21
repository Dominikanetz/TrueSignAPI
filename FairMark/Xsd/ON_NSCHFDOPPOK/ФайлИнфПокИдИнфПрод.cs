//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace FairMark.Xsd.ON_NSCHFDOPPOK
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ФайлИнфПокИдИнфПрод", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлИнфПокИдИнфПрод
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _эП;
        
        /// <summary>
        /// <para>Электронная подпись файла обмена информации продавца</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Электронная подпись файла обмена информации продавца")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ЭП", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<string> ЭП
        {
            get
            {
                return this._эП;
            }
            private set
            {
                this._эП = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ФайлИнфПокИдИнфПрод" /> class.</para>
        /// </summary>
        public ФайлИнфПокИдИнфПрод()
        {
            this._эП = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// <para>Идентификатор файла обмена информации продавца</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Идентификатор файла обмена информации продавца")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ИдФайлИнфПр")]
        public string ИдФайлИнфПр { get; set; }
        
        /// <summary>
        /// <para>Дата формирования файла обмена информации продавца</para>
        /// <para>Дата в формате ДД.ММ.ГГГГ (01.01.1900 - 31.12.2099)</para>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// <para xml:lang="en">Pattern: ((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\.(01|0[3-9]{1}|1[0-2]{1}))|(31\.(01|03|05|07|08|10|12)))\.((19|20)[0-9]{2}))|(29\.02\.((19|20)(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6))))).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дата формирования файла обмена информации продавца")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\\.(01|0[3-9]{1" +
            "}|1[0-2]{1}))|(31\\.(01|03|05|07|08|10|12)))\\.((19|20)[0-9]{2}))|(29\\.02\\.((19|20" +
            ")(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6)))))")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ДатаФайлИнфПр")]
        public string ДатаФайлИнфПр { get; set; }
        
        /// <summary>
        /// <para>Время формирования файла обмена информации продавца</para>
        /// <para>Время в формате ЧЧ.ММ.СС</para>
        /// <para xml:lang="en">Minimum length: 8.</para>
        /// <para xml:lang="en">Maximum length: 8.</para>
        /// <para xml:lang="en">Pattern: ([0-1]{1}[0-9]{1}|2[0-3]{1})\.([0-5]{1}[0-9]{1})\.([0-5]{1}[0-9]{1}).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Время формирования файла обмена информации продавца")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(8)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(8)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-1]{1}[0-9]{1}|2[0-3]{1})\\.([0-5]{1}[0-9]{1})\\.([0-5]{1}[0-9]{1})")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ВремФайлИнфПр")]
        public string ВремФайлИнфПр { get; set; }
    }
}
