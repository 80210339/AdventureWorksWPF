Imports System.Collections.ObjectModel

Public Class ProductManager
    'Inherits DataManagerBase

    'Function LoadProducts() As ObservableCollection(Of Product)
    '    Return LoadProducts(Nothing)
    'End Function

    'Function LoadProducts(ByVal startingFilePath As String)
    '    Dim ret = New ObservableCollection(Of Product)

    '    Try
    '        Dim doc = MyBase.LoadXElement(ConfigurationManager.AppSettings("ProductsFile"), startingFilePath)

    '        Dim products = From prod In doc.<Product>
    '                       Select New Product With {
    '                           .ProductID = Convert.ToInt32(prod.Element("ProductID")).Value,
    '                           .name = prod.Element("Name").Value,
    '                           .ProductNumber = prod.Element("ProductNumber").Value,
    '                           .color = prod.Element("colotr").Value
    '                           }

    '    Catch ex As Exception

    '    End Try

    'End Function
End Class
