Public Class Form1
    Dim num As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        num = Int((Rnd() * 73) + 1)
    End Sub
    Private Sub cmdDevinez_Click(sender As Object, e As EventArgs) Handles cmdDevinez.Click
        If IsNumeric(txtChiffre.Text) = False Then
            MsgBox("Veuillez entrez un chiffre de 1 à 73")
            Exit Sub
        End If
        If Val(txtChiffre.Text) < 1 Or Val(txtChiffre.Text) > 73 Then
            MsgBox("veuillez entrez un chiffre entre 1 et 73")
            Exit Sub
        End If
        If Val(txtChiffre.Text) > num Then
            MsgBox("Ce chiffre est trop haut")
        ElseIf Val(txtChiffre.Text) < num Then
            MsgBox("Ce chiffre est trop bas")
        Else
            MsgBox("Ce chiffre est BON! Bravo!")
            End
        End If
    End Sub
End Class
