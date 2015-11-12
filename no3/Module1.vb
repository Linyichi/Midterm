Module Module1

    Sub Main()
        Dim i, NUM As Integer
        Console.WriteLine("請輸入總人數:")
        NUM = Val(Console.ReadLine())
        'yichi是陣列
        Dim yichi(NUM - 1) As Integer
        For i = 0 To yichi.GetUpperBound(0)
            Console.Write("請輸入第{0}個數值:", (i + 1).ToString())
            yichi(i) = Val(Console.ReadLine())
        Next
        Console.WriteLine("數值最大:{0}", getmax(yichi))
        Console.WriteLine("數值最小:{0}", getmin(yichi))
        Console.ReadLine()


    End Sub
    Function getmax(ByVal ParamArray x() As Integer) As Integer
        Dim max As Integer
        max = x(0)
        For i As Integer = 1 To x.Length - 1
            If x(i) > max Then
                max = x(i)
            End If
        Next
        Return max
    End Function
    Function getmin(ByVal ParamArray x() As Integer) As Integer
        Dim min As Integer
        min = x(0)
        For i As Integer = 1 To x.Length - 1
            If x(i) < min Then
                min = x(i)
            End If
        Next
        Return min
    End Function

End Module
