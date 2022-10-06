using ContosoPizza.Models;
using ContosoPizza.Services;
using ContosoPizza.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class DocumentsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(Note note){
        Document savedDocument = await DocService.CreateDocument(note);

        return CreatedAtAction(nameof(Create), savedDocument);
    } 

    [HttpGet("{id}")]
    public ActionResult<SpecificDocument> Get(string id){
        SpecificDocument savedDoc = DocService.GetDocument(id);

        return savedDoc;
    }
}