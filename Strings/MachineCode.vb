Dim instr As String
Dim valid As Boolean = True
Console.WriteLine("Enter an 8 bit machine code instruction")
instr = Console.ReadLine()

For i = 0 To instr.Length - 1
    If instr(i) <> "0" Or instr(i) <> "1" Then
        valid = False
    End If
Next

If instr.Length <> 8 Then
    valid = False
End If

If valid = True Then
    Console.WriteLine("OK")
Else
    Console.WriteLine("wrong")
End If
