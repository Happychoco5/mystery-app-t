using ContosoPizza.Models;
using ContosoPizza.Services;
using ContosoPizza.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    public NotesController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Note>> GetAll() =>
        NotesService.GetAll();

    //GET by Id action
    [HttpGet("{id}")]
    public ActionResult<SpecificNote> Get(int id){
        var note = NotesService.Get(id);

        if(note == null)
            return NotFound();
        
        return note;
    }

    // POST action
    //IAction result lets the client know if the request succeeded and provides the ID of the newly created Pizza
    [HttpPost]
    public IActionResult Create(Note note){
        SpecificNote savedNote = NotesService.Add(note);
        return CreatedAtAction(nameof(Create), savedNote);
    }


    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(Note note, int id){
        var savedNote = NotesService.Update(note, id);

        return CreatedAtAction(nameof(Update), savedNote);
    }

    //Insert at index
    [HttpPost("{id}")]
    public IActionResult CreateAtIndex(Note note, int id){
        var savedNote = NotesService.InsertAtIndex(note, id);

        return CreatedAtAction(nameof(CreateAtIndex), savedNote);
    }

    //Delete at index
    [HttpDelete("{id}")]
    public IActionResult Delete(int id){
        if(NotesService.DeleteNote(id)){
            return StatusCode(204);
        }
        else{
            return StatusCode(244);
        }
    }
}