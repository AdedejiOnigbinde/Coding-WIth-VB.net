Imports System
'18/19 Section C Question 2bi and 2bii
Module Addition
    Sub Main()

        '2bi
        Dim count As Integer = 0
        Dim sum As Integer = 0
        Do
            If (count % 2 = 0) Then 
                sum += count
            End If
            count ++
        Loop While (count <= 100)
        Console.WriteLine("The Sum Is: " & sum)
        
        '2bii
         Do
            If (count Mod 2 = 0) Then 
                sum += count
            End If
            count++
        Loop Until count <= 100
        Console.WriteLine("The Sum Is: " & sum)

    End Sub
End Module