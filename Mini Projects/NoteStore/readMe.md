# Question 

In this chalenge , the task to implement a class called NotesStore . The class will manage a collection of notes, with each note having a state and a name . Valid States for notes are 'completed', 'active' and 'others' . All other states or invalid. The class must having following methods :

1. AddNote(state,name) : adds a note with the given name (string) and state(string) to the collection . In addition to that  :
 - If the passed name is empty, the it throws an Excepton with the message 'Name cannot be empty'

- if the passed name is non-empty but the given state is not a valid state for a note, then it throws an Exception with the message 'Invalid state {state}'

2. GetNotes(state) : returns a list of note names with the given state (string) added so far. the name are returned in the order the corresponding notes were added. In addition to that :
- If the given state is not a valid note state, then it throwa n Exception with the message 'Invalid state {state}'.
- If no note is found in this state , it returns an empty list.

Note : The state names are case-sensitive.

Your Implementation of the function will be tested by a stubbed code on several input files. each input file contains parameteres for the function calls. the functiion wiill be called with those parametere and the result of their executions will be printed to the standard output by the the stubbed code. The stubbed code joins the string returned by the GetNotes function with a comma and prints to the standard outpr . If GetNotes returns an empity list, The stubbed code prints 'No Notes'. The stubbed code also print messages of all the thrown errors
