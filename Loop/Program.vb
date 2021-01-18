Module Module1
    Sub Main()
        ' Loop
        Dim a As Integer = 10
        Do
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        Loop While (a < 20)
        Console.ReadLine()
    End Sub
End Module