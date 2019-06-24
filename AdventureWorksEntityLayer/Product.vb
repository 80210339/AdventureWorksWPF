Public Class Product
    Inherits CommonBase

    Sub New()
        StandrardCost = 250
        ListPrice = 900
    End Sub

    Public Property SellStartDate As DateTime

    Public Property SellEndDate As DateTime
    Public Property StandrardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property ProductID As String
    Public Property ProductName As String
    Public Property ProductNumber As String

    'Sub CalculateSellEndDate(ByVal days As Integer, ByRef sellDate As DateTime)
    '    SellEndDate = SellStartDate.AddDays(days)
    '    sellDate = SellEndDate
    'End Sub

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellStartDate.AddDays(days)
        Return SellEndDate
    End Function

    'Function CalculateProfit(Optional ByVal newCost As Decimal = 0) As Decimal
    '    If newCost <> 0 Then
    '        StandrardCost = newCost
    '    End If
    '    Return ListPrice - StandrardCost
    'End Function

    Overloads Function calculateProfit() As Decimal
        Return calculateProfit(StandrardCost)
    End Function


    Overloads Function calculateProfit(ByVal newCost As Decimal)
        If newCost <> 0 Then
            StandrardCost = newCost
        End If
        Return ListPrice - StandrardCost
    End Function

    Protected Overrides Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Product ID: " + ProductID.ToString())
        sb.AppendLine("Product Name: " + ProductName.ToString())
        sb.AppendLine("Product Number: " + ProductNumber.ToString())
        sb.AppendLine(MyBase.GetClassData())

        'The following 3 appends is replace by the call above to CommonBase.GetClassData
        'sb.AppendLine("Is Active: " + IsActive.ToString())
        'sb.AppendLine("Modified Date: " + ModifedDate.ToLongDateString())
        'sb.AppendLine("Created By: " + CreatedBy.ToString())

        Return sb.ToString()
    End Function



End Class
