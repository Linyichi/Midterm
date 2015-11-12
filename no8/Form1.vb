Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I, D, E As Single
        Console.Write("輸入體重KG")
        I =
    Console.ReadLine()
        Console.Write("輸入身高CM")
        D =
    Console.ReadLine()
        E = I / (D / 100) ^ 2
        '公斤/公尺(公分/100)的平方
        Console.Write("BMI值為" & E)
        Console.Read()
   
    End Sub
End Class
