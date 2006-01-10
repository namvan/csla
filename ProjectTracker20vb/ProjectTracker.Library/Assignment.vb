Imports System.Data.SqlClient
Imports Csla.Validation
Imports System.Reflection

Friend Module Assignment

#Region " Business Methods "

  Public Function GetDefaultAssignedDate() As Date

    Return Today

  End Function

#End Region

#Region " Validation Rules "

  ''' <summary>
  ''' Ensure the Role property value exists
  ''' in RoleList
  ''' </summary>
  Public Function ValidRole(ByVal target As Object, ByVal e As RuleArgs) As Boolean

    Dim role As Integer = -1
    Dim p As PropertyInfo = _
      target.GetType.GetProperty(e.PropertyName)
    role = CInt(p.GetValue(target, Nothing))

    If RoleList.GetList.ContainsKey(role) Then
      Return True

    Else
      e.Description = "Role must be in RoleList"
      Return False
    End If

  End Function

#End Region

#Region " Data Access "

  Public Function AddAssignment( _
    ByVal cn As SqlConnection, ByVal projectId As Guid, ByVal resourceId As Integer, _
    ByVal assigned As SmartDate, ByVal role As Integer) As Byte()

    Using cm As SqlCommand = cn.CreateCommand()
      cm.CommandText = "addAssignment"
      Return DoAddUpdate( _
        cm, projectId, resourceId, assigned, role)
    End Using

  End Function

  Public Function UpdateAssignment(ByVal cn As SqlConnection, _
    ByVal projectId As Guid, ByVal resourceId As Integer, ByVal assigned As SmartDate, _
    ByVal newRole As Integer, ByVal timestamp() As Byte) As Byte()

    Using cm As SqlCommand = cn.CreateCommand()
      cm.CommandText = "updateAssignment"
      cm.Parameters.AddWithValue("@lastChanged", timestamp)
      Return DoAddUpdate( _
        cm, projectId, resourceId, assigned, newRole)
    End Using

  End Function

  Private Function DoAddUpdate(ByVal cm As SqlCommand, _
    ByVal projectId As Guid, ByVal resourceId As Integer, ByVal assigned As SmartDate, _
    ByVal newRole As Integer) As Byte()

    Dim result(0 To 7) As Byte
    cm.CommandType = CommandType.StoredProcedure
    cm.Parameters.AddWithValue("@projectId", projectId)
    cm.Parameters.AddWithValue("@resourceId", resourceId)
    cm.Parameters.AddWithValue("@assigned", assigned.DBValue)
    cm.Parameters.AddWithValue("@role", newRole)

    Using dr As SqlDataReader = cm.ExecuteReader()
      dr.Read()
      ' get the new timestamp for the row
      dr.GetBytes(0, 0, result, 0, 8)
    End Using
    Return result

  End Function

  Public Sub RemoveAssignment( _
    ByVal cn As SqlConnection, ByVal projectId As Guid, ByVal resourceId As Integer)

    Using cm As SqlCommand = cn.CreateCommand()
      cm.CommandType = CommandType.StoredProcedure
      cm.CommandText = "deleteAssignment"
      cm.Parameters.AddWithValue("@projectId", projectId)
      cm.Parameters.AddWithValue("@resourceId", resourceId)

      cm.ExecuteNonQuery()
    End Using

  End Sub

#End Region

End Module
