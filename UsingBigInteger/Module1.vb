Imports System.Numerics
Module Module1

    Sub Main()
        Dim b As BigInteger
        b = BigInteger.Pow(2, 1000)
        Console.WriteLine(b.ToString)
        b = BigInteger.Add(b, b)
        Console.WriteLine(b.ToString)
        b = BigInteger.Multiply(b, 12)
        Console.WriteLine(b.ToString)


    End Sub

End Module
