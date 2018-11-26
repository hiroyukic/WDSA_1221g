Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' カレントディレクトリを取得する
        Dim stCurrentDir As String = System.IO.Directory.GetCurrentDirectory()
        TextBox1.Text = stCurrentDir

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 10
            Console.Write(i & ", ")

            ListBox1.Items.Add(i)
        Next

    End Sub

End Class

