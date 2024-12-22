Public Class madFrm
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub genBtn_Click(sender As Object, e As EventArgs) Handles genBtn.Click
        If subLst.SelectedIndex = -1 Then
            MsgBox("Please select an item from the Subject list", , "Data Input Error")
        ElseIf verbLst.SelectedIndex = -1 Then
            MsgBox("Please select an item from the Verb list", , "Data Input Error")
        ElseIf adjLst.SelectedIndex = -1 Then
            MsgBox("Please select an item from the Adjective list", , "Data Input Error")
        ElseIf objLst.SelectedIndex = -1 Then
            MsgBox("Please select an item from the Object list", , "Data Input Error")
        Else
            Dim subject As String
            subject = subLst.Text
            Dim verb As String
            verb = verbLst.Text
            Dim adjective As String
            adjective = adjLst.Text
            Dim obj As String
            obj = objLst.Text
            storyLbl.Text = "One sunny day, " & subject & " decided to set off on a " & adjective & " adventure. They packed their bag and began their journey. As they wandered through the park, they stumbled upon a mysterious tree." & vbCrLf & vbCrLf &
                "Intrigued by its unusual shape, they felt a sudden urge to " & verb & " closer. Just then, they noticed something glittering beneath the leaves. With excitement bubbling inside, they reached down to uncover a hidden " & obj & "." & vbCrLf & vbCrLf &
                "What kind of adventure awaited them? Only time would tell!"
            If subLst.SelectedIndex = 0 Then
                objPic.Image = My.Resources.frodo
            ElseIf subLst.SelectedIndex = 1 Then
                objPic.Image = My.Resources.indy
            ElseIf subLst.SelectedIndex = 2 Then
                objPic.Image = My.Resources.james1
            ElseIf subLst.SelectedIndex = 3 Then
                objPic.Image = My.Resources.katniss1
            ElseIf subLst.SelectedIndex = 4 Then
                objPic.Image = My.Resources.luke
            ElseIf subLst.SelectedIndex = 5 Then
                objPic.Image = My.Resources.optimus
            ElseIf subLst.SelectedIndex = 6 Then
                objPic.Image = My.Resources.ron1
            ElseIf subLst.SelectedIndex = 7 Then
                objPic.Image = My.Resources.sherlock1
            ElseIf subLst.SelectedIndex = 8 Then
                objPic.Image = My.Resources.tony
            ElseIf subLst.SelectedIndex = 9 Then
                objPic.Image = My.Resources.wonder1
            End If
            titlePic.Visible = False
            subLbl.Visible = False
            verbLbl.Visible = False
            adjLbl.Visible = False
            objLbl.Visible = False
            subLst.Visible = False
            verbLst.Visible = False
            adjLst.Visible = False
            objLst.Visible = False
            instLbl.Visible = False
            genBtn.Visible = False
            storyLbl.Visible = True
            clrLbl.Visible = True
            clrBtn.Visible = True
            objPic.Visible = True
        End If
    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        subLst.SelectedIndex = -1
        verbLst.SelectedIndex = -1
        adjLst.SelectedIndex = -1
        objLst.SelectedIndex = -1
        titlePic.Visible = True
        subLbl.Visible = True
        verbLbl.Visible = True
        adjLbl.Visible = True
        objLbl.Visible = True
        subLst.Visible = True
        verbLst.Visible = True
        adjLst.Visible = True
        objLst.Visible = True
        instLbl.Visible = True
        genBtn.Visible = True
        storyLbl.Visible = False
        clrLbl.Visible = False
        clrBtn.Visible = False
        objPic.Visible = False
    End Sub
End Class
