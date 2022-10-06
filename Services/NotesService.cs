using ContosoPizza.Models;
using ContosoPizza.Dtos;

namespace ContosoPizza.Services;

public static class NotesService
{
    static List<Note> notes = new List<Note>();

    static NotesService(){

    }

    public static List<Note> GetAll(){
        return notes;
    }

    public static SpecificNote Add(Note note){
        notes.Add(note);
        SpecificNote savedNote = new SpecificNote();
        savedNote.index = notes.IndexOf(note);
        savedNote.content = note.content;

        return savedNote;
    }

    public static SpecificNote? Get(int id){
        SpecificNote savedNote = new SpecificNote();
        savedNote.index = id;
        savedNote.content = notes[id].content;
        return savedNote;
    }

    public static SpecificNote? Update(Note note, int id)
    {

        notes[id] = note;
        SpecificNote savedNote = new SpecificNote();
        savedNote.index = id;
        savedNote.content = note.content;
        return savedNote;
    }

    public static SpecificNote? InsertAtIndex(Note note, int id){

        notes.Insert(id, note);
        SpecificNote savedNote = new SpecificNote() {index = id, content = note.content};
        return savedNote;
    }

    public static bool DeleteNote(int id){
        notes.Remove(notes[id]);
        return true;
    }
}