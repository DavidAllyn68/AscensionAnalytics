﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="David")>  _
Partial Public Class SchoolgroupAssignmentsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertSchoolgroupAssignment(instance As SchoolgroupAssignment)
    End Sub
  Partial Private Sub UpdateSchoolgroupAssignment(instance As SchoolgroupAssignment)
    End Sub
  Partial Private Sub DeleteSchoolgroupAssignment(instance As SchoolgroupAssignment)
    End Sub
  Partial Private Sub InsertSchoolgroupAssignmentType(instance As SchoolgroupAssignmentType)
    End Sub
  Partial Private Sub UpdateSchoolgroupAssignmentType(instance As SchoolgroupAssignmentType)
    End Sub
  Partial Private Sub DeleteSchoolgroupAssignmentType(instance As SchoolgroupAssignmentType)
    End Sub
  Partial Private Sub InsertAnalysisPeople(instance As AnalysisPeople)
    End Sub
  Partial Private Sub UpdateAnalysisPeople(instance As AnalysisPeople)
    End Sub
  Partial Private Sub DeleteAnalysisPeople(instance As AnalysisPeople)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.AscensionAnalytics.My.MySettings.Default.DavidConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property SchoolgroupAssignments() As System.Data.Linq.Table(Of SchoolgroupAssignment)
		Get
			Return Me.GetTable(Of SchoolgroupAssignment)
		End Get
	End Property
	
	Public ReadOnly Property SchoolgroupAssignmentTypes() As System.Data.Linq.Table(Of SchoolgroupAssignmentType)
		Get
			Return Me.GetTable(Of SchoolgroupAssignmentType)
		End Get
	End Property
	
	Public ReadOnly Property SchoolgroupAssignmentSchoolgroups() As System.Data.Linq.Table(Of SchoolgroupAssignmentSchoolgroup)
		Get
			Return Me.GetTable(Of SchoolgroupAssignmentSchoolgroup)
		End Get
	End Property
	
	Public ReadOnly Property AnalysisPeoples() As System.Data.Linq.Table(Of AnalysisPeople)
		Get
			Return Me.GetTable(Of AnalysisPeople)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.SchoolgroupAssignments")>  _
Partial Public Class SchoolgroupAssignment
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _SchoolgroupAssignmentId As Integer
	
	Private _Schoolgroup_cd As String
	
	Private _SchoolgroupAssignmentTypeId As Integer
	
	Private _AnalysisPersonId As Integer
	
	Private _SchoolgroupAssignmentType As EntityRef(Of SchoolgroupAssignmentType)
	
	Private _AnalysisPeople As EntityRef(Of AnalysisPeople)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentIdChanged()
    End Sub
    Partial Private Sub OnSchoolgroup_cdChanging(value As String)
    End Sub
    Partial Private Sub OnSchoolgroup_cdChanged()
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentTypeIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentTypeIdChanged()
    End Sub
    Partial Private Sub OnAnalysisPersonIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnAnalysisPersonIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._SchoolgroupAssignmentType = CType(Nothing, EntityRef(Of SchoolgroupAssignmentType))
		Me._AnalysisPeople = CType(Nothing, EntityRef(Of AnalysisPeople))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SchoolgroupAssignmentId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property SchoolgroupAssignmentId() As Integer
		Get
			Return Me._SchoolgroupAssignmentId
		End Get
		Set
			If ((Me._SchoolgroupAssignmentId = value)  _
						= false) Then
				Me.OnSchoolgroupAssignmentIdChanging(value)
				Me.SendPropertyChanging
				Me._SchoolgroupAssignmentId = value
				Me.SendPropertyChanged("SchoolgroupAssignmentId")
				Me.OnSchoolgroupAssignmentIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Schoolgroup_cd", DbType:="Char(10) NOT NULL", CanBeNull:=false)>  _
	Public Property Schoolgroup_cd() As String
		Get
			Return Me._Schoolgroup_cd
		End Get
		Set
			If (String.Equals(Me._Schoolgroup_cd, value) = false) Then
				Me.OnSchoolgroup_cdChanging(value)
				Me.SendPropertyChanging
				Me._Schoolgroup_cd = value
				Me.SendPropertyChanged("Schoolgroup_cd")
				Me.OnSchoolgroup_cdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SchoolgroupAssignmentTypeId", DbType:="Int NOT NULL")>  _
	Public Property SchoolgroupAssignmentTypeId() As Integer
		Get
			Return Me._SchoolgroupAssignmentTypeId
		End Get
		Set
			If ((Me._SchoolgroupAssignmentTypeId = value)  _
						= false) Then
				If Me._SchoolgroupAssignmentType.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnSchoolgroupAssignmentTypeIdChanging(value)
				Me.SendPropertyChanging
				Me._SchoolgroupAssignmentTypeId = value
				Me.SendPropertyChanged("SchoolgroupAssignmentTypeId")
				Me.OnSchoolgroupAssignmentTypeIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AnalysisPersonId", DbType:="Int NOT NULL")>  _
	Public Property AnalysisPersonId() As Integer
		Get
			Return Me._AnalysisPersonId
		End Get
		Set
			If ((Me._AnalysisPersonId = value)  _
						= false) Then
				If Me._AnalysisPeople.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnAnalysisPersonIdChanging(value)
				Me.SendPropertyChanging
				Me._AnalysisPersonId = value
				Me.SendPropertyChanged("AnalysisPersonId")
				Me.OnAnalysisPersonIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="SchoolgroupAssignmentType_SchoolgroupAssignment", Storage:="_SchoolgroupAssignmentType", ThisKey:="SchoolgroupAssignmentTypeId", OtherKey:="SchoolgroupAssignmentTypeId", IsForeignKey:=true)>  _
	Public Property SchoolgroupAssignmentType() As SchoolgroupAssignmentType
		Get
			Return Me._SchoolgroupAssignmentType.Entity
		End Get
		Set
			Dim previousValue As SchoolgroupAssignmentType = Me._SchoolgroupAssignmentType.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._SchoolgroupAssignmentType.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._SchoolgroupAssignmentType.Entity = Nothing
					previousValue.SchoolgroupAssignments.Remove(Me)
				End If
				Me._SchoolgroupAssignmentType.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.SchoolgroupAssignments.Add(Me)
					Me._SchoolgroupAssignmentTypeId = value.SchoolgroupAssignmentTypeId
				Else
					Me._SchoolgroupAssignmentTypeId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("SchoolgroupAssignmentType")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="AnalysisPeople_SchoolgroupAssignment", Storage:="_AnalysisPeople", ThisKey:="AnalysisPersonId", OtherKey:="PersonId", IsForeignKey:=true)>  _
	Public Property AnalysisPeople() As AnalysisPeople
		Get
			Return Me._AnalysisPeople.Entity
		End Get
		Set
			Dim previousValue As AnalysisPeople = Me._AnalysisPeople.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._AnalysisPeople.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._AnalysisPeople.Entity = Nothing
					previousValue.SchoolgroupAssignments.Remove(Me)
				End If
				Me._AnalysisPeople.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.SchoolgroupAssignments.Add(Me)
					Me._AnalysisPersonId = value.PersonId
				Else
					Me._AnalysisPersonId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("AnalysisPeople")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.SchoolgroupAssignmentTypes")>  _
