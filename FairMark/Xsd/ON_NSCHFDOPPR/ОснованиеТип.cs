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
    
    
    /// <summary>
    /// <para>Основание отгрузки (передачи, уступки)</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Основание отгрузки (передачи, уступки)")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ОснованиеТип", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ОснованиеТип
    {
        
        /// <summary>
        /// <para>Наименование документа - основания</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Наименование документа - основания")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("НаимОсн")]
        public string НаимОсн { get; set; }
        
        /// <summary>
        /// <para>Номер документа - основания</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Номер документа - основания")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("НомОсн")]
        public string НомОсн { get; set; }
        
        /// <summary>
        /// <para>Дата документа - основания</para>
        /// <para>Дата в формате ДД.ММ.ГГГГ (01.01.1900 - 31.12.2099)</para>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// <para xml:lang="en">Pattern: ((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\.(01|0[3-9]{1}|1[0-2]{1}))|(31\.(01|03|05|07|08|10|12)))\.((19|20)[0-9]{2}))|(29\.02\.((19|20)(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6))))).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дата документа - основания")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\\.(01|0[3-9]{1" +
            "}|1[0-2]{1}))|(31\\.(01|03|05|07|08|10|12)))\\.((19|20)[0-9]{2}))|(29\\.02\\.((19|20" +
            ")(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6)))))")]
        [System.Xml.Serialization.XmlAttributeAttribute("ДатаОсн")]
        public string ДатаОсн { get; set; }
        
        /// <summary>
        /// <para>Дополнительные сведения</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 1000.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дополнительные сведения")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1000)]
        [System.Xml.Serialization.XmlAttributeAttribute("ДопСвОсн")]
        public string ДопСвОсн { get; set; }
        
        /// <summary>
        /// <para>Идентификатор документа - основания</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Идентификатор документа - основания")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("ИдентОсн")]
        public string ИдентОсн { get; set; }
    }
}
