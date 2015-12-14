Public Class Funcoes
    Public Sub Limpar(Receptor As Object)
        For Each Campo In Receptor.Controls

            If TypeOf Campo Is System.Windows.Forms.TabPage Or TypeOf Campo Is System.Windows.Forms.GroupBox Or TypeOf Campo Is System.Windows.Forms.Panel Then
                Limpar(Campo)
            End If

            If TypeOf Campo Is System.Windows.Forms.TextBox Then
                Campo.text = ""
            End If
            If TypeOf Campo Is System.Windows.Forms.ComboBox Then
                If Campo.DropDownstyle = System.Windows.Forms.ComboBoxStyle.DropDownList Then
                    Campo.SelectedIndex = -1
                End If
            End If
            If TypeOf Campo Is System.Windows.Forms.MaskedTextBox Then
                Campo.text = ""
            End If
            If TypeOf Campo Is System.Windows.Forms.NumericUpDown Then
                Campo.value = Campo.Minimum
            End If
            If TypeOf Campo Is System.Windows.Forms.CheckBox Then
                Campo.Checked = False
            End If
            If TypeOf Campo Is System.Windows.Forms.DateTimePicker Then
                Campo.Value = Date.Today
            End If
        Next
    End Sub

    Public Function Caracteres(CharCode As Integer)
        Return Chr(CharCode)
    End Function

End Class
