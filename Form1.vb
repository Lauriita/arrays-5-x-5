Public Class Form1

    Dim a(5, 5) As Double
    Dim i, j As Integer
    Dim cadena As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 0 To 4
            For j = 0 To 4

                If i = j Then
                    a(i, j) = 1
                Else
                    a(i, j) = 0
                End If

                cadena = cadena & a(i, j & " ")

            Next

            cadena = (cadena & vbNewLine)
        Next
        TextBox1.Text = cadena
    End Sub
End Class
