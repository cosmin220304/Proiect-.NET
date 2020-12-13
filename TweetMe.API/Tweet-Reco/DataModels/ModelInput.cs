using Microsoft.ML.Data;

namespace TweetMe_APIML.Model
{
    public class ModelInput
    {
        [ColumnName("ItemID"), LoadColumn(0)]
        public float ItemID { get; set; }


        [ColumnName("Sentiment"), LoadColumn(1)]
        public string Sentiment { get; set; }


        [ColumnName("SentimentText"), LoadColumn(2)]
        public string SentimentText { get; set; }
    }
}
