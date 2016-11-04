Imports System.ComponentModel

Public Class ArticuloCI
    Inherits ArticuloLince

    Public Property Sistema As Integer
    Public Property Fisico As Integer
    Public Property Talle As String
    Public Property Area As AreaCI
    Public Property JustificadoCon As ArticuloCI
    Public Property TipoJustificacion As Byte
    Public Property Observacion As String

    Public Sub New(ByRef codigo As String, ByRef descripcion As String, ByRef talle As String, ByRef grupo As String, ByRef Precio As List(Of Decimal), ByRef sistema As Integer, ByRef fisico As Integer _
                   , ByRef Optional area As AreaCI = Nothing, Optional ByRef color As String = Nothing)
        MyBase.New(codigo, descripcion, color, grupo, Precio)
        Me.Sistema = sistema
        Me.Fisico = fisico
        Me.Talle = talle
        Me.Area = area
    End Sub
    Public Overrides Function ToString() As String
        Dim precio, area As String
        If Not IsNothing(Me.Precio) Then
            precio = "1 - $" + Me.Precio.ToString
        Else
            precio = "Sin precio/s asignado/s"
        End If
        If Not IsNothing(Me.Area) Then
            area = Me.Area.Numero.ToString + "-" + Me.Area.Descripcion + "(" + Me.Area.CodBarras.ToString + ")"
        Else
            area = "Sin area asignada"
        End If
        Return "--------------ARTICULO--------------" + vbCrLf + "Codigo: " + Me.Codigo + vbCrLf + "Descripción: " + Me.Descripcion + vbCrLf _
            + "Grupo: " + Me.Grupo.ID + vbCrLf + "Talle: " + Me.Talle + vbCrLf + "Color: " + Me.Color + vbCrLf + "Precio: " + precio _
            + vbCrLf + "Marca: " + If(IsNothing(Me.Marca), "Sin maraca asignada", Me.Marca.ToString) + vbCrLf + "--------------INVENTARIO--------------" + vbCrLf + "Sistema: " + Sistema.ToString + vbCrLf + "Contado: " + Fisico.ToString + vbCrLf + "Diferencia: " + (Fisico - Sistema).ToString _
            + vbCrLf + "Area: " + area + vbCrLf + "Observación: " + If(IsNothing(Observacion), "", Observacion.ToString)
    End Function
End Class
