Public Class CommonBase
    Sub New()
        IsActive = True
        ModifedDate = DateTime.Now
        CreatedBy = Environment.UserName
    End Sub

    Public Property IsActive As Boolean
    Public Property ModifedDate As DateTime
    Public Property CreatedBy As String

    Public Overrides Function ToString() As String
        Return GetClassData()
    End Function

    Protected Overridable Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Is Active: " + IsActive.ToString())
        sb.AppendLine("Modified Date: " + ModifedDate.ToLongDateString())
        sb.AppendLine("Created By: " + CreatedBy.ToString())

        Return sb.ToString()
    End Function

End Class
