Imports Common.Library


Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New()
        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Protected Overrides Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("CustomerID: " + CustomerID.ToString())
        sb.AppendLine("Company Name: " + CompanyName.ToString())
        sb.AppendLine("First Name: " + FirstName.ToString())
        sb.AppendLine("Last Name: " + LastName.ToString())
        sb.AppendLine(MyBase.GetClassData())

        'The following 3 appends is replace by the call above to CommonBase.GetClassData
        'sb.AppendLine("Is Active: " + IsActive.ToString())
        'sb.AppendLine("Modified Date: " + ModifedDate.ToLongDateString())
        'sb.AppendLine("Created By: " + CreatedBy.ToString())

        Return sb.ToString()
    End Function

End Class
