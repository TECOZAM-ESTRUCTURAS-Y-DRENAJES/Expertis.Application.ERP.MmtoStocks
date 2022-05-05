Public Class clsFilterFormulas

    '    Private Const ERR_NOTFINDCTRL As Long = 730             '<El control no existe>
    '    Private Const ERR_NOTMATRIXCTRL As Long = 343           '<El objeto no es una matriz>
    '    Private Const ERR_MATRIXINDEXOUT As Long = 9            '<El subindice esta fuera del intervalo>
    '    Private Const ERR_INVALIDPROPERTY As Long = 438         '<El objeto no admite esta propiedad o metodo>
    '    Private Const ERR_INVALIDCTRLNAME As Long = 728         '<'' no es un nombre de control válido>

    '    Private mblnFormatoSiNo As Boolean
    '    Private mstrIncluidos As String
    '    Private mstrExcluidos As String
    '    Private mstrFormulaString As String
    '    Private mFormulas As Object
    '    Private mControles As Object

    'Public Property Set Controles(Objeto As Object)
    '    Set mControles = Objeto
    'End Property

    'Public Property Set Formulas(Objeto As clsColFormulas)
    '    Set mFormulas = Objeto
    'End Property

    'Public Property Let ControlesIncluidos(ByVal lista As String)
    '    mstrIncluidos = lista
    '    End Property

    'Public Property Let ControlesExcluidos(ByVal lista As String)
    '    mstrExcluidos = lista
    '    If Len(mstrExcluidos) > 0 Then
    '        mstrExcluidos = "," & mstrExcluidos & ","
    '    End If
    'End Property

    'Public Property Let FormatoSiNo(ByVal valor As Boolean)
    '    mblnFormatoSiNo = valor
    '    End Property

    'Public Property Get ListaDeFormulas() As String
    '    ListaDeFormulas = mstrFormulaString
    '    End Property

    '    Public Function GenerarListaDeFormulas() As String
    '        Dim i As Integer
    '        Dim j As Integer
    '        Dim lng1Error As Long
    '        Dim lngIndex As Long
    '        Dim strFormula As String
    '        Dim strCtrlList As String
    '        Dim arrCtrl() As String
    '        Dim Ctrl As Object
    '        On Error GoTo TratarError

    '        If Len(mstrIncluidos) = 0 Then
    '            strCtrlList = Generarlista()
    '        Else
    '            strCtrlList = mstrIncluidos
    '        End If
    '        If Len(strCtrlList) > 0 Then
    '            arrCtrl = Split(strCtrlList, ",", , vbTextCompare)
    '            If UBound(arrCtrl) >= 0 Then
    '                For i = LBound(arrCtrl) To UBound(arrCtrl)

    '                    strFormula = vbNullString

    '                    On Error Resume Next
    '                    lngIndex = mControles(arrCtrl(i)).Index
    '                    lng1Error = Err.Number
    '                    If lng1Error = ERR_NOTFINDCTRL Or lng1Error = ERR_INVALIDCTRLNAME Then
    '                        'El control no existe
    '                        MsgBox(Err.Description, vbCritical, ExpertisApp.Title)
    '                        'Exit Function
    '                    Else
    '                        If InStr(1, UCase(mstrExcluidos), "," & UCase(mControles(arrCtrl(i)).Name) & ",") = 0 Then
    '                            If Err.Number = ERR_INVALIDPROPERTY Then
    '                                Err.Clear()
    '                            Else
    '                                '                            If lng1Error = ERR_NOTMATRIXCTRL Then
    '                                '                                '<El objeto no es una matriz>
    '                                '                                Err.Clear
    '                                '                                'On Error GoTo TratarError
    '                                '                                strFormula = FormulaItem(mControles(arrCtrl(i)))
    '                                '                            Else
    '                                '                                'El control pertenece a una matriz de controles
    '                                '                                Err.Clear
    '                                '                                'On Error GoTo TratarError
    '                                '                                For j = mControles(arrCtrl(i)).LBound To mControles(arrCtrl(i)).UBound
    '                                '                                    Set Ctrl = mControles(arrCtrl(i))(j)
    '                                '                                    strFormula = FormulaItem(Ctrl)
    '                                '                                Next j
    '                                '                            End If

    '                                If lng1Error = ERR_NOTMATRIXCTRL Then
    '                                    Err.Clear()
    '                                    strFormula = FormulaItem(mControles(arrCtrl(i)))
    '                                Else
    '                                    Err.Clear()
    '                                End If
    '                                If Len(strFormula) > 0 Then
    '                                    If Len(GenerarListaDeFormulas) > 0 Then GenerarListaDeFormulas = GenerarListaDeFormulas & ";"
    '                                    GenerarListaDeFormulas = GenerarListaDeFormulas & strFormula
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                Next i
    '                mstrFormulaString = GenerarListaDeFormulas
    '            End If
    '        End If

    '        Erase arrCtrl
    '        Ctrl = Nothing
    '        Exit Function
    'TratarError:
    '        mstrFormulaString = vbNullString
    '        GenerateError(Err.Number, Err.Description, "GenerarListaDeformulas", ExpertisApp.Title)
    '    End Function

    '    Public Sub AsignarFormulas()
    '        Dim lngIndex As Long
    '        Dim strFormula As String
    '        Dim strFormulaValue As String
    '        Dim FormulaItem As clsItemFormula
    '        On Error GoTo TratarError

    '        If Not mFormulas Is Nothing Then
    '            strFormula = GenerarListaDeFormulas()
    '            On Error Resume Next
    '            For Each FormulaItem In mFormulas
    '                strFormulaValue = vbNullString
    '                strFormulaValue = GetPropertyValue(strFormula, FormulaItem.FormulaName)
    '                If Len(strFormulaValue) > 0 Then
    '                    FormulaItem.Value = strFormulaValue
    '                End If
    '            Next FormulaItem
    '        End If

    '        FormulaItem = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err.Number, Err.Description, "AsignarFormulas", ExpertisApp.Title)
    '    End Sub

    '    Private Sub Class_Terminate()
    '        mControles = Nothing
    '        mFormulas = Nothing
    '    End Sub

    '    Private Function FormulaItem(ByVal Ctrl As Object) As String
    '        Dim i As Long
    '        Dim j As Long
    '        Dim strFormulaName As String
    '        Dim strFormulaValue As String
    '        Dim strType As String
    '        Dim arrValuesList() As String
    '        Dim arrValueItem() As String
    '        'On Error GoTo TratarError
    '        On Error Resume Next

    '        strType = TypeName(Ctrl)
    '        Select Case strType
    '            Case "FwInput"
    '                Select Case Ctrl.ControlBehavior
    '                    Case cbsTextBox, cbsComboBox, cbsSearchBox, cbsCountersPicker, cbsDateTimePicker
    '                        If Len(Ctrl.Value & vbNullString) > 0 Then
    '                            FormulaItem = Ctrl.Name & "=" & Ctrl.Value

    '                            If Ctrl.ControlBehavior = cbsSearchBox Or Ctrl.ControlBehavior = cbsComboBox Then
    '                                If Ctrl.ShowComplementaryDescField Then
    '                                    If Len(Ctrl.ComplementaryDescField) > 0 Then
    '                                        strFormulaName = Ctrl.ComplementaryDescField
    '                                    Else
    '                                        strFormulaName = "Desc" & Ctrl.Name
    '                                    End If
    '                                    If Len(FormulaItem) > 0 Then
    '                                        FormulaItem = FormulaItem & ";" & strFormulaName & "=" & Ctrl.ComplementaryCaption
    '                                    Else
    '                                        FormulaItem = strFormulaName & "=" & Ctrl.ComplementaryCaption
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    Case cbsCheckBox, cbsOptionButton
    '                        If Not IsEmptyValue(Ctrl.Value) Then
    '                            If Not mblnFormatoSiNo Then
    '                                strFormulaValue = Ctrl.Value
    '                            Else
    '                                strFormulaValue = IIf(Ctrl.Value, Enums("enumBoolean")(2).Description, Enums("enumBoolean")(1).Description)
    '                            End If
    '                            FormulaItem = Ctrl.Name & "=" & strFormulaValue
    '                        End If
    '                    Case cbsDropDownList
    '                        If Len(Ctrl.Value & vbNullString) > 0 Then
    '                            If Len(Ctrl.ValuesList) > 0 Then
    '                                arrValuesList = Split(Ctrl.ValuesList, ";", , vbTextCompare)
    '                                For i = LBound(arrValuesList) To UBound(arrValuesList)
    '                                    arrValueItem = Split(arrValuesList(i), ",", , vbTextCompare)
    '                                    If arrValueItem(0) = Ctrl.Value Then
    '                                        strFormulaValue = arrValueItem(1)
    '                                        Exit For
    '                                    End If
    '                                Next i
    '                            End If
    '                            If Len(strFormulaValue) > 0 Then
    '                                FormulaItem = Ctrl.Name & "=" & strFormulaValue
    '                                FormulaItem = FormulaItem & ";" & Ctrl.Name & "Value=" & Ctrl.Value
    '                            End If
    '                        End If
    '                End Select
    '            Case "TextBox"
    '                If Len(Ctrl.Text) > 0 Then
    '                    FormulaItem = Ctrl.Name & "=" & Ctrl.Text
    '                End If
    '            Case "OptionButton", "CheckBox", "WLOption", "WLCheck"
    '                If Not mblnFormatoSiNo Then
    '                    strFormulaValue = CBool(Ctrl.Value)
    '                Else
    '                    strFormulaValue = IIf(CBool(Ctrl.Value), Enums("enumBoolean")(2).Description, Enums("enumBoolean")(1).Description)
    '                End If
    '                FormulaItem = Ctrl.Name & "=" & strFormulaValue
    '        End Select

    '        Erase arrValueItem
    '        Erase arrValuesList
    '        '    Exit Function
    '        'TratarError:
    '        '    GenerateError Err.Number, Err.Description, "FormulaItem", ExpertisApp.Title
    '    End Function

    '    Private Function Generarlista() As String
    '        Dim strList As String
    '        Dim Ctrl As Object
    '        'On Error GoTo TratarError
    '        On Error Resume Next

    '        If Not mControles Is Nothing Then
    '            If Len(mstrExcluidos) > 0 Then mstrExcluidos = "," & mstrExcluidos & ","
    '            For Each Ctrl In mControles
    '                If TypeName(Ctrl) = "FwInput" Or TypeName(Ctrl) = "TextBox" Or TypeName(Ctrl) = "OptionButton" Or TypeName(Ctrl) = "CheckBox" Then
    '                    If InStr(1, UCase(mstrExcluidos), "," & UCase(Ctrl.Name) & ",") = 0 Then
    '                        If Len(strList) > 0 Then strList = strList & ","
    '                        strList = strList & Ctrl.Name
    '                    End If
    '                End If
    '            Next Ctrl
    '            Generarlista = strList
    '        End If

    '        Ctrl = Nothing
    '        '    Exit Function
    '        'TratarError:
    '        '    GenerateError Err.Number, Err.Description, "Generarlista", ExpertisApp.Title
    '    End Function

End Class
