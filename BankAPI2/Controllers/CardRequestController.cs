using BankAPI2.BusinessManager.Interface;
using BankAPI2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardRequestController : ControllerBase
    {
        public ICardInterface _cardInterface { get; set; }

        public CardRequestController(ICardInterface cardInterface)
        {
            _cardInterface = cardInterface;
        }

        [HttpPost]
        [Route("CreateCardRequest")]
        public IActionResult CreateCardRequest([FromBody] CardRequest cardRequest)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            return Ok(_cardInterface.Create(cardRequest));
        }

        [HttpGet]
        [Route("Get_StatusbyID")]
        public IActionResult GetStatusByAccount(int Id)
        {
            var card = _cardInterface.GetStatusbyAccount(Id);
            return Ok(card);
        }




    }
}
