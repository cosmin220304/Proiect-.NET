using System;
using Microsoft.ML.Data;

namespace TweetMe_APIML.Model
{
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public String Prediction { get; set; }
        public float[] Score { get; set; }
    }
}