Partial Public Class SchoolgroupAssignmentType
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _SchoolgroupAssignmentTypeId As Integer
	
	Private _SchoolgroupAssignmentType As String
	
	Private _SchoolgroupAssignments As EntitySet(Of SchoolgroupAssignment)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentTypeIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentTypeIdChanged()
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentTypeChanging(value As String)
    End Sub
    Partial Private Sub OnSchoolgroupAssignmentTypeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._SchoolgroupAssignments = New EntitySet(Of SchoolgroupAssignment)(AddressOf Me.attach_SchoolgroupAssignments, AddressOf Me.detach_SchoolgroupAssignments)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SchoolgroupAssignmentTypeId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property SchoolgroupAssignmentTypeId() As Integer
		Get
			Return Me._SchoolgroupAssignmentTypeId
		End Get
		Set
			If ((Me._SchoolgroupAssignmentTypeId = value)  _
						= false) Then
				Me.OnSchoolgroupAssignmentTypeIdChanging(value)
				Me.SendPropertyChanging
				Me._SchoolgroupAssignmentTypeId = value
				Me.SendPropertyChanged("SchoolgroupAssignmentTypeId")
				Me.OnSchoolgroupAssignmentTypeIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SchoolgroupAssignmentType", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SchoolgroupAssignmentType() As String
		Get
			Return Me._SchoolgroupAssignmentType
		End Get
		Set
			If (String.Equals(Me._SchoolgroupAssignmentType, value) = false) Then
				Me.OnSchoolgroupAssignmentTypeChanging(value)
				Me.SendPropertyChanging
				Me._SchoolgroupAssignmentType = value
				Me.SendPropertyChanged("SchoolgroupAssignmentType")
				Me.OnSchoolgroupAssignmentTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="SchoolgroupAssignmentType_SchoolgroupAssignment", Storage:="_SchoolgroupAssignments", ThisKey:="SchoolgroupAssignmentTypeId", OtherKey:="SchoolgroupAssignmentTypeId")>  _
	Public Property SchoolgroupAssignments() As EntitySet(Of SchoolgroupAssignment)
		Get
			Return Me._SchoolgroupAssignments
		End Get
		Set
			Me._SchoolgroupAssignments.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_SchoolgroupAssignments(ByVal entity As SchoolgroupAssignment)
		Me.SendPropertyChanging
		entity.SchoolgroupAssignmentType = Me
	End Sub
	
	Private Sub detach_SchoolgroupAssignments(ByVal entity As SchoolgroupAssignment)
		Me.SendPropertyChanging
		entity.SchoolgroupAssignmentType = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.schoolgroups")>  _
