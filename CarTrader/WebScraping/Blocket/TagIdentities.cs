using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarTrader.WebScraping.Blocket
{
    public class TagIdentities
    {
        public const string AdListContainer = "//div[@class='SearchResults__SearchResultsWrapper-sc-10sdzls-0 kjiDYK']";
        public const string SingleAdContainer = "//div[@class='styled__Wrapper-sc-1kpvi4z-0 DeGCK']";
        public const string AdImageWrapper = "//div[@class='styled__ImageWrapper-sc-1kpvi4z-4 iHtASN']";
        public const string AdImageResource = "//img[@class='ListImage__StyledPictureTag-sc-1rp77jc-1 bLvasA']";
        public const string AdInfoWrapper = "//div[@class='styled__Content-sc-1kpvi4z-2 kNOXVD']";
        /// <summary>
        /// This wrapper contains the URL for the ad in the href Attribute (use .GetAttribute("href") on this node).
        /// </summary>
        public const string AdInfoURL = "//a[@class='styled__Content-sc-1kpvi4z-2 kNOXVD']";
        public const string AdInfoTitle = "//span[@class='styled__SubjectContainer-sc-1kpvi4z-11 eGibtr']";
        /// <summary>
        /// This identity contains information about dealer type (shop/private), vehicle category, location and timestamp of ad listing.
        /// </summary>
        //public const string AdDealerInfoTimestamp = "//div[@class='styled__LocationTimeWrapper-sc-1kpvi4z-19 fzLnEY']";
        public const string AdDealerType = "//span[@class='AdvertiserTypeSymbol__Badge-sc-54a824-0 bClplk']";
        /// <summary>
        /// Use SelectNodes(AdListingCategoryAndLocation) due to it having 2 values (Category & location) then extract the index of the value you want. [0] for Category [1] for Location.
        /// </summary>
        public const string AdListingCategoryAndLocation = "//a[@class='Link-sc-6wulv7-0 TopInfoLink__StyledLink-sc-lzfj8j-0 kWpDHB eHeFrO']";
        /// <summary>
        /// Formatted as Idag hh:mm, Igår hh:mm, lördags hh:mm etc...
        /// </summary>
        public const string AdListingTimetamp = "//p[@class='styled__Time-sc-1kpvi4z-20 hjqsiB']";
        public const string AdPriceWithTax = "//div[@class='Price__StyledPrice-sc-1v2maoc-1 dmOeSM']";
        public const string AdPriceNoTax = "//div[@class='TextCallout2__TextCallout2Wrapper-sc-1bir8f0-0 bMDAUd Price__StyledVatPrice-sc-1v2maoc-2 dsIaZe']";
        /// <summary>
        /// Contains information about the car model year [0], fuel type [1], mileage [2], gearbox[3]. Call SelectNodes() on this tag and extract indexes.
        /// </summary>
        public const string CarSpecs = "//li[@class='ParametersList__ListItem-sc-18ndpo4-2 hvEqok']";
        public const string AdListingCompany = "//div[@class='TextCallout2__TextCallout2Wrapper-sc-1bir8f0-0 bMDAUd StoreInfo__StoreName-sc-t7web5-0 eDijCV']";

    }
}
