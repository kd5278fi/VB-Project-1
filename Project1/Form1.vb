Public Class Form1

    Private objDeck As New ArrayList
    Dim SuitTypes(3) As String

    Public Sub createCard(sValue As String, cNumber As Integer)
        Dim objNewCard As Card
        objNewCard.NumberValue = cNumber
        objNewCard.Suit = sValue
        Select Case cNumber
            Case 1
                objNewCard.FaceValue = "One"
            Case 2
                objNewCard.FaceValue = "Two"
            Case 3
                objNewCard.FaceValue = "Three"
            Case 4
                objNewCard.FaceValue = "Four"
            Case 5
                objNewCard.FaceValue = "Five"
            Case 6
                objNewCard.FaceValue = "Six"
            Case 7
                objNewCard.FaceValue = "Seven"
            Case 8
                objNewCard.FaceValue = "Eight"
            Case 9
                objNewCard.FaceValue = "Nine"
            Case 10
                objNewCard.FaceValue = "Ten"
            Case 11
                objNewCard.FaceValue = "Jack"
            Case 12
                objNewCard.FaceValue = "Queen"
            Case 13
                objNewCard.FaceValue = "King"
        End Select

        objDeck.Add(objNewCard)
        'Do object to assign facevalue based on number value
        'Case statement
        lstPlayer.Items.Add(objNewCard)
    End Sub

    Public Sub buildDeck()
        For number As Integer = 1 To 13
            For Each suit As String In SuitTypes
                createCard(suit, number)
            Next
        Next
    End Sub

    Public Sub playCard()
        Dim objRandom As New Random
        Dim deckAmount As Integer = objDeck.Count - 1
        Dim intRandomNum As Integer = 0
        '  MessageBox.Show(CStr(objDeck.Count))
        intRandomNum = objRandom.Next(deckAmount)
        lstComputer.Items.Add(objDeck.Item(intRandomNum))
        objDeck.RemoveAt(intRandomNum)
        'MessageBox.Show(CStr(objDeck.Count))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


        SuitTypes(0) = ChrW(9829)
        SuitTypes(1) = ChrW(9824)
        SuitTypes(2) = ChrW(9830)
        SuitTypes(3) = ChrW(9827)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        objDeck.Clear()
        buildDeck()

    End Sub

    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        playCard()
    End Sub
End Class