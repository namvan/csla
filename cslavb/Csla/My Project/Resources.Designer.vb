﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Csla.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Merge only allowed on custom collection objects.
        '''</summary>
        Friend ReadOnly Property BrokenRulesMergeException() As String
            Get
                Return ResourceManager.GetString("BrokenRulesMergeException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Principal must be of type BusinessPrincipal, not.
        '''</summary>
        Friend ReadOnly Property BusinessPrincipalException() As String
            Get
                Return ResourceManager.GetString("BusinessPrincipalException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Changing an element is an invalid operation.
        '''</summary>
        Friend ReadOnly Property ChangeInvalidException() As String
            Get
                Return ResourceManager.GetString("ChangeInvalidException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Can not directly mark a child object for deletion - use its parent collection.
        '''</summary>
        Friend ReadOnly Property ChildDeleteException() As String
            Get
                Return ResourceManager.GetString("ChildDeleteException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Clear is an invalid operation.
        '''</summary>
        Friend ReadOnly Property ClearInvalidException() As String
            Get
                Return ResourceManager.GetString("ClearInvalidException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid operation - create not allowed.
        '''</summary>
        Friend ReadOnly Property CreateNotSupportedException() As String
            Get
                Return ResourceManager.GetString("CreateNotSupportedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid operation - delete not allowed.
        '''</summary>
        Friend ReadOnly Property DeleteNotSupportedException() As String
            Get
                Return ResourceManager.GetString("DeleteNotSupportedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit level mismatch in {0}.
        '''</summary>
        Friend ReadOnly Property EditLevelMismatchException() As String
            Get
                Return ResourceManager.GetString("EditLevelMismatchException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error reading value:.
        '''</summary>
        Friend ReadOnly Property ErrorReadingValueException() As String
            Get
                Return ResourceManager.GetString("ErrorReadingValueException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid operation - execute not allowed.
        '''</summary>
        Friend ReadOnly Property ExecuteNotSupportedException() As String
            Get
                Return ResourceManager.GetString("ExecuteNotSupportedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to failed.
        '''</summary>
        Friend ReadOnly Property Failed() As String
            Get
                Return ResourceManager.GetString("Failed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to failed on the server.
        '''</summary>
        Friend ReadOnly Property FailedOnServer() As String
            Get
                Return ResourceManager.GetString("FailedOnServer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid operation - fetch not allowed.
        '''</summary>
        Friend ReadOnly Property FetchNotSupportedException() As String
            Get
                Return ResourceManager.GetString("FetchNotSupportedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Filter parameter and filter provider are required.
        '''</summary>
        Friend ReadOnly Property FilterRequiredException() As String
            Get
                Return ResourceManager.GetString("FilterRequiredException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Business object must supply a non-null ID value in GetIdValue.
        '''</summary>
        Friend ReadOnly Property GetIdValueCantBeNull() As String
            Get
                Return ResourceManager.GetString("GetIdValueCantBeNull", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Insert is an invalid operation.
        '''</summary>
        Friend ReadOnly Property InsertInvalidException() As String
            Get
                Return ResourceManager.GetString("InsertInvalidException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid operation - insert not allowed.
        '''</summary>
        Friend ReadOnly Property InsertNotSupportedException() As String
            Get
                Return ResourceManager.GetString("InsertNotSupportedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Child object must implement IEditableBusinessObject or IEditableCollection.
        '''</summary>
        Friend ReadOnly Property InvalidChildTypeException() As String
            Get
                Return ResourceManager.GetString("InvalidChildTypeException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid rule method (instance methods of the target object not allowed).
        '''</summary>
        Friend ReadOnly Property InvalidRuleMethodException() As String
            Get
                Return ResourceManager.GetString("InvalidRuleMethodException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} can not exceed {1}.
        '''</summary>
        Friend ReadOnly Property MaxValueRule() As String
            Get
                Return ResourceManager.GetString("MaxValueRule", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to method call failed.
        '''</summary>
        Friend ReadOnly Property MethodCallFailed() As String
            Get
                Return ResourceManager.GetString("MethodCallFailed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Method execution not allowed.
        '''</summary>
        Friend ReadOnly Property MethodExecuteNotAllowed() As String
            Get
                Return ResourceManager.GetString("MethodExecuteNotAllowed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to not implemented.
        '''</summary>
        Friend ReadOnly Property MethodNotImplemented() As String
            Get
                Return ResourceManager.GetString("MethodNotImplemented", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} can not be less than {1}.
        '''</summary>
        Friend ReadOnly Property MinValueRule() As String
            Get
                Return ResourceManager.GetString("MinValueRule", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ApplyEdit is not valid on a child object.
        '''</summary>
        Friend ReadOnly Property NoApplyEditChildException() As String
            Get
                Return ResourceManager.GetString("NoApplyEditChildException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to BeginEdit is not valid on a child object.
        '''</summary>
        Friend ReadOnly Property NoBeginEditChildException() As String
            Get
                Return ResourceManager.GetString("NoBeginEditChildException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to CancelEdit is not valid on a child object.
        '''</summary>
        Friend ReadOnly Property NoCancelEditChildException() As String
            Get
                Return ResourceManager.GetString("NoCancelEditChildException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid for root objects - use Delete instead.
        '''</summary>
        Friend ReadOnly Property NoDeleteRootException() As String
            Get
                Return ResourceManager.GetString("NoDeleteRootException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No principal object should be passed to DataPortal when using Windows integrated security.
        '''</summary>
        Friend ReadOnly Property NoPrincipalAllowedException() As String
            Get
                Return ResourceManager.GetString("NoPrincipalAllowedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Can not directly save a child object.
        '''</summary>
        Friend ReadOnly Property NoSaveChildException() As String
            Get
                Return ResourceManager.GetString("NoSaveChildException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Object is still being edited and can not be saved.
        '''</summary>
        Friend ReadOnly Property NoSaveEditingException() As String
            Get
                Return ResourceManager.GetString("NoSaveEditingException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Object is not valid and can not be saved.
        '''</summary>
        Friend ReadOnly Property NoSaveInvalidException() As String
            Get
                Return ResourceManager.GetString("NoSaveInvalidException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No such factory method:{0}.
        '''</summary>
        Friend ReadOnly Property NoSuchFactoryMethod() As String
            Get
                Return ResourceManager.GetString("NoSuchFactoryMethod", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No such value exists:.
        '''</summary>
        Friend ReadOnly Property NoSuchValueExistsException() As String
            Get
                Return ResourceManager.GetString("NoSuchValueExistsException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Argument must not be null.
        '''</summary>
        Friend ReadOnly Property NothingNotValid() As String
            Get
                Return ResourceManager.GetString("NothingNotValid", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Parent value can only be set for child objects.
        '''</summary>
        Friend ReadOnly Property ParentSetException() As String
            Get
                Return ResourceManager.GetString("ParentSetException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Type parameter must be a primitive type.
        '''</summary>
        Friend ReadOnly Property PrimitiveTypeRequired() As String
            Get
                Return ResourceManager.GetString("PrimitiveTypeRequired", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Property copy failed.
        '''</summary>
        Friend ReadOnly Property PropertyCopyFailed() As String
            Get
                Return ResourceManager.GetString("PropertyCopyFailed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Property get not allowed.
        '''</summary>
        Friend ReadOnly Property PropertyGetNotAllowed() As String
            Get
                Return ResourceManager.GetString("PropertyGetNotAllowed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Property load or set failed for property {0} ({1}).
        '''</summary>
        Friend ReadOnly Property PropertyLoadException() As String
            Get
                Return ResourceManager.GetString("PropertyLoadException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Property set not allowed.
        '''</summary>
        Friend ReadOnly Property PropertySetNotAllowed() As String
            Get
                Return ResourceManager.GetString("PropertySetNotAllowed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} does not match regular expression.
        '''</summary>
        Friend ReadOnly Property RegExMatchRule() As String
            Get
                Return ResourceManager.GetString("RegExMatchRule", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove is an invalid operation.
        '''</summary>
        Friend ReadOnly Property RemoveInvalidException() As String
            Get
                Return ResourceManager.GetString("RemoveInvalidException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to t.
        '''</summary>
        Friend ReadOnly Property SmartDateT() As String
            Get
                Return ResourceManager.GetString("SmartDateT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to today.
        '''</summary>
        Friend ReadOnly Property SmartDateToday() As String
            Get
                Return ResourceManager.GetString("SmartDateToday", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to tom.
        '''</summary>
        Friend ReadOnly Property SmartDateTom() As String
            Get
                Return ResourceManager.GetString("SmartDateTom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to tomorrow.
        '''</summary>
        Friend ReadOnly Property SmartDateTomorrow() As String
            Get
                Return ResourceManager.GetString("SmartDateTomorrow", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to y.
        '''</summary>
        Friend ReadOnly Property SmartDateY() As String
            Get
                Return ResourceManager.GetString("SmartDateY", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to yesterday.
        '''</summary>
        Friend ReadOnly Property SmartDateYesterday() As String
            Get
                Return ResourceManager.GetString("SmartDateYesterday", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} can not exceed {1} characters.
        '''</summary>
        Friend ReadOnly Property StringMaxLengthRule() As String
            Get
                Return ResourceManager.GetString("StringMaxLengthRule", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} can not be less than {1} characters.
        '''</summary>
        Friend ReadOnly Property StringMinLengthRule() As String
            Get
                Return ResourceManager.GetString("StringMinLengthRule", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} required.
        '''</summary>
        Friend ReadOnly Property StringRequiredRule() As String
            Get
                Return ResourceManager.GetString("StringRequiredRule", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to String value can not be converted to a date.
        '''</summary>
        Friend ReadOnly Property StringToDateException() As String
            Get
                Return ResourceManager.GetString("StringToDateException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to load type &apos;{0}&apos;.
        '''</summary>
        Friend ReadOnly Property TypeLoadException() As String
            Get
                Return ResourceManager.GetString("TypeLoadException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid operation - update not allowed.
        '''</summary>
        Friend ReadOnly Property UpdateNotSupportedException() As String
            Get
                Return ResourceManager.GetString("UpdateNotSupportedException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Validation rule {1} failed in property {0}.
        '''</summary>
        Friend ReadOnly Property ValidationRuleException() As String
            Get
                Return ResourceManager.GetString("ValidationRuleException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Value is not a SmartDate.
        '''</summary>
        Friend ReadOnly Property ValueNotSmartDateException() As String
            Get
                Return ResourceManager.GetString("ValueNotSmartDateException", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
