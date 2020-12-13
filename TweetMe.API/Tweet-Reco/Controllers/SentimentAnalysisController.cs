using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using TweetMe_APIML.Model;

namespace SentimentAnalysisAPI.Controllers
{
    [Route("tweet-reco")]
    [ApiController]
    public class SentimentAnalysisController : ControllerBase
    {
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;

        public SentimentAnalysisController(PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<int> Post([FromBody] ModelInput data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var predictionResult = _predictionEnginePool.Predict(modelName: "SentimentAnalysisModel", example: data);

            return Ok(predictionResult.Prediction);
        }

        [HttpGet]
        public ActionResult<int> Get([FromQuery] ModelInput data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var predictionResult = _predictionEnginePool.Predict(modelName: "SentimentAnalysisModel", example: data);

            return Ok(predictionResult.Prediction);
        }
    }
}
