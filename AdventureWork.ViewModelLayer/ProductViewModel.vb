Imports System.Collections.ObjectModel
Imports AdventureWorks.EntityLayer
Imports Common.Library


Public Class ProductViewModel
    Inherits VeiwModelBase

    Sub New()
        LoadProduct(680)
        'LoadProducts()
    End Sub

    Public Property Products As ObservableCollection(Of Product)

    Public Property Entity As Product

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        Entity = New Product() With {
            .ProductID = 680,
            .ProductName = "something",
            .ProductNumber = "KP-1202-72",
            .Colour = "Black",
            .Size = "26",
            .Weight = 22,
            .StandrardCost = 999.99,
            .ListPrice = 666.66
        }
        Return Entity
    End Function

    'Function LoadProducts() As ObservableCollection(Of Product)
    '    Return LoadProducts(Nothing)
    'End Function

    'Function LoadProducts(ByVal startingFilePath As String)
    '    Dim mgr = New ProductManager

    '    Products = mgr.LoadProducts(startingFilePath)

    '    Return Products


    'End Function



End Class
