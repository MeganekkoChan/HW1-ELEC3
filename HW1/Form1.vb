Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("Txt.txt", True)
        Txt.WriteLine("Name : " + name)
        Txt.WriteLine("Age : " + age)
        Txt.WriteLine("Address : " + add)
        Txt.Close()

        If Btn Then
            MessageBox.Show("Text is Created @ '\HW1\bin\Debug' ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("XML.xml", True)
        Txt.WriteLine("<Name>" + name + "</Name>")
        Txt.WriteLine("<Age>" + age + "</Age>")
        Txt.WriteLine("<Address>" + add + "</Address>")
        Txt.Close()

        If Btn Then
            MessageBox.Show("XML is Created @ '\HW1\bin\Debug' ")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("JSON.json", True)
        Txt.WriteLine("{")
        Txt.WriteLine("  ""Name:"" " + name + ",")
        Txt.WriteLine("  ""Age:"" " + age + ",")
        Txt.WriteLine("  ""Address:"" " + add)
        Txt.WriteLine("}")
        Txt.Close()

        If Btn Then
            MessageBox.Show("JSON is Created @ '\HW1\bin\Debug' ")
        End If
    End Sub
End Class
