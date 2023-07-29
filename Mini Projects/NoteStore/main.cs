using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{
    public class NotesStore
{
    private List<(string State, string Name)> notes;

    public NotesStore()
    {
        notes = new List<(string State, string Name)>();
    }

    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Name cannot be empty");

        if (state != "completed" && state != "active" && state != "others")
            throw new Exception($"Invalid state {state}");

        notes.Add((state, name));
    }

    public List<string> GetNotes(string state)
    {
        if (state != "completed" && state != "active" && state != "others")
            throw new Exception($"Invalid state {state}");

        List<string> filteredNotes = new List<string>();
        foreach (var (noteState, noteName) in notes)
        {
            if (noteState == state)
                filteredNotes.Add(noteName);
        }

        return filteredNotes;
    }
}
    public class Solution
    {
        public static void Main() 
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++) {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    } else {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}


