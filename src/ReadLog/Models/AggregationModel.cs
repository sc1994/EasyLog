// Generated by https://quicktype.io

namespace ReadLog.Models.AggregationModel
{
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AggregationModel
    {
        [JsonProperty("took")]
        public long Took { get; set; }

        [JsonProperty("timed_out")]
        public bool TimedOut { get; set; }

        [JsonProperty("_shards")]
        public AggregationsShards Shards { get; set; }

        [JsonProperty("hits")]
        public AggregationsHits Hits { get; set; }

        [JsonProperty("aggregations")]
        public Aggregations Aggregations { get; set; }

        public static AggregationModel FromJson(string json) => JsonConvert.DeserializeObject<AggregationModel>(json, Converter.Settings);
    }

    public static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                }
        };
    }

    public partial class Aggregations
    {
        [JsonProperty("apps")]
        public AggregationsApps Apps { get; set; }
    }

    public partial class AggregationsApps
    {
        [JsonProperty("doc_count_error_upper_bound")]
        public long DocCountErrorUpperBound { get; set; }

        [JsonProperty("sum_other_doc_count")]
        public long SumOtherDocCount { get; set; }

        [JsonProperty("buckets")]
        public AggregationsAppsBucket[] Buckets { get; set; }
    }

    public partial class AggregationsAppsBucket
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("doc_count")]
        public long DocCount { get; set; }

        [JsonProperty("modules")]
        public AggregationsModules Modules { get; set; }
    }

    public partial class AggregationsModules
    {
        [JsonProperty("doc_count_error_upper_bound")]
        public long DocCountErrorUpperBound { get; set; }

        [JsonProperty("sum_other_doc_count")]
        public long SumOtherDocCount { get; set; }

        [JsonProperty("buckets")]
        public AggregationsModulesBucket[] Buckets { get; set; }
    }

    public partial class AggregationsModulesBucket
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("doc_count")]
        public long DocCount { get; set; }

        [JsonProperty("categorys")]
        public AggregationsCategorys Categorys { get; set; }
    }

    public partial class AggregationsCategorys
    {
        [JsonProperty("doc_count_error_upper_bound")]
        public long DocCountErrorUpperBound { get; set; }

        [JsonProperty("sum_other_doc_count")]
        public long SumOtherDocCount { get; set; }

        [JsonProperty("buckets")]
        public AggregationsCategorysBucket[] Buckets { get; set; }
    }

    public partial class AggregationsCategorysBucket
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("doc_count")]
        public long DocCount { get; set; }

        [JsonProperty("sub_categorys")]
        public AggregationsSubCategorys SubCategorys { get; set; }
    }

    public partial class AggregationsSubCategorys
    {
        [JsonProperty("doc_count_error_upper_bound")]
        public long DocCountErrorUpperBound { get; set; }

        [JsonProperty("sum_other_doc_count")]
        public long SumOtherDocCount { get; set; }

        [JsonProperty("buckets")]
        public AggregationsSubCategorysBucket[] Buckets { get; set; }
    }

    public partial class AggregationsSubCategorysBucket
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("doc_count")]
        public long DocCount { get; set; }
    }

    public partial class AggregationsHits
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("hits")]
        public object[] HitsHits { get; set; }
    }

    public partial class AggregationsShards
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("successful")]
        public long Successful { get; set; }

        [JsonProperty("skipped")]
        public long Skipped { get; set; }

        [JsonProperty("failed")]
        public long Failed { get; set; }
    }
}
