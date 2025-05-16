using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarTrader.WebScraping
{
    public interface IScrapeLogic
    {
        string FindHTMLTagValue(HtmlNode node, string target);
        string[] FindMultipleHTMLTagValue(HtmlNode node, string target);
        HtmlDocument LoadDocumentFromWebUrl(string url);
    }
}
