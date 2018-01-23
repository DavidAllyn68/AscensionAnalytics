﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
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
Partial Public Class ThingsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertThing(instance As Thing)
    End Sub
  Partial Private Sub UpdateThing(instance As Thing)
    End Sub
  Partial Private Sub DeleteThing(instance As Thing)
    End Sub
  Partial Private Sub InsertThingAssociation(instance As ThingAssociation)
    End Sub
  Partial Private Sub UpdateThingAssociation(instance As ThingAssociation)
    End Sub
  Partial Private Sub DeleteThingAssociation(instance As ThingAssociation)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.ThingManager.My.MySettings.Default.DavidConnectionString, mappingSource)
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
	
	Public ReadOnly Property Things() As System.Data.Linq.Table(Of Thing)
		Get
			Return Me.GetTable(Of Thing)
		End Get
	End Property
	
	Public ReadOnly Property ThingAssociations() As System.Data.Linq.Table(Of ThingAssociation)
		Get
			Return Me.GetTable(Of ThingAssociation)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Things")>  _
Partial Public Class Thing
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ThingId As Integer
	
	Private _Title As String
	
	Private _Memo As String
	
	Private _ThingAssociations As EntitySet(Of ThingAssociation)
	
	Private _ThingAssociations1 As EntitySet(Of ThingAssociation)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnThingIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnThingIdChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnMemoChanging(value As String)
    End Sub
    Partial Private Sub OnMemoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._ThingAssociations = New EntitySet(Of ThingAssociation)(AddressOf Me.attach_ThingAssociations, AddressOf Me.detach_ThingAssociations)
		Me._ThingAssociations1 = New EntitySet(Of ThingAssociation)(AddressOf Me.attach_ThingAssociations1, AddressOf Me.detach_ThingAssociations1)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ThingId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ThingId() As Integer
		Get
			Return Me._ThingId
		End Get
		Set
			If ((Me._ThingId = value)  _
						= false) Then
				Me.OnThingIdChanging(value)
				Me.SendPropertyChanging
				Me._ThingId = value
				Me.SendPropertyChanged("ThingId")
				Me.OnThingIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If (String.Equals(Me._Title, value) = false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Memo", DbType:="VarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property Memo() As String
		Get
			Return Me._Memo
		End Get
		Set
			If (String.Equals(Me._Memo, value) = false) Then
				Me.OnMemoChanging(value)
				Me.SendPropertyChanging
				Me._Memo = value
				Me.SendPropertyChanged("Memo")
				Me.OnMemoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Thing_ThingAssociation", Storage:="_ThingAssociations", ThisKey:="ThingId", OtherKey:="ParentThingId")>  _
	Public Property ThingAssociations() As EntitySet(Of ThingAssociation)
		Get
			Return Me._ThingAssociations
		End Get
		Set
			Me._ThingAssociations.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Thing_ThingAssociation1", Storage:="_ThingAssociations1", ThisKey:="ThingId", OtherKey:="ChildThingId")>  _
	Public Property ThingAssociations1() As EntitySet(Of ThingAssociation)
		Get
			Return Me._ThingAssociations1
		End Get
		Set
			Me._ThingAssociations1.Assign(value)
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
	
	Private Sub attach_ThingAssociations(ByVal entity As ThingAssociation)
		Me.SendPropertyChanging
		entity.Thing = Me
	End Sub
	
	Private Sub detach_ThingAssociations(ByVal entity As ThingAssociation)
		Me.SendPropertyChanging
		entity.Thing = Nothing
	End Sub
	
	Private Sub attach_ThingAssociations1(ByVal entity As ThingAssociation)
		Me.SendPropertyChanging
		entity.Thing1 = Me
	End Sub
	
	Private Sub detach_ThingAssociations1(ByVal entity As ThingAssociation)
		Me.SendPropertyChanging
		entity.Thing1 = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ThingAssociations")>  _
Partial Public Class ThingAssociation
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ThingAssociationId As Integer
	
	Private _ParentThingId As Integer
	
	Private _ChildThingId As Integer
	
	Private _Thing As EntityRef(Of Thing)
	
	Private _Thing1 As EntityRef(Of Thing)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnThingAssociationIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnThingAssociationIdChanged()
    End Sub
    Partial Private Sub OnParentThingIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnParentThingIdChanged()
    End Sub
    Partial Private Sub OnChildThingIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnChildThingIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Thing = CType(Nothing, EntityRef(Of Thing))
		Me._Thing1 = CType(Nothing, EntityRef(Of Thing))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ThingAssociationId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ThingAssociationId() As Integer
		Get
			Return Me._ThingAssociationId
		End Get
		Set
			If ((Me._ThingAssociationId = value)  _
						= false) Then
				Me.OnThingAssociationIdChanging(value)
				Me.SendPropertyChanging
				Me._ThingAssociationId = value
				Me.SendPropertyChanged("ThingAssociationId")
				Me.OnThingAssociationIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ParentThingId", DbType:="Int NOT NULL")>  _
	Public Property ParentThingId() As Integer
		Get
			Return Me._ParentThingId
		End Get
		Set
			If ((Me._ParentThingId = value)  _
						= false) Then
				If Me._Thing.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnParentThingIdChanging(value)
				Me.SendPropertyChanging
				Me._ParentThingId = value
				Me.SendPropertyChanged("ParentThingId")
				Me.OnParentThingIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ChildThingId", DbType:="Int NOT NULL")>  _
	Public Property ChildThingId() As Integer
		Get
			Return Me._ChildThingId
		End Get
		Set
			If ((Me._ChildThingId = value)  _
						= false) Then
				If Me._Thing1.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnChildThingIdChanging(value)
				Me.SendPropertyChanging
				Me._ChildThingId = value
				Me.SendPropertyChanged("ChildThingId")
				Me.OnChildThingIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Thing_ThingAssociation", Storage:="_Thing", ThisKey:="ParentThingId", OtherKey:="ThingId", IsForeignKey:=true)>  _
	Public Property Thing() As Thing
		Get
			Return Me._Thing.Entity
		End Get
		Set
			Dim previousValue As Thing = Me._Thing.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Thing.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Thing.Entity = Nothing
					previousValue.ThingAssociations.Remove(Me)
				End If
				Me._Thing.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.ThingAssociations.Add(Me)
					Me._ParentThingId = value.ThingId
				Else
					Me._ParentThingId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Thing")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Thing_ThingAssociation1", Storage:="_Thing1", ThisKey:="ChildThingId", OtherKey:="ThingId", IsForeignKey:=true)>  _
	Public Property Thing1() As Thing
		Get
			Return Me._Thing1.Entity
		End Get
		Set
			Dim previousValue As Thing = Me._Thing1.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Thing1.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Thing1.Entity = Nothing
					previousValue.ThingAssociations1.Remove(Me)
				End If
				Me._Thing1.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.ThingAssociations1.Add(Me)
					Me._ChildThingId = value.ThingId
				Else
					Me._ChildThingId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Thing1")
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
