'Imports System.String
'Imports System.Boolean
'Imports System.Data
'Imports System.Data.OleDb
'Partial Class login1
'    Inherits System.Web.UI.Page
'    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\login\WebSites\WebSite1\sec_watch.accdb") '"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\trupti\login\WebSite1\sec_watch.accdb") "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\login\WebSites\WebSite1\sec_watch.accdb")
'    Dim cmd As OleDbCommand
'    Shared c As String

'    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
'        If DropDownList1.SelectedIndex = 0 Then
'            Try
'                con.Open()
'                'cmd = New OleDbCommand("select Pattern from login where User_id='piyu1029' and Pattern='12a5a9a5a'", con)
'                cmd = New OleDbCommand("select Gname from login where User_id='" + TextBox1.Text + "' and Gname='" + TextBox2.Text + "'", con)
'                Dim o As Object
'                o = cmd.ExecuteScalar
'                If o IsNot Nothing Then
'                    MsgBox("Valid")
'                    Response.Redirect("forgot.aspx")
'                Else
'                    MsgBox("Invalid")
'                End If
'                con.Close()
'            Catch ex As Exception
'                MsgBox("Error")
'            End Try



'        End If

'    End Sub

'    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
'        c = c + "8a"
'    End Sub

'    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
'        c = c + "12a"
'    End Sub

'    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Button1.Click
'        c = c + "1a"



'    End Sub

'    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
'        c = c + "2a"
'    End Sub

'    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
'        c = c + "3a"
'    End Sub

'    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
'c = c + "4a"
'    End Sub

'    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
'        c = c + "5a"
'    End Sub

'    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
'        c = c + "6a"
'    End Sub

'    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
'        c = c + "7a"
'    End Sub

'    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
'        c = c + "9a"
'    End Sub

'    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
'        c = c + "10a"
'    End Sub

'    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
'        c = c + "11a"
'    End Sub

'    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
'        c = c + "13a"
'    End Sub

'    Protected Sub ImageButton14_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton14.Click
'        c = c + "14a"
'    End Sub

'    Protected Sub ImageButton15_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton15.Click
'        c = c + "15a"
'    End Sub

'    Protected Sub ImageButton16_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton16.Click
'        c = c + "16a"
'    End Sub
'    'Dim a As Boolean = False

'    'a =comparestrings (c,"select pattern from login where uid='priya'",0)

'    'If (a=0) Then Msgbox=("valid user") End If

'    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

'        Try
'            con.Open()
'            'cmd = New OleDbCommand("select Pattern from login where User_id='piyu1029' and Pattern='12a5a9a5a'", con)
'            cmd = New OleDbCommand("select Pattern from login where User_id='" + TextBox1.Text + "' and Pattern='" + c + "'", con)
'            Dim o As Object
'            o = cmd.ExecuteScalar
'            If o IsNot Nothing Then
'                MsgBox("Valid")
'                System.Diagnostics.Process.Start("D:\login\WebSites\WebSite1\SendSMS_AT.exe")
'                'Response.Redirect("Default.aspx")
'            Else
'                MsgBox("Invalid")
'            End If
'            con.Close()
'        Catch ex As Exception
'            'MsgBox("Error")
'        End Try
'        c = ""
'    End Sub



'    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
'        Try
'            Session("uid") = TextBox1.Text
'            con.Open()
'            cmd = New OleDbCommand("Select Gname from login where User_id='" + TextBox1.Text + "'and Gname='" + TextBox2.Text + "'", con)
'            Dim o As Object
'            o = cmd.ExecuteScalar
'            If o IsNot Nothing Then
'                MsgBox("Valid user")
'                Response.Redirect("forgot.aspx")
'            Else
'                MsgBox("Sorry!!! unauthorized user")
'            End If
'            con.Close()
'        Catch ex As Exception

'        End Try
'    End Sub


'End Class

Imports System.String
Imports System.Boolean
Imports System.Data
Imports System.Data.OleDb
Partial Class login1
    Inherits System.Web.UI.Page
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\login\WebSites\WebSite1\sec_watch.accdb") '"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\trupti\login\WebSite1\sec_watch.accdb") "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\login\WebSites\WebSite1\sec_watch.accdb")
    Dim cmd As OleDbCommand
    Shared c As String

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.SelectedIndex = 0 Then
            Try
                con.Open()
                'cmd = New OleDbCommand("select Pattern from login where User_id='piyu1029' and Pattern='12a5a9a5a'", con)
                cmd = New OleDbCommand("select Gname from login where User_id='" + TextBox1.Text + "' and Gname='" + TextBox2.Text + "'", con)
                Dim o As Object
                o = cmd.ExecuteScalar
                If o IsNot Nothing Then
                    MsgBox("Valid")
                    Response.Redirect("forgot.aspx")
                Else
                    MsgBox("Invalid")
                End If
                con.Close()
            Catch ex As Exception
                MsgBox("Error")
            End Try



        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        c = c + "8a"
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        c = c + "12a"
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        c = c + "1a"



    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        c = c + "2a"
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        c = c + "3a"
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        c = c + "4a"
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        c = c + "5a"
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        c = c + "6a"
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        c = c + "7a"
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        c = c + "9a"
    End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        c = c + "10a"
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        c = c + "11a"
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        c = c + "13a"
    End Sub

    Protected Sub ImageButton14_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton14.Click
        c = c + "14a"
    End Sub

    Protected Sub ImageButton15_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton15.Click
        c = c + "15a"
    End Sub

    Protected Sub ImageButton16_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton16.Click
        c = c + "16a"
    End Sub
    'Dim a As Boolean = False

    'a =comparestrings (c,"select pattern from login where uid='priya'",0)

    'If (a=0) Then Msgbox=("valid user") End If

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            con.Open()
            'cmd = New OleDbCommand("select Pattern from login where User_id='piyu1029' and Pattern='12a5a9a5a'", con)
            cmd = New OleDbCommand("select Pattern from login where User_id='" + TextBox1.Text + "' and Pattern='" + c + "'", con)
            Dim o As Object
            o = cmd.ExecuteScalar
            If o IsNot Nothing Then
                MsgBox("Valid")
                System.Diagnostics.Process.Start("D:\login\WebSites\WebSite1\SendSMS_AT.exe")
                'Response.Redirect("Default.aspx")
            Else
                MsgBox("Invalid")
            End If
            con.Close()
        Catch ex As Exception
            'MsgBox("Error")
        End Try
        c = ""
    End Sub

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Session("uid") = TextBox1.Text
            con.Open()
            cmd = New OleDbCommand("Select Gname from login where User_id='" + TextBox1.Text + "'and Gname='" + TextBox2.Text + "'", con)
            Dim o As Object
            o = cmd.ExecuteScalar
            If o IsNot Nothing Then
                MsgBox("Valid user")
                Response.Redirect("forgot.aspx")
            Else
                MsgBox("Sorry!!! unauthorized user")
            End If
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub ImageButton32_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

    End Sub
End Class

