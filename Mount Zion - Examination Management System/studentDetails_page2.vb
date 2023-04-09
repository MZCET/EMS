Public Class studentDetails_page2
    Public Function Addpage2()
        ' MOTHER_TONGUE_ = mother_tongue.Text
        'COMMUNITY = communityy.SelectedItem
        'AADHAR_NUMBER = aadhar_num.Text
        ' T_A_1_ = t_a_1.Text
        'T_A_2_ = t_a_2.Text
        'T_DISTRICT_ = t_district.Text
        'T_PINCODE_ = t_pincode.Text
        '
        'T_C_T_V_ = t_ctv.Text
        'T_COUNTRY_ = t_country.Text
        'T_STATE_ = t_state.Text
        'MAIL_ID_ = mail_id.Text
        'NATIONALITY_ = nationality.Text
        'MOB_NUM_ = mob_num.Text
        ' P_A_1_ = p_a_1.Text
        'P_A_2_ = p_a_2.Text
        'P_DISTRICT_ = p_district.Text
        'P_PINCODE_ = p_pincode.Text
        'P_C_T_V_ = p_ctv.Text
        'P_COUNTRY_ = p_country.Text
        'P_STATE_ = p_state.Text

    End Function

    Public Function Page2_init()
        'mother_tongue.Text = MOTHER_TONGUE_
        'communityy.SelectedItem = COMMUNITY
        'aadhar_num.Text = AADHAR_NUMBER
        ' t_a_1.Text = T_A_1_
        't_a_2.Text = T_A_2_
        't_district.Text = T_DISTRICT_
        't_pincode.Text = T_PINCODE_
        't_ctv.Text = T_C_T_V_
        ' t_country.Text = T_COUNTRY_
        't_state.Text = T_STATE_
        'mail_id.Text = MAIL_ID_
        'nationality.Text = NATIONALITY_
        'mob_num.Text = MOB_NUM_
        ' p_a_1.Text = P_A_1_
        'p_a_2.Text = P_A_2_
        'p_district.Text = P_DISTRICT_
        'p_pincode.Text = P_PINCODE_
        'p_ctv.Text = P_C_T_V_
        'p_country.Text = P_COUNTRY_
        'p_state.Text = P_STATE_
    End Function

    Private Sub studentDetails_page2_Load(sender As Object, e As EventArgs)
        Page2_init()
    End Sub


    Private Sub prev_page2_Click_1(sender As Object, e As EventArgs) Handles prev_page2.Click
        Dim frm = studentDetails_page1
        frm.Show()
        frm.MdiParent = Main
        Addpage2()
        Me.Close()
    End Sub
End Class