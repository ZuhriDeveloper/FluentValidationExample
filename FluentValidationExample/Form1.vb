
Imports FluentValidation.Results

Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            Dim member As Member = MappingFromUi()
            Dim validator As New MemberValidator
            Dim validationResult As ValidationResult = validator.Validate(member)

            If validationResult.IsValid Then
                MessageBox.Show("Member valid")
            Else
                Dim errorMessage = GenerateErrorMessage(validationResult.Errors)
                Throw New Exception(errorMessage)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function MappingFromUi() As Member
        Dim member As New Member
        member.MemberName = txtNama.Text.Trim()
        member.MemberAddress = txtAlamat.Text.Trim()
        member.HouseNumber = txtNomor.Text.Trim()
        member.MemberAge = numAge.Value
        member.MemberEmail = txtEmail.Text.Trim()
        Return member
    End Function

    Private Function GenerateErrorMessage(errors As IList(Of ValidationFailure)) As String
        Dim errMessage As String = String.Empty
        For Each Err As ValidationFailure In errors
            errMessage &= Err.ErrorMessage & vbCrLf
        Next
        Return errMessage
    End Function
End Class
