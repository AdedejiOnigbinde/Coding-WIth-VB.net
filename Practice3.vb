Imports System
'18/19 Section C Question 2a
Module Triangle
    Sub Main()
        Dim area As Double
        Console.WriteLine("Enter Base")
        Dim base As Double = Console.ReadLine()
        Console.WriteLine("Enter Height")
        Dim height As Double = Console.ReadLine()
        area = 0.5(base * height)
        Console.WriteLine("The Area Of This Triangle Is: " & area)
     End Sub
End Module

