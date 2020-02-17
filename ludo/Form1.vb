Imports WMPLib
Public Class Ludo
    Dim randomString, randomString1 As Integer
    Dim Player As New WindowsMediaPlayer
    Sub st()
        Dim chars = "123456"
        Dim random = New Random(Guid.NewGuid().GetHashCode())
        randomString = New String(Enumerable.Repeat(chars, 1).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

        Dim chars1 = "123456"
        Dim random1 = New Random(Guid.NewGuid().GetHashCode())
        randomString1 = New String(Enumerable.Repeat(chars, 1).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

        If randomString = 1 Then N1.BackgroundImage = My.Resources.z1
        If randomString = 2 Then N1.BackgroundImage = My.Resources.z2
        If randomString = 3 Then N1.BackgroundImage = My.Resources.z3
        If randomString = 4 Then N1.BackgroundImage = My.Resources.z4
        If randomString = 5 Then N1.BackgroundImage = My.Resources.z5
        If randomString = 6 Then N1.BackgroundImage = My.Resources.z6

        If randomString1 = 1 Then N2.BackgroundImage = My.Resources.z1
        If randomString1 = 2 Then N2.BackgroundImage = My.Resources.z2
        If randomString1 = 3 Then N2.BackgroundImage = My.Resources.z3
        If randomString1 = 4 Then N2.BackgroundImage = My.Resources.z4
        If randomString1 = 5 Then N2.BackgroundImage = My.Resources.z5
        If randomString1 = 6 Then N2.BackgroundImage = My.Resources.z6
    End Sub
    Dim cellvalue(2) As String
    Dim cell(4) As String
    Dim str1 As String = "l1"
    'Dim str2 = 0
    'Dim str3 = 0
    'Dim str4 = 0
    Dim sty1 As String = "l14"
    'Dim sty2 = 0
    'Dim sty3 = 0
    'Dim sty4 = 0
    Dim stg1 As String = "l27"
    'Dim stg2 = 0
    'Dim stg3 = 0
    'Dim stg4 = 0
    Dim stb1 As String = "l40"
    'Dim stb2 = 0
    'Dim stb3 = 0
    'Dim stb4 = 0
    Sub makeparts(ByVal location As String)
        'make location two part  if location=A7 >>> Cell1 =A   Cell2 =7
        cellvalue(0) = location.Chars(0)
        If location.Length > 2 Then
            cellvalue(1) = location.Chars(1) & location.Chars(2)
        Else
            cellvalue(1) = location.Chars(1)
        End If
    End Sub
    Function def1(ByVal chk As PictureBox)
        Dim re 
        If Label4.Text.Contains("red") Then chk.BackgroundImage = red.BackgroundImage
        If Label4.Text.Contains("blue") Then chk.BackgroundImage = blue.BackgroundImage
        If Label4.Text.Contains("green") Then chk.BackgroundImage = green.BackgroundImage
        If Label4.Text.Contains("yellow") Then chk.BackgroundImage = yellow.BackgroundImage
        Return re
    End Function
    Dim mx1 As Boolean
    Dim mx2 As Boolean
    Dim mx3 As Boolean
    Dim missgame = 0
    Sub checkend(ByVal nm As Integer)
        Dim c
        If Label4.Text.Contains("red") And nm >= 51 Then 
            c = nm - 51
            cellvalue(0) = "R"
            cellvalue(1) = c
            If c > 6 Then
                missgame = 1
            Else
                missgame = 0 : def2("R" & c)
            End If
        End If
        If Label4.Text.Contains("yellow") Then 
            If cellvalue(1) + randomString + randomString1 > 12 And mx1 = True Then
                c = cellvalue(1) + randomString + randomString1 - 12
                cellvalue(0) = "y"
                If c > 6 Then
                    missgame = 1
                Else
                    missgame = 0 : def2("y" & c)
                End If
            End If
        End If
        If Label4.Text.Contains("green") Then
            If cellvalue(1) + randomString + randomString1 > 25 And mx2 = True Then
                c = cellvalue(1) + randomString + randomString1 - 25
                cellvalue(0) = "g"
                If c > 6 Then
                    missgame = 1
                Else
                    missgame = 0 : def2("g" & c)
                End If
            End If
        End If
        If Label4.Text.Contains("blue") Then
            If cellvalue(1) + randomString + randomString1 > 38 And mx3 = True Then
                c = cellvalue(1) + randomString + randomString1 - 38
                cellvalue(0) = "b"
                If c > 6 Then
                    missgame = 1
                Else
                    missgame = 0 : def2("b" & c)
                End If
            End If
        End If
    End Sub
    Function def2(ByVal chk As String)
        Dim re
        If chk = "l1" Then re = def1(l1) : def1(l1)
        If chk = "l2" Then re = def1(l2) : def1(l2)
        If chk = "l3" Then re = def1(l3) : def1(l3)
        If chk = "l4" Then re = def1(l4) : def1(l4)
        If chk = "l5" Then re = def1(l5) : def1(l5)
        If chk = "l6" Then re = def1(l6) : def1(l6)
        If chk = "l7" Then re = def1(l7) : def1(l7)
        If chk = "l8" Then re = def1(l8) : def1(l8)

        If chk = "l9" Then re = def1(l9) : def1(l9)
        If chk = "l10" Then re = def1(l10) : def1(l10)
        If chk = "l11" Then re = def1(l11) : def1(l11)
        If chk = "l12" Then re = def1(l12) : def1(l12)
        If chk = "l13" Then re = def1(l13) : def1(l13)
        If chk = "l14" Then re = def1(l14) : def1(l14)
        If chk = "l15" Then re = def1(l15) : def1(l15)
        If chk = "l16" Then re = def1(l16) : def1(l16)

        If chk = "l17" Then re = def1(l17) : def1(l17)
        If chk = "l18" Then re = def1(l18) : def1(l18)
        If chk = "l19" Then re = def1(l19) : def1(l19)
        If chk = "l20" Then re = def1(l20) : def1(l20)
        If chk = "l21" Then re = def1(l21) : def1(l21)
        If chk = "l22" Then re = def1(l22) : def1(l22)
        If chk = "l23" Then re = def1(l23) : def1(l23)
        If chk = "l24" Then re = def1(l24) : def1(l24)

        If chk = "l25" Then re = def1(l25) : def1(l25)
        If chk = "l26" Then re = def1(l26) : def1(l26)
        If chk = "l27" Then re = def1(l27) : def1(l27)
        If chk = "l28" Then re = def1(l28) : def1(l28)
        If chk = "l29" Then re = def1(l29) : def1(l29)
        If chk = "l30" Then re = def1(l30) : def1(l30)
        If chk = "l31" Then re = def1(l31) : def1(l31)
        If chk = "l32" Then re = def1(l32) : def1(l32)

        If chk = "l33" Then re = def1(l33) : def1(l33)
        If chk = "l34" Then re = def1(l34) : def1(l34)
        If chk = "l35" Then re = def1(l35) : def1(l35)
        If chk = "l36" Then re = def1(l36) : def1(l36)
        If chk = "l37" Then re = def1(l37) : def1(l37)
        If chk = "l38" Then re = def1(l38) : def1(l38)
        If chk = "l39" Then re = def1(l39) : def1(l39)
        If chk = "l40" Then re = def1(l40) : def1(l40)

        If chk = "l41" Then re = def1(l41) : def1(l41)
        If chk = "l42" Then re = def1(l42) : def1(l42)
        If chk = "l43" Then re = def1(l43) : def1(l43)
        If chk = "l44" Then re = def1(l44) : def1(l44)
        If chk = "l45" Then re = def1(l45) : def1(l45)
        If chk = "l46" Then re = def1(l46) : def1(l46)
        If chk = "l47" Then re = def1(l47) : def1(l47)
        If chk = "l48" Then re = def1(l48) : def1(l48)

        If chk = "l49" Then re = def1(l49) : def1(l49)
        If chk = "l50" Then re = def1(l50) : def1(l50)
        If chk = "l51" Then re = def1(l51) : def1(l51)
        If chk = "l52" Then re = def1(l52) : def1(l52)

        If chk = "R1" Then re = def1(R1) : def1(R1)
        If chk = "R2" Then re = def1(R2) : def1(R2)
        If chk = "R3" Then re = def1(R3) : def1(R3)
        If chk = "R4" Then re = def1(R4) : def1(R4)
        If chk = "R5" Then re = def1(R5) : def1(R5)

        If chk = "y1" Then re = def1(y1) : def1(y1)
        If chk = "y2" Then re = def1(y2) : def1(y2)
        If chk = "y3" Then re = def1(y3) : def1(y3)
        If chk = "y4" Then re = def1(y4) : def1(y4)
        If chk = "y5" Then re = def1(y5) : def1(y5)

        If chk = "g1" Then re = def1(g1) : def1(g1)
        If chk = "g2" Then re = def1(g2) : def1(g2)
        If chk = "g3" Then re = def1(g3) : def1(g3)
        If chk = "g4" Then re = def1(g4) : def1(g4)
        If chk = "g5" Then re = def1(g5) : def1(g5)

        If chk = "b1" Then re = def1(b1) : def1(b1)
        If chk = "b2" Then re = def1(b2) : def1(b2)
        If chk = "b3" Then re = def1(b3) : def1(b3)
        If chk = "b4" Then re = def1(b4) : def1(b4)
        If chk = "b5" Then re = def1(b5) : def1(b5)
        Return re
    End Function
    Sub go(ByVal lastlocation As String)
        'red    start= l1   End=l51
        'yellow start= l14  End=l12
        'green  start= l27  End=l25
        'blue   start= l40  End=l38 
        makeparts(lastlocation)
        ' TextBox1.Text = "" 
        reset() 
        If cellvalue(1) + randomString + randomString1 >= 52 Then

            If Label4.Text.Contains("yellow") Then mx1 = True
            If Label4.Text.Contains("green") Then mx2 = True
            If Label4.Text.Contains("blue") Then mx3 = True
            cellvalue(1) = cellvalue(1) - 52
        End If
        If cellvalue(0).Contains("l") Then
            checkend(cellvalue(1) + randomString + randomString1)
        Else

        End If 
        If Label4.Text.Contains("red") And missgame = 0 Then str1 = cellvalue(0) & cellvalue(1) + randomString + randomString1 : def2(cellvalue(0) & (cellvalue(1) + randomString + randomString1))
        If Label4.Text.Contains("yellow") And missgame = 0 Then sty1 = cellvalue(0) & cellvalue(1) + randomString + randomString1 : def2(cellvalue(0) & (cellvalue(1) + randomString + randomString1))
        If Label4.Text.Contains("green") And missgame = 0 Then stg1 = cellvalue(0) & cellvalue(1) + randomString + randomString1 : def2(cellvalue(0) & (cellvalue(1) + randomString + randomString1))
        If Label4.Text.Contains("blue") And missgame = 0 Then stb1 = cellvalue(0) & cellvalue(1) + randomString + randomString1 : def2(cellvalue(0) & (cellvalue(1) + randomString + randomString1))

    End Sub
    Dim ty
    Sub cho()
        If ty = ListBox1.Items.Count Then
            ty = 0
        End If
        Label4.Text = ListBox1.Items.Item(ty)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Player.URL = "D:\stop wifi\Program vb.net\games\ludo\Resources\s.mp3"
        : Player.controls.play()
        ty += 1
        : Timer1.Start()
        cho()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
      l1.Click, l2.Click, l3.Click, l4.Click, l5.Click, l6.Click, l7.Click, l8.Click, _
      l9.Click, l10.Click, l11.Click, l12.Click, l13.Click, l14.Click, l15.Click, l16.Click, _
      l17.Click, l18.Click, l19.Click, l20.Click, l21.Click, l22.Click, l23.Click, l24.Click, _
      l25.Click, l26.Click, l27.Click, l28.Click, l29.Click, l30.Click, l31.Click, l32.Click, _
      l33.Click, l34.Click, l35.Click, l36.Click, l37.Click, l38.Click, l39.Click, l40.Click, _
      l41.Click, l42.Click, l43.Click, l44.Click, l45.Click, l46.Click, l47.Click, l48.Click, _
      l49.Click, l50.Click, l51.Click, l52.Click, _
      R1.Click, R2.Click, R3.Click, R4.Click, R5.Click, _
      y1.Click, y2.Click, y3.Click, y4.Click, y5.Click, _
      g1.Click, g2.Click, g3.Click, g4.Click, g5.Click, _
      b1.Click, b2.Click, b3.Click, b4.Click, b5.Click
        Dim picBox As PictureBox = DirectCast(sender, PictureBox)
        Dim name As String = picBox.Name
        Label3.Text = "Selected : " & name

        If Label4.Text.Contains("red") And redc.Checked = True Then
            Label4.Text = "Game on  : yellow"
        ElseIf Label4.Text.Contains("yellow") And CheckBox1.Checked = True Then
            Label4.Text = "Game on  : green"
        ElseIf Label4.Text.Contains("green") And CheckBox2.Checked = True Then
            Label4.Text = "Game on  : blue"
        ElseIf Label4.Text.Contains("blue") And CheckBox3.Checked = True Then
            Label4.Text = "Game on  : red"
        End If
    End Sub
    Sub reset()
        Red1.BackgroundImage = red.BackgroundImage
        Red2.BackgroundImage = red.BackgroundImage
        Red3.BackgroundImage = red.BackgroundImage
        Red4.BackgroundImage = red.BackgroundImage


        yellow1.BackgroundImage = yellow.BackgroundImage
        yellow2.BackgroundImage = yellow.BackgroundImage
        yellow3.BackgroundImage = yellow.BackgroundImage
        yellow4.BackgroundImage = yellow.BackgroundImage

        green1.BackgroundImage = green.BackgroundImage
        green2.BackgroundImage = green.BackgroundImage
        green3.BackgroundImage = green.BackgroundImage
        green4.BackgroundImage = green.BackgroundImage

        blue1.BackgroundImage = blue.BackgroundImage
        blue2.BackgroundImage = blue.BackgroundImage
        blue3.BackgroundImage = blue.BackgroundImage
        blue4.BackgroundImage = blue.BackgroundImage

        Dim pics As New List(Of PictureBox) From {l1, l2, l3, l4, l5, l6, l7, l8, _
      l9, l10, l11, l12, l13, l14, l15, l16, _
      l17, l18, l19, l20, l21, l22, l23, l24, _
      l25, l26, l27, l28, l29, l30, l31, l32, _
      l33, l34, l35, l36, l37, l38, l39, l40, _
      l41, l42, l43, l44, l45, l46, l47, l48, _
      l49, l50, l51, l52, _
      R1, R2, R3, R4, R5, _
      y1, y2, y3, y4, y5, _
      g1, g2, g3, g4, g5, _
      b1, b2, b3, b4, b5}
        For Each pic In pics
            If pic.BackgroundImage Is red.BackgroundImage And Label4.Text.Contains("red") And missgame = 0 Then pic.BackgroundImage = Nothing
            If pic.BackgroundImage Is blue.BackgroundImage And Label4.Text.Contains("blue") And missgame = 0 Then pic.BackgroundImage = Nothing
            If pic.BackgroundImage Is green.BackgroundImage And Label4.Text.Contains("green") And missgame = 0 Then pic.BackgroundImage = Nothing
            If pic.BackgroundImage Is yellow.BackgroundImage And Label4.Text.Contains("yellow") And missgame = 0 Then pic.BackgroundImage = Nothing
        Next

    End Sub
    Private Sub Ludo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'reset()
    End Sub
    Dim cunt As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        st()
        cunt += 1
        If cunt > 6 Then
            cunt = 0
            TextBox1.Text = cellvalue(0) & (cellvalue(1) + randomString + randomString1)
            If Label4.Text.Contains("blue") Then go(stb1)
            If Label4.Text.Contains("green") Then go(stg1)
            If Label4.Text.Contains("yellow") Then go(sty1)
            If Label4.Text.Contains("red") Then go(str1)
            Timer1.Stop()
        End If
    End Sub

    Private Sub redc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redc.CheckedChanged
        If redc.Checked = True Then
            Red1.BackgroundImage = red.BackgroundImage
            Red2.BackgroundImage = red.BackgroundImage
            Red3.BackgroundImage = red.BackgroundImage
            Red4.BackgroundImage = red.BackgroundImage
            Label7.Text = Label7.Text & " red "
            ListBox1.Items.Add("Game on  : red")
        Else
            Red1.BackgroundImage = Nothing
            Red2.BackgroundImage = Nothing
            Red3.BackgroundImage = Nothing
            Red4.BackgroundImage = Nothing
            Label7.Text = Label7.Text.Replace(" red ", "")
            ListBox1.Items.Remove("Game on  : red")

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            yellow1.BackgroundImage = yellow.BackgroundImage
            yellow2.BackgroundImage = yellow.BackgroundImage
            yellow3.BackgroundImage = yellow.BackgroundImage
            yellow4.BackgroundImage = yellow.BackgroundImage
            Label7.Text = Label7.Text & " yellow "
            ListBox1.Items.Add("Game on  : yellow")
        Else
            yellow1.BackgroundImage = Nothing
            yellow2.BackgroundImage = Nothing
            yellow3.BackgroundImage = Nothing
            yellow4.BackgroundImage = Nothing
            Label7.Text = Label7.Text.Replace(" yellow ", "")
            ListBox1.Items.Remove("Game on  : yellow")
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            green1.BackgroundImage = green.BackgroundImage
            green2.BackgroundImage = green.BackgroundImage
            green3.BackgroundImage = green.BackgroundImage
            green4.BackgroundImage = green.BackgroundImage
            Label7.Text = Label7.Text & " green "
            ListBox1.Items.Add("Game on  : green")
        Else
            green1.BackgroundImage = Nothing
            green2.BackgroundImage = Nothing
            green3.BackgroundImage = Nothing
            green4.BackgroundImage = Nothing
            Label7.Text = Label7.Text.Replace(" green ", "")
            ListBox1.Items.Remove("Game on  : green")
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            blue1.BackgroundImage = blue.BackgroundImage
            blue2.BackgroundImage = blue.BackgroundImage
            blue3.BackgroundImage = blue.BackgroundImage
            blue4.BackgroundImage = blue.BackgroundImage
            Label7.Text = Label7.Text & " blue "
            ListBox1.Items.Add("Game on  : blue")
        Else
            blue1.BackgroundImage = Nothing
            blue2.BackgroundImage = Nothing
            blue3.BackgroundImage = Nothing
            blue4.BackgroundImage = Nothing
            Label7.Text = Label7.Text.Replace(" blue ", "")
            ListBox1.Items.Remove("Game on  : blue")
        End If

    End Sub

End Class
