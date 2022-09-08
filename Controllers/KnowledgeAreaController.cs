using Microsoft.AspNetCore.Mvc;
using  Microsoft.AspNetCore.Http;
namespace portfolioapi.Controllers;


[Route("api/[controller]")]
[ApiController]

public class KnowledgeAreaController:ControllerBase
{

    private static List<KnowledgeArea> knowledgeBases = new List<KnowledgeArea>
    {
       new KnowledgeArea {
       Id =1 ,
       Name ="Programming",
       Description = "Programming Languages"}
    };


   [HttpGet]

   public async Task<ActionResult<List<KnowledgeArea>>> Get()
   {

    return Ok(knowledgeBases);
   }   
}
