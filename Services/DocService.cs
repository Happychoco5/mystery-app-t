using ContosoPizza.Models;
using ContosoPizza.Dtos;

namespace ContosoPizza.Services;

public static class DocService
{
    public static async Task<Document> CreateDocument(Note note){
        Guid uuid = Guid.NewGuid();
        string uuidString = uuid.ToString();

        await File.WriteAllTextAsync(uuidString + ".txt", note.content);
        
        return new Document() {docId = uuidString};
    }

    public static SpecificDocument GetDocument(string id){
        string text = System.IO.File.ReadAllText(id + ".txt");
        return new SpecificDocument() {docId = id, content = text};
    }
}