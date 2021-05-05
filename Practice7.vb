Imports System
'18/19 Section C Question 3c
Module MultiplesOfThree
    Sub Main()
        Dim count As Integer 
        Dim sum As Integer = 0
        For count = 0 to 100 step 3
            sum+=count
        Next 
            Console.WriteLine("The Sum Is: " & sum)
    End Sub
End Module