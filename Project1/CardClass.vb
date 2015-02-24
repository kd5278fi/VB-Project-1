
Public Structure Card
    Public NumberValue As Integer
    Public FaceValue As String
    Public Suit As String

    Public Overrides Function ToString() As String
        Return FaceValue & " of " & Suit
    End Function

End Structure