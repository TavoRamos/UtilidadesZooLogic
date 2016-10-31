Imports System.ComponentModel

Public Class ArticuloCI
    Inherits ArticuloLince
    Implements INotifyPropertyChanged
    Protected Friend Property Sistema As Integer
    Protected Friend Property Fisico As Integer
    Protected Friend Property Talle As String
    Protected Friend Property Area As AreaCI
    Protected Friend Property JustificadoCon As ArticuloCI
    Protected Friend Property Obserervación As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New(ByRef codigo As String, ByRef descripcion As String, ByRef talle As String, ByRef grupo As String, ByRef Precio() As Object, ByRef sistema As Integer, ByRef fisico As Integer _
                   , ByRef Optional area As AreaCI = Nothing, Optional ByRef color As String = Nothing)
        MyBase.New(codigo, descripcion, color, grupo, Precio)
        Me.Sistema = sistema
        Me.Fisico = fisico
        Me.Talle = talle
        Me.Area = area
    End Sub



    Private Sub NotifyPropertyChanged(ByVal JustificadoCon As ArticuloCI, Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
