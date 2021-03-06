Partial Class AnthemDataDataContext
    Public Sub ProcessData()
        Dim _r As DialogResult = MessageBox.Show("You are about to reprocess Anthem data in the data warehouse, which could take up to 90 minutes to complete." & vbCrLf & vbCrLf _
                                         & "During the processing you can continue to work, however, you will not be allowed to close the Ascension Analytics application until it completes." & vbCrLf & vbCrLf _
                                         & "Would you like to continue?", "Process Anthem Data: PLEASE CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)

        If _r = DialogResult.Yes Then
            Try
                Dim _originalCommandTimeout As Integer = Me.CommandTimeout

                Me.CommandTimeout = 0

                Me.AnthemClaimsSummary_LoadDenormForNightlyCompile()
                Me.AnthemClaimsSummary_FinishAndCleanUp()

                Me.CommandTimeout = _originalCommandTimeout
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class

