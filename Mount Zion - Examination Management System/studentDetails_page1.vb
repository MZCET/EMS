
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports Mount_Zion___Examination_Management_System.variables

Public Class studentDetails_page1

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Public Function add_page1()
        'M_O_A = Admission_mode.SelectedItem
        M_O_I = Medium.SelectedItem
        S_O_M = Status_of_Medium.SelectedItem
        A_NUM = Allot_num.Text
        NAME_O_STU = Name_of_Student.Text
        INITIAL_O_N = initial.Text
        D_O_B = Dob.Text
        GENDER_ = Gender.SelectedItem
        Q_EXAM = Qualified_exam.SelectedItem
        F_NAME = father_name.Text
        M_NAME = Mother_name.Text
        'Y_O_P = yop.Text
    End Function

    Private Sub studentDetails_page1_Load(sender As Object, e As EventArgs)
        init()
    End Sub
    Public Function init()
        ' Admission_mode.SelectedItem = M_O_A
        Medium.SelectedItem = M_O_I
        Status_of_Medium.SelectedItem = S_O_M
        Allot_num.Text = A_NUM
        Name_of_Student.Text = NAME_O_STU
        initial.Text = INITIAL_O_N
        Dob.Text = D_O_B
        Gender.SelectedItem = GENDER_
        Qualified_exam.SelectedItem = Q_EXAM
        father_name.Text = F_NAME
        Mother_name.Text = M_NAME
        '   yop.Text = Y_O_P
    End Function



    Private Sub nxt_pg1_Click_1(sender As Object, e As EventArgs) Handles nxt_pg1.Click
        Dim frm = New studentDetails_page2
        frm.Show()
        frm.MdiParent = Main
        frm.StartPosition = FormStartPosition.CenterScreen
        add_page1()
        Me.Close()
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
        load_countries(p_con)
    End Sub

    Private Sub p_state_TextChanged(sender As Object, e As EventArgs) Handles p_state.TextChanged
        load_states(p_state)
    End Sub


    Private Sub Mode_of_Admission_Click(sender As Object, e As EventArgs) Handles Mode_of_Admission.Click
        If under_g.Checked Then
            Mode_of_Admission.Items.Clear()
            Mode_of_Admission.Items.AddRange({"Regular", "Part-time"})
        ElseIf post_g.Checked Then
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
            Qualified_exam.Items.Clear()
            Qualified_exam.Items.AddRange({"HSC-V", "HSC-A"})
        ElseIf post_g.Checked Then
            Qualified_exam.Items.Clear()
            Qualified_exam.Items.AddRange({"B.E", "B.Tech", "B.Arch"})
        ElseIf diploma.Checked Then
            Qualified_exam.Items.Clear()
            Qualified_exam.Items.AddRange({"Diploma", "B.Sc"})
        Else
            MsgBox("Please Select Filter")
        End If
    End Sub

    Private Sub nation_TextChanged(sender As Object, e As EventArgs) Handles nation.TextChanged
        load_countries(nation)

    End Sub

    Private Sub same_p_a_Click(sender As Object, e As EventArgs) Handles same_p_a.Click
        If same_p_a.Checked Then
            t_a1.Text = p_a1.Text
            t_a2.Text = p_a2.Text
            t_district.Text = p_district.Text
            t_pincode.Text = p_pincode.Text
            t_city.Text = p_city.Text
            t_country.Text = p_con.Text
            t_state.Text = p_state.Text
        Else
            t_a1.Text = ""
            t_a2.Text = ""
            t_district.Text = ""
            t_pincode.Text = ""
            t_city.Text = ""
            t_country.Text = ""
            t_state.Text = ""
        End If
    End Sub
End Class