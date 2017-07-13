Module Globales
    Public url As String

    Public Function hoy()
        Return Now
    End Function

    Public Function exito(s1 As String)
        Return MessageBox.Show("Se ha " & s1 & " un registro exitosamente.")
    End Function
End Module
