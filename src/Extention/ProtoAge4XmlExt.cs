﻿namespace ProjectCeleste.GameFiles.XMLParser.Extention
{
    public static class ProtoAge4XmlExt
    {
        public static string GetDisplayNameLocalized(this ProtoAge4XmlUnit item, LanguagesXml languages,
            string language = "English")
        {
            return languages["stringtablex"]["English"][item.DisplayNameId].Text;
        }

        public static string GetRolloverTextLocalized(this ProtoAge4XmlUnit item, LanguagesXml languages,
            string language = "English")
        {
            return languages["stringtablex"]["English"][item.RolloverTextId].Text;
        }
    }
}