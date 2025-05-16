using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CarTrader.WebScraping
{
    public class ScrapeLogic : IScrapeLogic
    {
        public string FindHTMLTagValue(HtmlNode node, string target)
        {
            string result = node.SelectSingleNode(target).InnerText;
            return result;
        }

        public string[] FindMultipleHTMLTagValue(HtmlNode node, string target)
        {
            string[] result = node.SelectNodes(target)
                .Select(x => x.InnerText)
                .ToArray();
            return result;
        }

        public HtmlDocument LoadDocumentFromWebUrl(string url)
        {
            WebClient client = new WebClient();
            string documentData = client.DownloadString(url);
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(documentData);
            return htmlDoc;
        }
    }
}
