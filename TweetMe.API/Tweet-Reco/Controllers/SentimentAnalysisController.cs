using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using SentimentAnalysisAPI.DataModels;
using System;

namespace SentimentAnalysisAPI.Controllers
{
    [Route("api/v1/predictions")]
    [ApiController]
    public class SentimentAnalysisController : ControllerBase
    {
        private const string P = "Positive";
        private const string N = "Negative";
        private readonly PredictionEnginePool<SentimentData, SentimentPrediction> _predictionEnginePool;

        public SentimentAnalysisController(PredictionEnginePool<SentimentData, SentimentPrediction> predictionEnginePool) 
        {
            this._predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] SentimentData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            SentimentPrediction predictedValue = _predictionEnginePool.Predict(modelName: "SentimentAnalysisModel", example: data);

            string sentiment = Convert.ToBoolean(predictedValue.Prediction) ? P : N;

            return Ok(sentiment);
        }
    }
}
