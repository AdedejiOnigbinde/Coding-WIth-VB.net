Imports System
'18/19 Section C Question 1
Module GradeSystem
    Sub Main()
        Console.WriteLine("Enter Score")
        Dim score As Integer = Console.ReadLine()
        Select Case score
            Case 80 to 100
            Console.WriteLine("A")
            Case 60 to 79
            Console.WriteLine("B")
            Case 50 to 59
            Console.WriteLine("C")
            Case 45 to 49
            Console.WriteLine("D")
            Case 40 to 44
            Console.WriteLine("E")
            Case 0 to 39
            Console.WriteLine("F")
            Case Else
            Console.WriteLine("Wrong Entry")
        End Select
    End Sub
End Module


