Public Class RandomSentencesForm
    Dim nouns() As String = {"lamp", "carpet", "apple", "doorknob", "sprocket", "dragon", "egg"}
    Dim adjectives() As String = {"responsive", "mobile", "large", "dominant", "robust"}
    Dim verbs() As String = {"jumped", "ran", "breathed", "chewed"}
    Dim prepositions() As String = {"by", "near", "through", "on", "with", "over", "under"}
    Dim articles() As String = {"the", "a"}

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim rnd As New Random

        Dim firstWord As String = articles(rnd.Next(0, articles.Length))
        firstWord = firstWord.Substring(0, 1).ToUpper + firstWord.Substring(1)

        lstSentences.Items.Add(firstWord + " " + _
                                    adjectives(rnd.Next(0, adjectives.Length)) + " " + _
                                    nouns(rnd.Next(0, nouns.Length)) + " " + _
                                    verbs(rnd.Next(0, verbs.Length)) + " " + _
                                    prepositions(rnd.Next(0, prepositions.Length)) + " " + _
                                    articles(rnd.Next(0, articles.Length)) + " " + _
                                    adjectives(rnd.Next(0, adjectives.Length)) + " " + _
                                    nouns(rnd.Next(0, nouns.Length)) + ".")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSentences.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class