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
    [System.Xml.Serialization.XmlTypeAttribute("ФайлДокумент", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлДокумент
    {
        
        /// <summary>
        /// <para>Сведения о счете-фактуре (содержание факта хозяйственной жизни 1-  сведения об участниках факта хозяйственной жизни, основаниях и обстоятельствах его проведения)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о счете-фактуре (содержание факта хозяйственной жизни 1- сведения об уча" +
            "стниках факта хозяйственной жизни, основаниях и обстоятельствах его проведения)")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("СвСчФакт", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокументСвСчФакт СвСчФакт { get; set; }
        
        /// <summary>
        /// <para>Сведения таблицы счета-фактуры (содержание факта хозяйственной жизни 2 - наименование и другая информация об отгруженных товарах (выполненных работах, оказанных услугах), о переданных имущественных правах</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения таблицы счета-фактуры (содержание факта хозяйственной жизни 2 - наименов" +
            "ание и другая информация об отгруженных товарах (выполненных работах, оказанных " +
            "услугах), о переданных имущественных правах")]
        [System.Xml.Serialization.XmlElementAttribute("ТаблСчФакт", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокументТаблСчФакт ТаблСчФакт { get; set; }
        
        /// <summary>
        /// <para>Содержание факта хозяйственной жизни 3 – сведения о факте отгрузки товаров (выполнения работ), передачи имущественных прав (о предъявлении оказанных услуг)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Содержание факта хозяйственной жизни 3 – сведения о факте отгрузки товаров (выпол" +
            "нения работ), передачи имущественных прав (о предъявлении оказанных услуг)")]
        [System.Xml.Serialization.XmlElementAttribute("СвПродПер", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокументСвПродПер СвПродПер { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ФайлДокументПодписант> _подписант;
        
        /// <summary>
        /// <para>Сведения о лице, подписывающем файл обмена счета-фактуры (информации продавца) в электронной форме</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о лице, подписывающем файл обмена счета-фактуры (информации продавца) в " +
            "электронной форме")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Подписант", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ФайлДокументПодписант> Подписант
        {
            get
            {
                return this._подписант;
            }
            private set
            {
                this._подписант = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ФайлДокумент" /> class.</para>
        /// </summary>
        public ФайлДокумент()
        {
            this._подписант = new System.Collections.ObjectModel.Collection<ФайлДокументПодписант>();
        }
        
        /// <summary>
        /// <para>Код документа  по КНД</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Код документа по КНД")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("КНД")]
        public ФайлДокументКНД КНД { get; set; }
        
        /// <summary>
        /// <para>Функция</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 6.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Функция")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(6)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Функция")]
        public string Функция { get; set; }
        
        /// <summary>
        /// <para>Наименование документа по факту хозяйственной жизни</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Наименование документа по факту хозяйственной жизни")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("ПоФактХЖ")]
        public string ПоФактХЖ { get; set; }
        
        /// <summary>
        /// <para>Наименование первичного документа, определенное организацией (согласованное сторонами сделки)</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Наименование первичного документа, определенное организацией (согласованное сторо" +
            "нами сделки)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("НаимДокОпр")]
        public string НаимДокОпр { get; set; }
        
        /// <summary>
        /// <para>Дата формирования файла обмена счета-фактуры (информации продавца)</para>
        /// <para>Дата в формате ДД.ММ.ГГГГ (01.01.1900 - 31.12.2099)</para>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// <para xml:lang="en">Pattern: ((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\.(01|0[3-9]{1}|1[0-2]{1}))|(31\.(01|03|05|07|08|10|12)))\.((19|20)[0-9]{2}))|(29\.02\.((19|20)(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6))))).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дата формирования файла обмена счета-фактуры (информации продавца)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\\.(01|0[3-9]{1" +
            "}|1[0-2]{1}))|(31\\.(01|03|05|07|08|10|12)))\\.((19|20)[0-9]{2}))|(29\\.02\\.((19|20" +
            ")(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6)))))")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ДатаИнфПр")]
        public string ДатаИнфПр { get; set; }
        
        /// <summary>
        /// <para>Время формирования файла обмена счета-фактуры (информации продавца)</para>
        /// <para>Время в формате ЧЧ.ММ.СС</para>
        /// <para xml:lang="en">Minimum length: 8.</para>
        /// <para xml:lang="en">Maximum length: 8.</para>
        /// <para xml:lang="en">Pattern: ([0-1]{1}[0-9]{1}|2[0-3]{1})\.([0-5]{1}[0-9]{1})\.([0-5]{1}[0-9]{1}).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Время формирования файла обмена счета-фактуры (информации продавца)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(8)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(8)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-1]{1}[0-9]{1}|2[0-3]{1})\\.([0-5]{1}[0-9]{1})\\.([0-5]{1}[0-9]{1})")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ВремИнфПр")]
        public string ВремИнфПр { get; set; }
        
        /// <summary>
        /// <para>Наименование экономического субъекта – составителя файла обмена счета-фактуры (информации продавца)</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 1000.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Наименование экономического субъекта – составителя файла обмена счета-фактуры (ин" +
            "формации продавца)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1000)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("НаимЭконСубСост")]
        public string НаимЭконСубСост { get; set; }
        
        /// <summary>
        /// <para>Основание, по которому экономический субъект является составителем файла обмена счета-фактуры (информации продавца)</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 120.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Основание, по которому экономический субъект является составителем файла обмена с" +
            "чета-фактуры (информации продавца)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(120)]
        [System.Xml.Serialization.XmlAttributeAttribute("ОснДоверОргСост")]
        public string ОснДоверОргСост { get; set; }
        
        /// <summary>
        /// <para>Информация о наличии согласованной структуры дополнительных информационных полей</para>
        /// <para xml:lang="en">Minimum length: 14.</para>
        /// <para xml:lang="en">Maximum length: 14.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Информация о наличии согласованной структуры дополнительных информационных полей")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(14)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(14)]
        [System.Xml.Serialization.XmlAttributeAttribute("СоглСтрДопИнф")]
        public string СоглСтрДопИнф { get; set; }
    }
}
