'Malachi Marlow
'Spring 2025
'RCET2265
'DinerMenu
'https://github.com/MalachiMarlow/Address-Label-Program.git


Option Strict On
Option Explicit On

Public Class DinerMenuForm


    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "World Famous Star-soup!" & vbNewLine _
            & vbNewLine _
            & vbNewLine _
            & vbNewLine _
            & "This is our world-class soup. Recipe came straight from the star gates themselves. A crisp buttery flavour along with broth to die for, Nebuchadnezzar's soup special will leave you wanting more."
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "Le NSS" & vbNewLine _
            & vbNewLine _
            & vbNewLine _
            & vbNewLine _
            & "Our NSS (Nebuchadnezzar Salad Special) is formed from the Mesopotamian lettuce itself. Topped with the on-brand Nebuchadnezzar mustard sauce, our Salad will leave you saying Wow!"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "This is fish, fish good." & vbNewLine _
            & vbNewLine _
            & vbNewLine _
            & vbNewLine _
            & "This is cold-cut caught Cod. Or ask for the big C."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
