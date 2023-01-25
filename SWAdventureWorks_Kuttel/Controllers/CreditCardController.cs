using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAdventureWorks_Kuttel.Models;
using System.Collections.Generic;
using System.Linq;

namespace SWAdventureWorks_Kuttel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly AdventureWorks2019Context context;
         
        public CreditCardController(AdventureWorks2019Context context)
        {
            this.context = context;
        }


        //GET
        [HttpGet]
        public ActionResult<IEnumerable<CreditCard>> GetAll()
        {
            return context.CreditCard.ToList();
        }

        //GET BY ID
        [HttpGet("id/{id}")]
        public ActionResult<CreditCard> GetCreditCard(int id) 
        {
            CreditCard creditCard = (from cc in context.CreditCard
                                       where cc.CreditCardId == id
                                       select cc).SingleOrDefault();
            if(creditCard == null)
            {
                return NotFound();
            }
            return creditCard;
        }

        //GET BY TYPE
        [HttpGet("type/{type}")]
        public ActionResult<IEnumerable<CreditCard>> GetNameCreditCard(string type)
        {
            List<CreditCard> creditCardN = (from cc in context.CreditCard
                                      where cc.CardType == type
                                      select cc).ToList();
            if (creditCardN == null)
            {
                return NotFound();
            }
            return creditCardN;
        }
        //POST
        [HttpPost]
        public ActionResult PostCreditCard(CreditCard credit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(credit);
            }
            context.CreditCard.Add(credit);
            context.SaveChanges();
            return Ok();
        }
    }
}