Partial Public Class SchoolgroupAssignmentSchoolgroup
	
	Private _prem_schoolid As Integer
	
	Private _school_nm As String
	
	Private _prem_schoolgroupid As Integer
	
	Private _claims_schoolgroupid As Short
	
	Private _schoolgroup_cd As String
	
	Private _schoolgroup_nm As String
	
	Private _schoolgroup As String
	
	Private _isConsortium As Byte
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prem_schoolid", DbType:="Int NOT NULL")>  _
	Public Property prem_schoolid() As Integer
		Get
			Return Me._prem_schoolid
		End Get
		Set
			If ((Me._prem_schoolid = value)  _
						= false) Then
				Me._prem_schoolid = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_school_nm", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property school_nm() As String
		Get
			Return Me._school_nm
		End Get
		Set
			If (String.Equals(Me._school_nm, value) = false) Then
				Me._school_nm = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_prem_schoolgroupid", DbType:="Int NOT NULL")>  _
	Public Property prem_schoolgroupid() As Integer
		Get
			Return Me._prem_schoolgroupid
		End Get
		Set
			If ((Me._prem_schoolgroupid = value)  _
						= false) Then
				Me._prem_schoolgroupid = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_claims_schoolgroupid", DbType:="SmallInt NOT NULL")>  _
	Public Property claims_schoolgroupid() As Short
		Get
			Return Me._claims_schoolgroupid
		End Get
		Set
			If ((Me._claims_schoolgroupid = value)  _
						= false) Then
				Me._claims_schoolgroupid = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_schoolgroup_cd", DbType:="Char(10) NOT NULL", CanBeNull:=false)>  _
	Public Property schoolgroup_cd() As String
		Get
			Return Me._schoolgroup_cd
		End Get
		Set
			If (String.Equals(Me._schoolgroup_cd, value) = false) Then
				Me._schoolgroup_cd = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_schoolgroup_nm", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property schoolgroup_nm() As String
		Get
			Return Me._schoolgroup_nm
		End Get
		Set
			If (String.Equals(Me._schoolgroup_nm, value) = false) Then
				Me._schoolgroup_nm = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_schoolgroup", DbType:="VarChar(63)")>  _
	Public Property schoolgroup() As String
		Get
			Return Me._schoolgroup
		End Get
		Set
			If (String.Equals(Me._schoolgroup, value) = false) Then
				Me._schoolgroup = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_isConsortium", DbType:="TinyInt NOT NULL")>  _
	Public Property isConsortium() As Byte
		Get
			Return Me._isConsortium
		End Get
		Set
			If ((Me._isConsortium = value)  _
						= false) Then
				Me._isConsortium = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AnalysisPeople")>  _
Partial Public Class AnalysisPeople
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _PersonId As Integer
	
	Private _Name As String
	
	Private _Phone As String
	
	Private _Note As String
	
	Private _Email As String
	
	Private _IsActive As Byte
	
	Private _SchoolgroupAssignments As EntitySet(Of SchoolgroupAssignment)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnPersonIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnPersonIdChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnNoteChanging(value As String)
    End Sub
    Partial Private Sub OnNoteChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnIsActiveChanging(value As Byte)
    End Sub
    Partial Private Sub OnIsActiveChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._SchoolgroupAssignments = New EntitySet(Of SchoolgroupAssignment)(AddressOf Me.attach_SchoolgroupAssignments, AddressOf Me.detach_SchoolgroupAssignments)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PersonId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property PersonId() As Integer
		Get
			Return Me._PersonId
		End Get
		Set
			If ((Me._PersonId = value)  _
						= false) Then
				Me.OnPersonIdChanging(value)
				Me.SendPropertyChanging
				Me._PersonId = value
				Me.SendPropertyChanged("PersonId")
				Me.OnPersonIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Note", DbType:="VarChar(2000) NOT NULL", CanBeNull:=false)>  _
	Public Property Note() As String
		Get
			Return Me._Note
		End Get
		Set
			If (String.Equals(Me._Note, value) = false) Then
				Me.OnNoteChanging(value)
				Me.SendPropertyChanging
				Me._Note = value
				Me.SendPropertyChanged("Note")
				Me.OnNoteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="VarChar(250) NOT NULL", CanBeNull:=false)>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsActive", DbType:="TinyInt NOT NULL")>  _
	Public Property IsActive() As Byte
		Get
			Return Me._IsActive
		End Get
		Set
			If ((Me._IsActive = value)  _
						= false) Then
				Me.OnIsActiveChanging(value)
				Me.SendPropertyChanging
				Me._IsActive = value
				Me.SendPropertyChanged("IsActive")
				Me.OnIsActiveChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="AnalysisPeople_SchoolgroupAssignment", Storage:="_SchoolgroupAssignments", ThisKey:="PersonId", OtherKey:="AnalysisPersonId")>  _
	Public Property SchoolgroupAssignments() As EntitySet(Of SchoolgroupAssignment)
		Get
			Return Me._SchoolgroupAssignments
		End Get
		Set
			Me._SchoolgroupAssignments.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_SchoolgroupAssignments(ByVal entity As SchoolgroupAssignment)
		Me.SendPropertyChanging
		entity.AnalysisPeople = Me
	End Sub
	
	Private Sub detach_SchoolgroupAssignments(ByVal entity As SchoolgroupAssignment)
		Me.SendPropertyChanging
		entity.AnalysisPeople = Nothing
	End Sub
End Class
