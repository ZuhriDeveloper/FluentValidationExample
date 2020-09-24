
Public Class Member
        Private _memberName As String
        Public Property MemberName() As String
            Get
                Return _memberName
            End Get
            Set(ByVal value As String)
                _memberName = value
            End Set
        End Property

        Private _memberAddress As String
    Public Property MemberAddress() As String
        Get
            Return _memberAddress
        End Get
        Set(ByVal value As String)
            _memberAddress = value
        End Set
    End Property

    Private _houseNumber As String
    Public Property HouseNumber() As String
        Get
            Return _houseNumber
        End Get
        Set(ByVal value As String)
            _houseNumber = value
        End Set
    End Property

    Private _memberEmail As String
        Public Property MemberEmail() As String
            Get
                Return _memberEmail
            End Get
            Set(ByVal value As String)
                _memberEmail = value
            End Set
        End Property

        Private _memberAge As Short
        Public Property MemberAge() As Short
            Get
                Return _memberAge
            End Get
            Set(ByVal value As Short)
                _memberAge = value
            End Set
        End Property
    End Class


