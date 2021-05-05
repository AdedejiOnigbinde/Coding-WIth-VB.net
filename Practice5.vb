Imports System
'18/19 Section C Question 3a
Module Average
    Sub Main()
        Console.Write("Enter Your Name")
        Dim name As String = Console.ReadLine()
        Console.Write("Enter Score 1")
        Dim score1 As Integer = Console.ReadLine()
        Console.Write("Enter Score 2")
        Dim score2 As Integer = Console.ReadLine()
        Console.Write("Enter Score 3")
        Dim score3 As Integer = Console.ReadLine()
        Console.Write("Enter Score 4")
        Dim score4 As Integer = Console.ReadLine()
        Console.Write("Enter Score 5")
        Dim score5 As Integer = Console.ReadLine()
        Dim average As Integer = (score1 + score2 + score3 + score4 + score5)/5
        Console.WriteLine("Score 1 " & score1 & " Score 2 " & score2 & " Score 3 " & score3 & " Score 4 " & score4 & " Score 5" &  score5)
        Console.WriteLine("The Average Score Is " & average)
    End Sub
End Module