
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports Microsoft.Data.SqlClient
Imports Mount_Zion___Examination_Management_System.variables

Public Class studentDetails_page1
    Dim cb As New CodeBank
    Dim connectionString As String = Main.cstring



    Private Sub nxt_pg1_Click_1(sender As Object, e As EventArgs) Handles nxt_pg1.Click
        If ((under_g.Checked = False And post_g.Checked = False And diploma.Checked = False) Or Mode_of_Admission.SelectedItem = "" Or Medium.SelectedItem = "" Or Status_of_Medium.SelectedItem = "" Or Allot_num.Text = "" Or unicode_name.Text = "" Or Name_of_Student.Text = "" Or print.Text = "" Or initial_of_stu.Text = "" Or religion.SelectedItem = "" Or communityy.SelectedItem = "" Or Dob.Text = "" Or Gender.SelectedItem = "" Or Qualified_exam.SelectedItem = "" Or aadhar_num.Text = "" Or mobile_no.Text = "" Or mail.Text = "" Or m_tongue.SelectedItem = "" Or spr.Text = "" Or nation.Text = "" Or father_name.Text = "" Or Mother_name.Text = "" Or yop.Text = "" Or n_of_instu.Text = "" Or regulation.SelectedItem = "" Or programme.SelectedItem = "" Or yoj.Text = "" Or o_p_p.Text = "") Then
            MsgBox("Please fill all fields")
        ElseIf (t_a1.Text = "" Or t_a1.Text = "" Or t_a2.Text = "" Or t_district.Text = "" Or t_pincode.Text = "" Or t_city.Text = "" Or t_country.Text = "" Or t_state.Text = "") Then
            MsgBox("Please Fill the temporary Address")
        ElseIf (p_a1.Text = "" Or p_a1.Text = "" Or p_a2.Text = "" Or p_district.Text = "" Or p_pincode.Text = "" Or t_city.Text = "" Or p_con.Text = "" Or p_state.Text = "") Then
            MsgBox("Please Fill the permanent Address")
        Else

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
            Dim fileData() As Byte = File.ReadAllBytes(path_name)
            Dim image As Image = Image.FromFile(path_name)
            Student_img.Image = image
            Student_img.Visible = True

        End If

    End Sub

    Private Sub upload_sign_Click(sender As Object, e As EventArgs) Handles upload_sign.Click
        Dim path_name = cb.pick_file
        If path_name <> "" Then
            Dim fileData() As Byte = File.ReadAllBytes(path_name)
            Dim image As Image = Image.FromFile(path_name)
            sign_img.Image = image
            sign_img.Visible = True
        End If
    End Sub

    Private Sub upload_handwritting_Click(sender As Object, e As EventArgs) Handles upload_handwritting.Click
        Dim path_name = cb.pick_file
        If path_name <> "" Then
            Dim fileData() As Byte = File.ReadAllBytes(path_name)
            Dim image As Image = Image.FromFile(path_name)
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
End Class