Module Module1

    Sub Main()
        Dim n As Integer, r As Integer, sum As Integer = 0
        n = Console.ReadLine
        While n > 0
            r = n Mod 10
            sum = sum + r
            n = n / 10
        End While
        Console.WriteLine("Sum of digit = " &sum)
        Console.ReadKey()
    End Sub
End Module
