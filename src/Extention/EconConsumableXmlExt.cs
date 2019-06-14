namespace ProjectCeleste.GameFiles.XMLParser.Extention
{
    public static class EconConsumableXmlExt
    {
        public static string GetDisplayNameLocalized(this EconConsumableXml item, LanguagesXml languages,
            string language = "English")
        {
            return languages["stringtablex"][language][item.DisplayNameId].Text;
        }

        public static string GetRollOverTextLocalized(this EconConsumableXml item, LanguagesXml languages,
            string language = "English")
        {
            return languages["stringtablex"][language][item.RollOverTextId].Text;
        }
    }
}