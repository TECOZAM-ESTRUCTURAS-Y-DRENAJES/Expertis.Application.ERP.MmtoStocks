Public Module General

    Public Function FormatStringGenerator(ByVal DecimalPlaces As Integer) As String
        If DecimalPlaces >= 1 Then
            Return String.Concat("#,0.0", New String("#", DecimalPlaces - 1))
        Else
            Return "#,0.0"
        End If
    End Function

End Module
