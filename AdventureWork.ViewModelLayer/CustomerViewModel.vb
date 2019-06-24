Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
    Inherits VeiwModelBase

    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        Entity = New Customer() With {
        .CustomerID = 1,
        .FirstName = "Keith",
        .LastName = "Presley",
        .CompanyName = "Keith cumputer storage"
        }

        Return Entity
    End Function

End Class
