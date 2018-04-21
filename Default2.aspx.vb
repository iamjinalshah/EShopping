
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub UpdateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateButton1.Click, UpdateButton2.Click
        DateTimeLabel1.Text = DateTime.Now.ToString()
        DateTimeLabel2.Text = DateTime.Now.ToString()
    End Sub
End Class
