namespace ProjectCeleste.GameFiles.XMLParser.Extention
{
    public static class EconQuestXmlExt
    {
        public static string GetDisplayNameLocalized(this EconQuestXml item, LanguagesXml languages,
            string language = "English")
        {
            return languages["stringtablex"][language][item.DisplayNameId].Text;
        }

        public static string GetRollOverTextLocalized(this EconQuestXml item, LanguagesXml languages,
            string language = "English")
        {
            return languages["stringtablex"][language][item.RollOverTextId].Text;
        }
    }
}