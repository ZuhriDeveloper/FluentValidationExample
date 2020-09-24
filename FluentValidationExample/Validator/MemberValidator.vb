Imports FluentValidation

Public Class MemberValidator
    Inherits AbstractValidator(Of Member)

    Public Sub New()
        RuleFor(Function(x) x.MemberName).MinimumLength(3).WithMessage("Nama minimal 3 karakter")
        RuleFor(Function(x) x.MemberName).Must(AddressOf IsNotDuplicate).WithMessage("Nama sudah terdaftar")
        RuleFor(Function(x) x.MemberAddress).NotEmpty().When(Function(x) x.HouseNumber <> String.Empty).WithMessage("Alamat tidak boleh kosong jika nomor diisi")
        RuleFor(Function(x) x.MemberEmail).EmailAddress.When(Function(e) e.MemberEmail <> String.Empty).WithMessage("Format email salah")
        RuleFor(Function(x) x.MemberAge).GreaterThanOrEqualTo(17).WithMessage("Umur minimal 17 tahun")
    End Sub

    Private Function IsNotDuplicate(value As String) As Boolean
        'cek di sini apa data duplicate atau tidak di database, jika ada return false, jika tidak return true
        Return True
    End Function


End Class

