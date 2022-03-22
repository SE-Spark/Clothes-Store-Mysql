Public Class Item
    Dim _itemId As Integer
    Dim _qnty As Integer
    Dim _date As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal mItemId As Integer, ByVal mQnty As Integer, ByVal mDate As String)
        _itemId = mItemId
        _date = mDate
        _qnty = mQnty
    End Sub
    Public Property mItemId As Integer

        Get
            Return _itemId
        End Get
        Set(ByVal value As Integer)
            _itemId = value
        End Set
    End Property
    Public Property mQnty As Integer

        Get
            Return _qnty
        End Get
        Set(ByVal value As Integer)
            _qnty = value
        End Set
    End Property
    Public Property mDate As String

        Get
            Return _date
        End Get
        Set(ByVal val As String)
            _date = val
        End Set
    End Property
End Class
