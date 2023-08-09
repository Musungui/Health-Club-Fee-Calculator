Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radAdult.CheckedChanged

    End Sub

    Private Sub lblMonths_Click(sender As Object, e As EventArgs) Handles lblMonths.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim intDuration As Integer
            Dim decMonthlyFee, decTotalFee, decBaseFee, decDiscount As Decimal
            intDuration = txtMonths.Text
            If intDuration < 1 Or intDuration > 24 Then
                MessageBox.Show("Length duration out of range. Enter duration from 1 to 24")

                Select Case intDuration
                    Case Is <= 3
                        decDiscount = 0
                    Case 4 To 6
                        decDiscount = decBaseFee * 0.05
                    Case 7 To 9
                        decDiscount = decBaseFee * 0.08
                    Case Is >= 10
                        decDiscount = decBaseFee * 0.1
                    Case Else
                        MessageBox.Show("Ivalid discount value")

                End Select

            ElseIf radAdult.Checked = True Then
                decBaseFee = 40

                If chkYoga.Checked And chkKarate.Checked And chkPersonalTrainer.Checked Then
                    decBaseFee = 50 + 70 + 90
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked And chkKarate.Checked Then
                    decBaseFee = 50 + 70
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked And chkPersonalTrainer.Checked Then
                    decBaseFee = 50 + 90
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked And chkKarate.Checked Then
                    decBaseFee = 90 + 70
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked Then
                    decBaseFee += 10
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkKarate.Checked Then
                    decBaseFee += 30
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked Then
                    decBaseFee += 50
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                Else
                    MessageBox.Show("Select at least one option")
                End If

            ElseIf radChild.Checked = True Then
                decBaseFee = 20
                If chkYoga.Checked Then
                    decBaseFee += 10
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkKarate.Checked Then
                    decBaseFee += 30
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked Then
                    decBaseFee += 50
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                End If
            ElseIf radStudent.Checked = True Then
                decBaseFee = 25
                If chkYoga.Checked And chkKarate.Checked And chkPersonalTrainer.Checked Then
                    decBaseFee = 35 + 55 + 75
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked And chkKarate.Checked Then
                    decBaseFee = 35 + 55
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked And chkPersonalTrainer.Checked Then
                    decBaseFee = 35 + 75
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked And chkKarate.Checked Then
                    decBaseFee = 75 + 55
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked Then
                    decBaseFee += 10
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkKarate.Checked Then
                    decBaseFee += 30
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked Then
                    decBaseFee += 50
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                Else
                    MessageBox.Show("Select at least one option")
                End If
            ElseIf radSenior.Checked = True Then
                decBaseFee = 30
                If chkYoga.Checked And chkKarate.Checked And chkPersonalTrainer.Checked Then
                    decBaseFee = 40 + 60 + 80
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked And chkKarate.Checked Then
                    decBaseFee = 40 + 60
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkYoga.Checked And chkPersonalTrainer.Checked Then
                    decBaseFee = 40 + 80
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked And chkKarate.Checked Then
                    decBaseFee = 80 + 60
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee

                ElseIf chkYoga.Checked Then
                    decBaseFee += 10
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkKarate.Checked Then
                    decBaseFee += 30
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee
                ElseIf chkPersonalTrainer.Checked Then
                    decBaseFee += 50
                    decMonthlyFee = decBaseFee - decDiscount
                    decTotalFee = decMonthlyFee * intDuration
                    lblMonthlyFee.Text = decMonthlyFee
                    lblTotalFee.Text = decTotalFee

                End If

            Else
                MessageBox.Show("Select Membership Type")

            End If


        Catch ex As Exception
            MessageBox.Show("Fill All the fields")
        End Try

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
