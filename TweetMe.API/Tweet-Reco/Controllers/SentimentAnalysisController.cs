using Microsoft.AspNetCore.Mvc;
using TweetMe_APIML.Model;

namespace SentimentAnalysisAPI.Controllers
{
    [Route("api/v1/predictions")]
    [ApiController]
    public class SentimentAnalysisController : ControllerBase
    {
        //private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;

        //public SentimentAnalysisController(PredictionEnginePool<SentimentData, SentimentPrediction> predictionEnginePool) 
        //{
        //    this._predictionEnginePool = predictionEnginePool;
        //}

        [HttpPost]
        public ActionResult<string> Post([FromBody] ModelInput data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            ModelInput sampleData = new ModelInput()
            {
                SentimentText = @"is so sad for my APL friend.............",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            return Ok(predictionResult);
        }
    }
}
