using Newtonsoft.Json;

namespace Nosikov.Wildberries;

    public class Color
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("id")]
        public int Id;
    }

    public class ContextMetadata
    {
    }

    public class Data
    {
        [JsonProperty("products")]
        public List<Product> Products;
    }

    public class Log
    {
        [JsonProperty("cpm")]
        public int Cpm;

        [JsonProperty("promotion")]
        public int Promotion;

        [JsonProperty("promoPosition")]
        public int PromoPosition;

        [JsonProperty("position")]
        public int Position;

        [JsonProperty("advertId")]
        public int AdvertId;

        [JsonProperty("tp")]
        public string Tp;
    }

    public class Metadata
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("catalog_type")]
        public string CatalogType;

        [JsonProperty("catalog_value")]
        public string CatalogValue;

        [JsonProperty("normquery")]
        public string Normquery;

        [JsonProperty("context_metadata")]
        public ContextMetadata ContextMetadata;
    }

    public class Params
    {
        [JsonProperty("version")]
        public int Version;

        [JsonProperty("curr")]
        public string Curr;

        [JsonProperty("spp")]
        public int Spp;

        [JsonProperty("dest")]
        public int Dest;

        [JsonProperty("payloadVersion")]
        public int PayloadVersion;
    }

    public class Product
    {
        [JsonProperty("time1")]
        public int Time1;

        [JsonProperty("time2")]
        public int Time2;

        [JsonProperty("dist")]
        public int Dist;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("root")]
        public int Root;

        [JsonProperty("kindId")]
        public int KindId;

        [JsonProperty("brand")]
        public string Brand;

        [JsonProperty("brandId")]
        public int BrandId;

        [JsonProperty("siteBrandId")]
        public int SiteBrandId;

        [JsonProperty("colors")]
        public List<Color> Colors;

        [JsonProperty("subjectId")]
        public int SubjectId;

        [JsonProperty("subjectParentId")]
        public int SubjectParentId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("supplier")]
        public string Supplier;

        [JsonProperty("supplierId")]
        public int SupplierId;

        [JsonProperty("supplierRating")]
        public double SupplierRating;

        [JsonProperty("priceU")]
        public int PriceU;

        [JsonProperty("salePriceU")]
        public int SalePriceU;

        [JsonProperty("sale")]
        public int Sale;

        [JsonProperty("logisticsCost")]
        public int LogisticsCost;

        [JsonProperty("returnCost")]
        public int ReturnCost;

        [JsonProperty("diffPrice")]
        public bool DiffPrice;

        [JsonProperty("saleConditions")]
        public int SaleConditions;

        [JsonProperty("pics")]
        public int Pics;

        [JsonProperty("rating")]
        public int Rating;

        [JsonProperty("reviewRating")]
        public double ReviewRating;

        [JsonProperty("feedbacks")]
        public int Feedbacks;

        [JsonProperty("volume")]
        public int Volume;

        [JsonProperty("viewFlags")]
        public int ViewFlags;

        [JsonProperty("sizes")]
        public List<Size> Sizes;

        [JsonProperty("log")]
        public Log Log;

        [JsonProperty("panelPromoId")]
        public int? PanelPromoId;

        [JsonProperty("promoTextCard")]
        public string PromoTextCard;

        [JsonProperty("promoTextCat")]
        public string PromoTextCat;
    }


    public class WbSearchResult
    {
        [JsonProperty("metadata")]
        public Metadata Metadata;

        [JsonProperty("state")]
        public int State;

        [JsonProperty("version")]
        public int Version;

        [JsonProperty("params")]
        public Params Params;

        [JsonProperty("data")]
        public Data Data;
    }

    public class Size
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("origName")]
        public string OrigName;

        [JsonProperty("rank")]
        public int Rank;

        [JsonProperty("optionId")]
        public int OptionId;

        [JsonProperty("wh")]
        public int Wh;

        [JsonProperty("returnCost")]
        public int ReturnCost;

        [JsonProperty("sign")]
        public string Sign;

        [JsonProperty("payload")]
        public string Payload;

        [JsonProperty("priceU")]
        public int? PriceU;

        [JsonProperty("salePriceU")]
        public int? SalePriceU;

        [JsonProperty("sale")]
        public int? Sale;

        [JsonProperty("logisticsCost")]
        public int? LogisticsCost;
    }



