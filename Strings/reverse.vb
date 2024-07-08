Dim message As String
Console.WriteLine("Enter some text")
message = Console.ReadLine()
For i = 0 To message.Length - 1
    Console.Write(message(message.Length - 1 - i))
Next
