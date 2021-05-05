Imports System
'18/19 Section C Question 3ci and 3cii
Module MultiplesOfThree
    '3ci
    Sub Main()
        Dim count As Integer 
        Dim sum As Integer = 0
        For count = 0 to 100 step 3
            sum+=count
        Next 
            Console.WriteLine("The Sum Is: " & sum)

    '3cii
        Do 
            If (count % 3 = 0) Then
                sum+=count
            End If
            count++
        Loop While (count <= 100)
        Console.WriteLine("The Sum Is: " & sum)
            
    End Sub
End Module