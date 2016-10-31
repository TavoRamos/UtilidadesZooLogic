Public Class ArticuloLince
    Public Property Codigo As String
    'Public Property Proveedor As Porveedor
    Public Property Descripcion As String
    Public Property Color As String
    Public Property Grupo As GrupoLince
    'Public Property Grupo As String
    Public Property Precio()
    Public Property Marca As String()

    Public Sub New(ByRef cod As String, ByRef desart As String, ByRef col As String, ByRef grupart As String, ByRef precio As Object)
        Codigo = cod
        Descripcion = desart
        Color = col
        Grupo = New GrupoLince(grupart, Nothing, Nothing)
        precio = precio
    End Sub
    Public Shared Function NuevoArticuloDesdeBD(ByRef codart) As ArticuloLince
        Dim BD As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDArt)
        Dim dt As DataTable = BD.ObtenerArticulo(codart)
        Dim precio(4)
        precio(0) = dt.Rows(0).Item("apr1").ToString
        precio(1) = dt.Rows(0).Item("apr2").ToString
        precio(2) = dt.Rows(0).Item("apr3").ToString
        precio(3) = dt.Rows(0).Item("apr4").ToString
        precio(4) = dt.Rows(0).Item("apr5").ToString
        Dim Articulo As New ArticuloLince(codart, dt.Rows(0).Item("artdes").ToString.Trim, dt.Rows(0).Item("amate").ToString.Trim, dt.Rows(0).Item("artgrupo").ToString.Trim, precio)
        Return Articulo
    End Function

End Class