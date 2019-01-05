using Microsoft.AspNetCore.Mvc;

namespace WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [ApiConventionType(typeof(CustomApiConventions))]
    public class CustomController : ControllerBase
    {
        /// <summary>
        /// 新規でモデルを登録するアクションメソッド<br />
        /// `POST api/custom`
        /// </summary>
        [HttpPost]
        public ActionResult<CustomModel> Create([FromBody] CustomModel model)
        {
            return Created($"api/custom/{model.Id}", model);
        }
    }

    /// <summary>
    /// 対象のモデル
    /// </summary>
    public class CustomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}