Public Class RandomSentencesForm
    Dim nouns() As String = {"lamp", "carpet", "apple", "doorknob", "sprocket", "dragon", "egg"}
    Dim adjectives() As String = {"responsive", "mobile", "large", "dominant", "robust"}
    Dim verbs() As String = {"jumped", "ran", "breathed", "chewed"}
    Dim prepositions() As String = {"by", "near", "through", "on", "with", "over", "under"}
    Dim articles() As String = {"the", "a"}

    Dim rnd As Random

    Dim nounCount() As Integer = {0, 0, 0, 0, 0, 0, 0}


    Private Sub AddSentence()

        Dim nounIndex As Integer = rnd.Next(0, nouns.Length)
        nounCount(nounIndex) += 1

        Dim nounDisplay As String = ""
        For Each n As Integer In nounCount
            nounDisplay += n.ToString + " "
        Next
        txtMetrics.Text = nounDisplay

        Dim firstWord As String = articles(rnd.Next(0, articles.Length))
        firstWord = firstWord.Substring(0, 1).ToUpper + firstWord.Substring(1)

        lstSentences.Items.Add(firstWord + " " + _
                                    adjectives(rnd.Next(0, adjectives.Length)) + " " + _
                                    nouns(nounIndex) + " " + _
                                    verbs(rnd.Next(0, verbs.Length)) + " " + _
                                    prepositions(rnd.Next(0, prepositions.Length)) + " " + _
                                    articles(rnd.Next(0, articles.Length)) + " " + _
                                    adjectives(rnd.Next(0, adjectives.Length)) + " " + _
                                    nouns(rnd.Next(0, nouns.Length)) + ".")
        lstSentences.TopIndex = lstSentences.Items.Count - 1
    End Sub

    Private Sub RandomSentencesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rnd = New Random()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddSentence()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSentences.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        tmrAuto.Enabled = Not tmrAuto.Enabled
        btnAuto.Text = If(tmrAuto.Enabled, "Stop", "Start")
    End Sub

    Private Sub tmrAuto_Tick(sender As Object, e As EventArgs) Handles tmrAuto.Tick
        AddSentence()
    End Sub
End Class