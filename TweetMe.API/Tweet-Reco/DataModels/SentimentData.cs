﻿using Microsoft.ML.Data;

namespace SentimentAnalysisAPI.DataModels
{
    public class SentimentData
    {
        [LoadColumn(0)]
        public string SentimentText { get; set; }

        [LoadColumn(1)]
        [LoadColumnName("Label")]
        public bool Sentiment { get; set; }
    }
}
