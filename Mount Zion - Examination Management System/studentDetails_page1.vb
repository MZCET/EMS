
Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.Security.Cryptography.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports Microsoft.Data.SqlClient
Imports Mount_Zion___Examination_Management_System.variables

Public Class studentDetails_page1
    Dim cb As New CodeBank
    Dim connectionString As String = Main.cstring
    Dim stu_img() As Byte
    Dim sign_image() As Byte
    Dim hand_img() As Byte


    Private Sub nxt_pg1_Click_1(sender As Object, e As EventArgs) Handles nxt_pg1.Click

        If ((under_g.Checked = False And post_g.Checked = False And diploma.Checked = False) Or Mode_of_Admission.SelectedItem = "" Or Medium.SelectedItem = "" Or Status_of_Medium.SelectedItem = "" Or Allot_num.Text = "" Or unicode_name.Text = "" Or Name_of_Student.Text = "" Or print.Text = "" Or initial_of_stu.Text = "" Or religion.SelectedItem = "" Or communityy.SelectedItem = "" Or Dob.Text = "" Or Gender.SelectedItem = "" Or Qualified_exam.SelectedItem = "" Or aadhar_num.Text = "" Or mobile_no.Text = "" Or mail.Text = "" Or m_tongue.SelectedItem = "" Or spr.Text = "" Or nation.Text = "" Or father_name.Text = "" Or Mother_name.Text = "" Or yop.Text = "" Or n_of_instu.Text = "" Or regulation.SelectedItem = "" Or programme.SelectedItem = "" Or yoj.Text = "" Or o_p_p.Text = "") Then
            MsgBox("Please fill all fields")
        ElseIf (t_a1.Text = "" Or t_a1.Text = "" Or t_a2.Text = "" Or t_district.Text = "" Or t_pincode.Text = "" Or t_city.Text = "" Or t_country.Text = "" Or t_state.Text = "") Then
            MsgBox("Please Fill the temporary Address")
        ElseIf (p_a1.Text = "" Or p_a1.Text = "" Or p_a2.Text = "" Or p_district.Text = "" Or p_pincode.Text = "" Or p_city.Text = "" Or p_con.Text = "" Or p_state.Text = "") Then
            MsgBox("Please Fill the permanent Address")
            ''ElseIf (stu_img.ToString = "") Then
            '    MsgBox("Please upload student's image")
            ' ElseIf (sign_image.ToString = "") Then
            'MsgBox("Please upload student's signature image")
        Else
            If cb.IsValidEmail(mail.Text) = False Then
                MessageBox.Show("Email address is not valid.")
            ElseIf Int64.Parse(Allot_num.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid allotment number.")
            ElseIf Int64.Parse(mobile_no.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid mobile number.")
            ElseIf Int64.Parse(aadhar_num.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid aadhar number.")
            ElseIf Int64.Parse(yop.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid year.")
            ElseIf Int64.Parse(yoj.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid year.")
            ElseIf Int64.Parse(o_p_p.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid percentage.")
            ElseIf Int64.Parse(spr.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid spr.no.")
            ElseIf Int64.Parse(t_pincode.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid pincode.")
            ElseIf Int64.Parse(p_pincode.Text) * 1 = 0 Then
                MessageBox.Show("Enter valid pincode.")
            Else
                Try
                    Confirmation()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub






    Public Function load_countries(txtfield)
        Dim source As New AutoCompleteStringCollection()
        source.AddRange({"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        txtfield.AutoCompleteMode = AutoCompleteMode.Suggest
        txtfield.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtfield.AutoCompleteCustomSource = source
    End Function

    Public Function load_states(txtfield)
        Dim source As New AutoCompleteStringCollection()
        source.AddRange({"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"})
        txtfield.AutoCompleteMode = AutoCompleteMode.Suggest
        txtfield.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtfield.AutoCompleteCustomSource = source
    End Function



    Private Sub p_con_TextChanged(sender As Object, e As EventArgs) Handles p_con.TextChanged
        Try
            load_countries(p_con)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub p_state_TextChanged(sender As Object, e As EventArgs) Handles p_state.TextChanged
        Try
            load_states(p_state)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Mode_of_Admission_Click(sender As Object, e As EventArgs) Handles Mode_of_Admission.Click
        If under_g.Checked Or post_g.Checked Then
            Mode_of_Admission.Items.Clear()
            Mode_of_Admission.Items.AddRange({"Regular", "Part-time"})
        ElseIf diploma.Checked Then
            Mode_of_Admission.Items.Clear()
            Mode_of_Admission.Items.AddRange({"Regular", "Lateral"})
        Else
            MsgBox("Please Select Filter")
        End If
    End Sub

    Private Sub Qualified_exam_Click(sender As Object, e As EventArgs) Handles Qualified_exam.Click
        If under_g.Checked Then
            Qualified_exam.DropDownHeight = 40
            Qualified_exam.Items.Clear()
            Qualified_exam.Items.AddRange({"HSC-V", "HSC-A"})
        ElseIf post_g.Checked Then
            Qualified_exam.DropDownHeight = 40
            Qualified_exam.Items.Clear()
            Qualified_exam.Items.AddRange({"B.E", "B.Tech", "B.Arch"})
        ElseIf diploma.Checked Then
            Qualified_exam.DropDownHeight = 40
            Qualified_exam.Items.Clear()
            Qualified_exam.Items.AddRange({"Diploma", "B.Sc"})
        Else
            MsgBox("Please Select Filter")
        End If
    End Sub

    Private Sub nation_TextChanged(sender As Object, e As EventArgs) Handles nation.TextChanged
        Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub same_p_a_Click(sender As Object, e As EventArgs) Handles same_p_a.Click
        If p_a1.Text = "" Or p_a2.Text = "" Or p_district.Text = "" Or p_pincode.Text = "" Or p_city.Text = "" Or p_con.Text = "" Or p_state.Text = "" Then
            same_p_a.Checked = False
            MsgBox("Please Fill the Permanent Address")
        Else

            If same_p_a.Checked Then
                t_a1.ReadOnly = True
                t_a2.ReadOnly = True
                t_district.ReadOnly = True
                t_pincode.ReadOnly = True
                t_city.ReadOnly = True
                t_country.ReadOnly = True
                t_state.ReadOnly = True
                t_a1.Text = p_a1.Text
                t_a2.Text = p_a2.Text
                t_district.Text = p_district.Text
                t_pincode.Text = p_pincode.Text
                t_city.Text = p_city.Text
                t_country.Text = p_con.Text
                t_state.Text = p_state.Text
            Else
                t_a1.ReadOnly = False
                t_a2.ReadOnly = False
                t_district.ReadOnly = False
                t_pincode.ReadOnly = False
                t_city.ReadOnly = False
                t_country.ReadOnly = False
                t_state.ReadOnly = False
                t_a1.Text = ""
                t_a2.Text = ""
                t_district.Text = ""
                t_pincode.Text = ""
                t_city.Text = ""
                t_country.Text = ""
                t_state.Text = ""
            End If
        End If

    End Sub



    Private Sub programme_Click(sender As Object, e As EventArgs) Handles programme.Click
        If regulation.SelectedItem = "" Then
            MsgBox("Please select regualtion")
        Else
            programme.Items.Clear()
            cb.Add_list("select * from regulations as reg inner join program as pro on reg.regulationId=pro.regulationId where regName='" + regulation.SelectedItem + "'", programme, "ProgramShortName")
        End If
    End Sub
    Private Sub upload_photo_Click(sender As Object, e As EventArgs) Handles upload_photo.Click
        Dim path_name = cb.pick_file
        If path_name <> "" Then
            Dim image As Image = Image.FromFile(path_name)
            stu_img = File.ReadAllBytes(path_name)
            Student_img.Image = image
            Student_img.Visible = True
        End If

    End Sub

    Private Sub upload_sign_Click(sender As Object, e As EventArgs) Handles upload_sign.Click
        Dim path_name = cb.pick_file
        If path_name <> "" Then
            Dim image As Image = Image.FromFile(path_name)
            sign_image = File.ReadAllBytes(path_name)
            sign_img.Image = image
            sign_img.Visible = True
        End If
    End Sub

    Private Sub upload_handwritting_Click(sender As Object, e As EventArgs) Handles upload_handwritting.Click
        Dim path_name = cb.pick_file
        If path_name <> "" Then
            Dim image As Image = Image.FromFile(path_name)
            hand_img = File.ReadAllBytes(path_name)
            handwritten_img.Image = image
            handwritten_img.Visible = True
        End If
    End Sub

    Private Sub studentDetails_page1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sign_img.Visible = False
        Student_img.Visible = False
        handwritten_img.Visible = False
        cb.Add_list("select * from regulations", regulation, "RegName")
    End Sub

    Private Sub Allot_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Allot_num.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub aadhar_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles aadhar_num.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub mobile_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobile_no.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub yop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles yop.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub yoj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles yoj.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub t_pincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_pincode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub p_pincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles p_pincode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub o_p_p_KeyPress(sender As Object, e As KeyPressEventArgs) Handles o_p_p.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub spr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spr.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Public Function Confirmation()
        Dim a, b, c As Integer
        Dim t As String

        t = "Please Confirm the details ..."
        t = t & vbCrLf & vbCrLf & " Filter : " & "UG"
        t = t & vbCrLf & " Mode of Admission : " & Mode_of_Admission.SelectedItem
        t = t & vbCrLf & " Medium of Instruction : " & Medium.SelectedItem
        t = t & vbCrLf & " If Tamil Medium : " & Status_of_Medium.SelectedItem
        t = t & vbCrLf & " Allotement Number : " & Allot_num.Text
        t = t & vbCrLf & " Name of the Student (unicode) : " & unicode_name.Text
        t = t & vbCrLf & " Name of the Student : " & Name_of_Student.Text
        t = t & vbCrLf & " Print Name : " & print.Text
        t = t & vbCrLf & " Religion : " & religion.SelectedItem
        t = t & vbCrLf & " Community : " & communityy.SelectedItem
        t = t & vbCrLf & " D.O.B : " & Dob.Text
        t = t & vbCrLf & " Gender : " & Gender.SelectedItem
        t = t & vbCrLf & " Qualifying Exam : " & Qualified_exam.SelectedItem
        t = t & vbCrLf & " Aadhar Number : " & aadhar_num.Text
        t = t & vbCrLf & " Mobile Number : " & mobile_no.Text
        t = t & vbCrLf & " Mail Id : " & mail.Text
        t = t & vbCrLf & " Mother Tongue: " & m_tongue.Text
        a = MsgBox(t, vbOKCancel, "Please Confirm ...")
        If a = vbOK Then
            t = "Please Confirm the details ..."
            t = t & vbCrLf & vbCrLf & " Spr.No : " & spr.Text
            t = t & vbCrLf & " Nationality : " & nation.Text
            t = t & vbCrLf & " Father's Name : " & father_name.Text
            t = t & vbCrLf & " Mother's Name : " & Mother_name.Text
            t = t & vbCrLf & " Year of Passing : " & yop.Text
            t = t & vbCrLf & " Name of the Instution : " & n_of_instu.Text
            t = t & vbCrLf & " Name of the Regulation : " & regulation.SelectedItem
            t = t & vbCrLf & " Name of the Programme : " & programme.SelectedItem
            t = t & vbCrLf & " Year of Joining : " & yoj.Text
            t = t & vbCrLf & " Overall Pass Percentage : " & o_p_p.Text
            t = t & vbCrLf & " Permanent Address : "
            t = t & vbCrLf & " Address 1 : " & p_a1.Text
            t = t & vbCrLf & " Address 2 : " & p_a2.Text
            t = t & vbCrLf & " District : " & p_district.Text
            t = t & vbCrLf & " Pincode : " & p_pincode.Text
            t = t & vbCrLf & " City/Town/Village : " & p_city.Text
            t = t & vbCrLf & " Country : " & p_con.Text
            t = t & vbCrLf & " State : " & p_state.Text
            b = MsgBox(t, vbOKCancel, "Please Confirm ...")
            If b = vbOK Then
                t = "Please Confirm the details ..."
                t = t & vbCrLf & vbCrLf & " Temporary Address : "
                t = t & vbCrLf & " Address 1 : " & t_a1.Text
                t = t & vbCrLf & " Address 2 : " & t_a2.Text
                t = t & vbCrLf & " District : " & t_district.Text
                t = t & vbCrLf & " Pincode : " & t_pincode.Text
                t = t & vbCrLf & " City/Town/Village : " & t_city.Text
                t = t & vbCrLf & " Country : " & t_country.Text
                t = t & vbCrLf & " State : " & t_state.Text
                c = MsgBox(t, vbOKCancel, "Please Confirm ...")
                If c = vbOK Then
                    Add_Student()
                End If
            End If

        End If
    End Function


    Public Function Add_Student()
        Try
            Dim sql As String = "INSERT INTO student_info (TempId, Category, Modeofadmission, Medium, IsTamilMedium, AllotMentNumber, UnicodeName, StudentName, PrintName, Initial, Religion, Community, Dob, Gender, QualifiedExam, AadharNumber, MobileNumber, MailId, MotherTongue, Sprno, Nationality, FatherName, MotherName, Yearofpassing, Nameoftheinstution, RegulationId, ProgrammeName, Yearofjoining, CuttOff, OverallPassPercentage, AddressLine1Per, AddressLine2Per, DistrictPer, PincodePer, CityPer, CountryPer, StatePer, AddressLine1Temp, AddressLine2Temp, DistrictTemp, PincodeTemp, CityTemp, CountryTemp, StateTemp,Photo,Signature,Handwriting) VALUES (@TempId, @Category, @Modeofadmission, @Medium, @IsTamilMedium, @AllotMentNumber,@UnicodeName, @StudentName, @PrintName, @Initial, @Religion, @Community, @Dob, @Gender, @QualifiedExam, @AadharNumber, @MobileNumber, @MailId, @MotherTongue, @Sprno, @Nationality, @FatherName, @MotherName, @Yearofpassing, @Nameoftheinstution, @RegulationId, @ProgrammeName, @Yearofjoining, @CuttOff, @OverallPassPercentage, @AddressLine1Per, @AddressLine2Per, @DistrictPer, @PincodePer, @CityPer, @CountryPer, @StatePer, @AddressLine1Temp, @AddressLine2Temp, @DistrictTemp, @PincodeTemp, @CityTemp, @CountryTemp, @StateTemp,@Photo,@signature,@Handwriting)"
            Using con As New SqlConnection(Main.cstring)
                Using command As New SqlCommand(sql, con)
                    command.Parameters.AddWithValue("@TempId", 0)
                    command.Parameters.AddWithValue("@Category", "ug")
                    command.Parameters.AddWithValue("@Modeofadmission", Mode_of_Admission.Text)
                    command.Parameters.AddWithValue("@Medium", Medium.SelectedItem)
                    command.Parameters.AddWithValue("@IsTamilMedium", Status_of_Medium.SelectedItem)
                    command.Parameters.AddWithValue("@AllotMentNumber", Int64.Parse(Allot_num.Text))
                    command.Parameters.AddWithValue("@UnicodeName", unicode_name.Text)
                    command.Parameters.AddWithValue("@StudentName", Name_of_Student.Text)
                    command.Parameters.AddWithValue("@PrintName", print.Text)
                    command.Parameters.AddWithValue("@Initial", initial_of_stu.Text)
                    command.Parameters.AddWithValue("@Religion", religion.Text)
                    command.Parameters.AddWithValue("@Community", communityy.SelectedItem)
                    command.Parameters.AddWithValue("@Dob", Dob.Text)
                    command.Parameters.AddWithValue("@Gender", Gender.SelectedItem)
                    command.Parameters.AddWithValue("@QualifiedExam", Qualified_exam.SelectedItem)
                    command.Parameters.AddWithValue("@AadharNumber", Int64.Parse(aadhar_num.Text))
                    command.Parameters.AddWithValue("@MobileNumber", Int64.Parse(mobile_no.Text))
                    command.Parameters.AddWithValue("@MailId", mail.Text)
                    command.Parameters.AddWithValue("@MotherTongue", m_tongue.Text)
                    command.Parameters.AddWithValue("@Sprno", Int64.Parse(spr.Text))
                    command.Parameters.AddWithValue("@Nationality", nation.Text)
                    command.Parameters.AddWithValue("@FatherName", father_name.Text)
                    command.Parameters.AddWithValue("@MotherName", Mother_name.Text)
                    command.Parameters.AddWithValue("@Yearofpassing", yop.Text)
                    command.Parameters.AddWithValue("@Nameoftheinstution", n_of_instu.Text)
                    command.Parameters.AddWithValue("@RegulationId", regulation.Text)
                    command.Parameters.AddWithValue("@ProgrammeName", programme.SelectedItem)
                    command.Parameters.AddWithValue("@Yearofjoining", yoj.Text)
                    command.Parameters.AddWithValue("@CuttOff", o_p_p.Text)
                    command.Parameters.AddWithValue("@OverallPassPercentage", o_p_p.Text)
                    command.Parameters.AddWithValue("@AddressLine1Per", p_a1.Text)
                    command.Parameters.AddWithValue("@AddressLine2Per", p_a2.Text)
                    command.Parameters.AddWithValue("@DistrictPer", p_district.Text)
                    command.Parameters.AddWithValue("@PincodePer", p_pincode.Text)
                    command.Parameters.AddWithValue("@CityPer", p_city.Text)
                    command.Parameters.AddWithValue("@CountryPer", p_con.Text)
                    command.Parameters.AddWithValue("@StatePer", p_state.Text)
                    command.Parameters.AddWithValue("@AddressLine1Temp", t_a1.Text)
                    command.Parameters.AddWithValue("@AddressLine2Temp", t_a2.Text)
                    command.Parameters.AddWithValue("@DistrictTemp", t_district.Text)
                    command.Parameters.AddWithValue("@PincodeTemp", t_pincode.Text)
                    command.Parameters.AddWithValue("@CityTemp", t_city.Text)
                    command.Parameters.AddWithValue("@CountryTemp", t_country.Text)
                    command.Parameters.AddWithValue("@StateTemp", t_state.Text)
                    command.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = stu_img
                    command.Parameters.Add("@signature", SqlDbType.VarBinary, -1).Value = sign_image
                    command.Parameters.Add("@Handwriting", SqlDbType.VarBinary, -1).Value = hand_img
                    con.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Student Add Sucessfully !")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            p_a1.Text = ex.ToString

        End Try



    End Function
End Class