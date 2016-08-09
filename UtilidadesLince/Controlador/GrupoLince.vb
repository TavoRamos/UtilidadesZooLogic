Public Class GrupoLince
    Protected Friend Property ID As String
    Protected Friend Property Descripcion As String
    Protected Friend Property Talles As List(Of String)
    Public Sub New(ByRef id As String, ByRef descripcion As String, ByRef talles As List(Of String))
        Me.ID = id
        Me.Descripcion = descripcion
        Me.Talles = talles
    End Sub
    Public Shared Function NuevoDesdeDB(ByRef id_grupo As String) As GrupoLince
        Try
            Dim DB As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDGru)
            Dim dt As DataTable = DB.obtenerGrupo(id_grupo)
            Dim talles As New List(Of String)
            If dt.Rows.Count > 0 Then
                For i As Integer = 1 To 25
                    If Not String.IsNullOrWhiteSpace(dt.Rows(0).Item("mc" + i.ToString).ToString) Then
                        talles.Add(dt.Rows(0).Item("mc" + i.ToString).ToString)
                    Else
                        Continue For
                    End If
                Next
                Dim NuevoGrupo As New GrupoLince(dt.Rows(0).Item("matcod").ToString, dt.Rows(0).Item("matdes").ToString, talles)
                Return NuevoGrupo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("GrupoLince.NuevoDesdeDB" + vbCrLf + ex.Message)
            Return Nothing
        End Try
    End Function
    Public Overloads Function toString() As String
        Dim tallesStr As String = ""
        For Each str As String In Me.Talles
            tallesStr += str + "-"
        Next
        tallesStr = tallesStr.Substring(0, tallesStr.Length - 1)
        Return "ID: " + Me.ID + vbCrLf + "NOMBRE: " + Me.Descripcion + vbCrLf + "TALLES " + tallesStr.Replace(" ", Nothing)
    End Function
    'SIN USO
    Public Shared Function listarCurvaArticulo(ByRef articulo As ArticuloLince) As List(Of String)
        Dim BD As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDGru)
        Dim dt = BD.obtenerGrupo(articulo.Grupo)
        Dim Talles = New List(Of String)
        For i As Integer = 1 To 25
            If Not String.IsNullOrWhiteSpace(dt.Rows(0).Item("mc" + i.ToString).ToString) Then
                Talles.Add(dt.Rows(0).Item("mc" + i.ToString).ToString)
            Else
                Continue For
            End If
        Next
        Return Talles
    End Function
End Class
