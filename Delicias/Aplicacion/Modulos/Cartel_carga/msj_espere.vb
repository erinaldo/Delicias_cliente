Public Class msj_espere

    Private Sub msj_espere_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Public procedencia As String


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label2.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 80 Then
            If procedencia = "Ajuste_masivo_b_guardar" Then
                Ajuste_masivo_b.guardar()
                'Me.Close() lo cierro en el otro formulario, en ajuste_masivo_b
            End If
        End If


    End Sub
End Class