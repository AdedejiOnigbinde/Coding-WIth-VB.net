Imports System
'18/19 Section C Question 1b
Module Plane
    Sub Main()
        Dim distance As Double 
        Console.WriteLine("Enter The Acceleration")
        Dim accerlation As Double = Console.ReadLine()
        Console.WriteLine("Enter The Time")
        Dim time As Double = Console>ReadLine()
        distance = 0.5 *(accerlation * time^2)
        Console.WriteLine("Distance Travelled Is: " & distance & " Meters")
    End Sub
End Module 
    
