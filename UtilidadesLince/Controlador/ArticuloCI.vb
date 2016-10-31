Imports System.ComponentModel

Public Class ArticuloCI
    Inherits ArticuloLince
    Implements INotifyPropertyChanged
    Public Property Sistema As Integer
    Public Property Fisico As Integer
    Public Property Talle As String
    Public Property Area As AreaCI
    Public Property JustificadoCon As ArticuloCI
    Public Property Obserervación As String
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
