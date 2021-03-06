﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
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


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="David")>  _
Partial Public Class OverlandParkTrizzetoBenefitMappingDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertOverlandParkTrizzetoMapping_AscensionBenefit(instance As OverlandParkTrizzetoMapping_AscensionBenefit)
    End Sub
  Partial Private Sub UpdateOverlandParkTrizzetoMapping_AscensionBenefit(instance As OverlandParkTrizzetoMapping_AscensionBenefit)
    End Sub
  Partial Private Sub DeleteOverlandParkTrizzetoMapping_AscensionBenefit(instance As OverlandParkTrizzetoMapping_AscensionBenefit)
    End Sub
  Partial Private Sub InsertOverlandParkTrizzeto_BenefitMapping(instance As OverlandParkTrizzeto_BenefitMapping)
    End Sub
  Partial Private Sub UpdateOverlandParkTrizzeto_BenefitMapping(instance As OverlandParkTrizzeto_BenefitMapping)
    End Sub
  Partial Private Sub DeleteOverlandParkTrizzeto_BenefitMapping(instance As OverlandParkTrizzeto_BenefitMapping)
    End Sub
  Partial Private Sub InsertOverlandParkTrizzeto_PlaceOfService(instance As OverlandParkTrizzeto_PlaceOfService)
    End Sub
  Partial Private Sub UpdateOverlandParkTrizzeto_PlaceOfService(instance As OverlandParkTrizzeto_PlaceOfService)
    End Sub
  Partial Private Sub DeleteOverlandParkTrizzeto_PlaceOfService(instance As OverlandParkTrizzeto_PlaceOfService)
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
	
	Public ReadOnly Property OverlandParkTrizzetoMapping_AscensionBenefits() As System.Data.Linq.Table(Of OverlandParkTrizzetoMapping_AscensionBenefit)
		Get
			Return Me.GetTable(Of OverlandParkTrizzetoMapping_AscensionBenefit)
		End Get
	End Property
	
	Public ReadOnly Property OverlandParkTrizzeto_BenefitMappings() As System.Data.Linq.Table(Of OverlandParkTrizzeto_BenefitMapping)
		Get
			Return Me.GetTable(Of OverlandParkTrizzeto_BenefitMapping)
		End Get
	End Property
	
	Public ReadOnly Property OverlandParkTrizzeto_PlaceOfServices() As System.Data.Linq.Table(Of OverlandParkTrizzeto_PlaceOfService)
		Get
			Return Me.GetTable(Of OverlandParkTrizzeto_PlaceOfService)
		End Get
	End Property
End Class

<Table(Name:="dbo.Benefits")>  _
Partial Public Class OverlandParkTrizzetoMapping_AscensionBenefit
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _BenefitId As Integer
	
	Private _BenefitCode As String
	
	Private _BenefitDescription As String
	
	Private _IsRxBenefit As Byte
	
	Private _IsMentalHealthBenefit As Byte
	
	Private _IsInpatientBenefit As Byte
	
	Private _IsOfficeVisitBenefit As Byte
	
	Private _IsEmergencyRoomBenefit As Byte
	
	Private _OverlandParkTrizzeto_BenefitMappings As EntitySet(Of OverlandParkTrizzeto_BenefitMapping)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnBenefitIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnBenefitIdChanged()
    End Sub
    Partial Private Sub OnBenefitCodeChanging(value As String)
    End Sub
    Partial Private Sub OnBenefitCodeChanged()
    End Sub
    Partial Private Sub OnBenefitDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnBenefitDescriptionChanged()
    End Sub
    Partial Private Sub OnIsRxBenefitChanging(value As Byte)
    End Sub
    Partial Private Sub OnIsRxBenefitChanged()
    End Sub
    Partial Private Sub OnIsMentalHealthBenefitChanging(value As Byte)
    End Sub
    Partial Private Sub OnIsMentalHealthBenefitChanged()
    End Sub
    Partial Private Sub OnIsInpatientBenefitChanging(value As Byte)
    End Sub
    Partial Private Sub OnIsInpatientBenefitChanged()
    End Sub
    Partial Private Sub OnIsOfficeVisitBenefitChanging(value As Byte)
    End Sub
    Partial Private Sub OnIsOfficeVisitBenefitChanged()
    End Sub
    Partial Private Sub OnIsEmergencyRoomBenefitChanging(value As Byte)
    End Sub
    Partial Private Sub OnIsEmergencyRoomBenefitChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._OverlandParkTrizzeto_BenefitMappings = New EntitySet(Of OverlandParkTrizzeto_BenefitMapping)(AddressOf Me.attach_OverlandParkTrizzeto_BenefitMappings, AddressOf Me.detach_OverlandParkTrizzeto_BenefitMappings)
		OnCreated
	End Sub
	
	<Column(Storage:="_BenefitId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property BenefitId() As Integer
		Get
			Return Me._BenefitId
		End Get
		Set
			If ((Me._BenefitId = value)  _
						= false) Then
				Me.OnBenefitIdChanging(value)
				Me.SendPropertyChanging
				Me._BenefitId = value
				Me.SendPropertyChanged("BenefitId")
				Me.OnBenefitIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_BenefitCode", DbType:="VarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property BenefitCode() As String
		Get
			Return Me._BenefitCode
		End Get
		Set
			If (String.Equals(Me._BenefitCode, value) = false) Then
				Me.OnBenefitCodeChanging(value)
				Me.SendPropertyChanging
				Me._BenefitCode = value
				Me.SendPropertyChanged("BenefitCode")
				Me.OnBenefitCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_BenefitDescription", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property BenefitDescription() As String
		Get
			Return Me._BenefitDescription
		End Get
		Set
			If (String.Equals(Me._BenefitDescription, value) = false) Then
				Me.OnBenefitDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._BenefitDescription = value
				Me.SendPropertyChanged("BenefitDescription")
				Me.OnBenefitDescriptionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_IsRxBenefit", DbType:="TinyInt NOT NULL")>  _
	Public Property IsRxBenefit() As Byte
		Get
			Return Me._IsRxBenefit
		End Get
		Set
			If ((Me._IsRxBenefit = value)  _
						= false) Then
				Me.OnIsRxBenefitChanging(value)
				Me.SendPropertyChanging
				Me._IsRxBenefit = value
				Me.SendPropertyChanged("IsRxBenefit")
				Me.OnIsRxBenefitChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_IsMentalHealthBenefit", DbType:="TinyInt NOT NULL")>  _
	Public Property IsMentalHealthBenefit() As Byte
		Get
			Return Me._IsMentalHealthBenefit
		End Get
		Set
			If ((Me._IsMentalHealthBenefit = value)  _
						= false) Then
				Me.OnIsMentalHealthBenefitChanging(value)
				Me.SendPropertyChanging
				Me._IsMentalHealthBenefit = value
				Me.SendPropertyChanged("IsMentalHealthBenefit")
				Me.OnIsMentalHealthBenefitChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_IsInpatientBenefit", DbType:="TinyInt NOT NULL")>  _
	Public Property IsInpatientBenefit() As Byte
		Get
			Return Me._IsInpatientBenefit
		End Get
		Set
			If ((Me._IsInpatientBenefit = value)  _
						= false) Then
				Me.OnIsInpatientBenefitChanging(value)
				Me.SendPropertyChanging
				Me._IsInpatientBenefit = value
				Me.SendPropertyChanged("IsInpatientBenefit")
				Me.OnIsInpatientBenefitChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_IsOfficeVisitBenefit", DbType:="TinyInt NOT NULL")>  _
	Public Property IsOfficeVisitBenefit() As Byte
		Get
			Return Me._IsOfficeVisitBenefit
		End Get
		Set
			If ((Me._IsOfficeVisitBenefit = value)  _
						= false) Then
				Me.OnIsOfficeVisitBenefitChanging(value)
				Me.SendPropertyChanging
				Me._IsOfficeVisitBenefit = value
				Me.SendPropertyChanged("IsOfficeVisitBenefit")
				Me.OnIsOfficeVisitBenefitChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_IsEmergencyRoomBenefit", DbType:="TinyInt NOT NULL")>  _
	Public Property IsEmergencyRoomBenefit() As Byte
		Get
			Return Me._IsEmergencyRoomBenefit
		End Get
		Set
			If ((Me._IsEmergencyRoomBenefit = value)  _
						= false) Then
				Me.OnIsEmergencyRoomBenefitChanging(value)
				Me.SendPropertyChanging
				Me._IsEmergencyRoomBenefit = value
				Me.SendPropertyChanged("IsEmergencyRoomBenefit")
				Me.OnIsEmergencyRoomBenefitChanged
			End If
		End Set
	End Property
	
	<Association(Name:="OverlandParkTrizzetoMapping_AscensionBenefit_OverlandParkTrizzeto_BenefitMapping", Storage:="_OverlandParkTrizzeto_BenefitMappings", ThisKey:="BenefitId", OtherKey:="AscensionBenefitId")>  _
	Public Property OverlandParkTrizzeto_BenefitMappings() As EntitySet(Of OverlandParkTrizzeto_BenefitMapping)
		Get
			Return Me._OverlandParkTrizzeto_BenefitMappings
		End Get
		Set
			Me._OverlandParkTrizzeto_BenefitMappings.Assign(value)
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
	
	Private Sub attach_OverlandParkTrizzeto_BenefitMappings(ByVal entity As OverlandParkTrizzeto_BenefitMapping)
		Me.SendPropertyChanging
		entity.OverlandParkTrizzetoMapping_AscensionBenefit = Me
	End Sub
	
	Private Sub detach_OverlandParkTrizzeto_BenefitMappings(ByVal entity As OverlandParkTrizzeto_BenefitMapping)
		Me.SendPropertyChanging
		entity.OverlandParkTrizzetoMapping_AscensionBenefit = Nothing
	End Sub
End Class

<Table(Name:="dbo.OverlandParkTrizzeto_BenefitMapping")>  _
Partial Public Class OverlandParkTrizzeto_BenefitMapping
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OverlandParkTrizzetoBenefitMappingId As Integer
	
	Private _OverlandParkTrizzetoBenefitCode As String
	
	Private _OverlandParkTrizzetoBenefitDescription As String
	
	Private _OverlandParkTrizzetoPlaceOfService As Integer
	
	Private _AscensionBenefitId As Integer
	
	Private _OverlandParkTrizzetoMapping_AscensionBenefit As EntityRef(Of OverlandParkTrizzetoMapping_AscensionBenefit)
	
	Private _OverlandParkTrizzeto_PlaceOfService As EntityRef(Of OverlandParkTrizzeto_PlaceOfService)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoBenefitMappingIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoBenefitMappingIdChanged()
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoBenefitCodeChanging(value As String)
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoBenefitCodeChanged()
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoBenefitDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoBenefitDescriptionChanged()
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoPlaceOfServiceChanging(value As Integer)
    End Sub
    Partial Private Sub OnOverlandParkTrizzetoPlaceOfServiceChanged()
    End Sub
    Partial Private Sub OnAscensionBenefitIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnAscensionBenefitIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._OverlandParkTrizzetoMapping_AscensionBenefit = CType(Nothing, EntityRef(Of OverlandParkTrizzetoMapping_AscensionBenefit))
		Me._OverlandParkTrizzeto_PlaceOfService = CType(Nothing, EntityRef(Of OverlandParkTrizzeto_PlaceOfService))
		OnCreated
	End Sub
	
	<Column(Storage:="_OverlandParkTrizzetoBenefitMappingId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property OverlandParkTrizzetoBenefitMappingId() As Integer
		Get
			Return Me._OverlandParkTrizzetoBenefitMappingId
		End Get
		Set
			If ((Me._OverlandParkTrizzetoBenefitMappingId = value)  _
						= false) Then
				Me.OnOverlandParkTrizzetoBenefitMappingIdChanging(value)
				Me.SendPropertyChanging
				Me._OverlandParkTrizzetoBenefitMappingId = value
				Me.SendPropertyChanged("OverlandParkTrizzetoBenefitMappingId")
				Me.OnOverlandParkTrizzetoBenefitMappingIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_OverlandParkTrizzetoBenefitCode", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property OverlandParkTrizzetoBenefitCode() As String
		Get
			Return Me._OverlandParkTrizzetoBenefitCode
		End Get
		Set
			If (String.Equals(Me._OverlandParkTrizzetoBenefitCode, value) = false) Then
				Me.OnOverlandParkTrizzetoBenefitCodeChanging(value)
				Me.SendPropertyChanging
				Me._OverlandParkTrizzetoBenefitCode = value
				Me.SendPropertyChanged("OverlandParkTrizzetoBenefitCode")
				Me.OnOverlandParkTrizzetoBenefitCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_OverlandParkTrizzetoBenefitDescription", DbType:="VarChar(200) NOT NULL", CanBeNull:=false)>  _
	Public Property OverlandParkTrizzetoBenefitDescription() As String
		Get
			Return Me._OverlandParkTrizzetoBenefitDescription
		End Get
		Set
			If (String.Equals(Me._OverlandParkTrizzetoBenefitDescription, value) = false) Then
				Me.OnOverlandParkTrizzetoBenefitDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._OverlandParkTrizzetoBenefitDescription = value
				Me.SendPropertyChanged("OverlandParkTrizzetoBenefitDescription")
				Me.OnOverlandParkTrizzetoBenefitDescriptionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_OverlandParkTrizzetoPlaceOfService", DbType:="Int NOT NULL")>  _
	Public Property OverlandParkTrizzetoPlaceOfService() As Integer
		Get
			Return Me._OverlandParkTrizzetoPlaceOfService
		End Get
		Set
			If ((Me._OverlandParkTrizzetoPlaceOfService = value)  _
						= false) Then
				If Me._OverlandParkTrizzeto_PlaceOfService.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnOverlandParkTrizzetoPlaceOfServiceChanging(value)
				Me.SendPropertyChanging
				Me._OverlandParkTrizzetoPlaceOfService = value
				Me.SendPropertyChanged("OverlandParkTrizzetoPlaceOfService")
				Me.OnOverlandParkTrizzetoPlaceOfServiceChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_AscensionBenefitId", DbType:="Int NOT NULL")>  _
	Public Property AscensionBenefitId() As Integer
		Get
			Return Me._AscensionBenefitId
		End Get
		Set
			If ((Me._AscensionBenefitId = value)  _
						= false) Then
				If Me._OverlandParkTrizzetoMapping_AscensionBenefit.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnAscensionBenefitIdChanging(value)
				Me.SendPropertyChanging
				Me._AscensionBenefitId = value
				Me.SendPropertyChanged("AscensionBenefitId")
				Me.OnAscensionBenefitIdChanged
			End If
		End Set
	End Property
	
	<Association(Name:="OverlandParkTrizzetoMapping_AscensionBenefit_OverlandParkTrizzeto_BenefitMapping", Storage:="_OverlandParkTrizzetoMapping_AscensionBenefit", ThisKey:="AscensionBenefitId", OtherKey:="BenefitId", IsForeignKey:=true)>  _
	Public Property OverlandParkTrizzetoMapping_AscensionBenefit() As OverlandParkTrizzetoMapping_AscensionBenefit
		Get
			Return Me._OverlandParkTrizzetoMapping_AscensionBenefit.Entity
		End Get
		Set
			Dim previousValue As OverlandParkTrizzetoMapping_AscensionBenefit = Me._OverlandParkTrizzetoMapping_AscensionBenefit.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._OverlandParkTrizzetoMapping_AscensionBenefit.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._OverlandParkTrizzetoMapping_AscensionBenefit.Entity = Nothing
					previousValue.OverlandParkTrizzeto_BenefitMappings.Remove(Me)
				End If
				Me._OverlandParkTrizzetoMapping_AscensionBenefit.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.OverlandParkTrizzeto_BenefitMappings.Add(Me)
					Me._AscensionBenefitId = value.BenefitId
				Else
					Me._AscensionBenefitId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("OverlandParkTrizzetoMapping_AscensionBenefit")
			End If
		End Set
	End Property
	
	<Association(Name:="OverlandParkTrizzetoPlaceOfService_OverlandParkTrizzeto_BenefitMapping", Storage:="_OverlandParkTrizzeto_PlaceOfService", ThisKey:="OverlandParkTrizzetoPlaceOfService", OtherKey:="PlaceOfServiceCode", IsForeignKey:=true)>  _
	Public Property OverlandParkTrizzeto_PlaceOfService() As OverlandParkTrizzeto_PlaceOfService
		Get
			Return Me._OverlandParkTrizzeto_PlaceOfService.Entity
		End Get
		Set
			Dim previousValue As OverlandParkTrizzeto_PlaceOfService = Me._OverlandParkTrizzeto_PlaceOfService.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._OverlandParkTrizzeto_PlaceOfService.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._OverlandParkTrizzeto_PlaceOfService.Entity = Nothing
					previousValue.OverlandParkTrizzeto_BenefitMappings.Remove(Me)
				End If
				Me._OverlandParkTrizzeto_PlaceOfService.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.OverlandParkTrizzeto_BenefitMappings.Add(Me)
					Me._OverlandParkTrizzetoPlaceOfService = value.PlaceOfServiceCode
				Else
					Me._OverlandParkTrizzetoPlaceOfService = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("OverlandParkTrizzeto_PlaceOfService")
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

<Table(Name:="dbo.PlaceOfService")>  _
Partial Public Class OverlandParkTrizzeto_PlaceOfService
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _PlaceOfServiceCode As Integer
	
	Private _PlaceOfServiceName As String
	
	Private _PlaceOfServiceDescription As String
	
	Private _PlaceOfServiceCategoryId As System.Nullable(Of Integer)
	
	Private _OverlandParkTrizzeto_BenefitMappings As EntitySet(Of OverlandParkTrizzeto_BenefitMapping)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnPlaceOfServiceCodeChanging(value As Integer)
    End Sub
    Partial Private Sub OnPlaceOfServiceCodeChanged()
    End Sub
    Partial Private Sub OnPlaceOfServiceNameChanging(value As String)
    End Sub
    Partial Private Sub OnPlaceOfServiceNameChanged()
    End Sub
    Partial Private Sub OnPlaceOfServiceDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnPlaceOfServiceDescriptionChanged()
    End Sub
    Partial Private Sub OnPlaceOfServiceCategoryIdChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnPlaceOfServiceCategoryIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._OverlandParkTrizzeto_BenefitMappings = New EntitySet(Of OverlandParkTrizzeto_BenefitMapping)(AddressOf Me.attach_OverlandParkTrizzeto_BenefitMappings, AddressOf Me.detach_OverlandParkTrizzeto_BenefitMappings)
		OnCreated
	End Sub
	
	<Column(Storage:="_PlaceOfServiceCode", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property PlaceOfServiceCode() As Integer
		Get
			Return Me._PlaceOfServiceCode
		End Get
		Set
			If ((Me._PlaceOfServiceCode = value)  _
						= false) Then
				Me.OnPlaceOfServiceCodeChanging(value)
				Me.SendPropertyChanging
				Me._PlaceOfServiceCode = value
				Me.SendPropertyChanged("PlaceOfServiceCode")
				Me.OnPlaceOfServiceCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PlaceOfServiceName", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property PlaceOfServiceName() As String
		Get
			Return Me._PlaceOfServiceName
		End Get
		Set
			If (String.Equals(Me._PlaceOfServiceName, value) = false) Then
				Me.OnPlaceOfServiceNameChanging(value)
				Me.SendPropertyChanging
				Me._PlaceOfServiceName = value
				Me.SendPropertyChanged("PlaceOfServiceName")
				Me.OnPlaceOfServiceNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PlaceOfServiceDescription", DbType:="VarChar(1000) NOT NULL", CanBeNull:=false)>  _
	Public Property PlaceOfServiceDescription() As String
		Get
			Return Me._PlaceOfServiceDescription
		End Get
		Set
			If (String.Equals(Me._PlaceOfServiceDescription, value) = false) Then
				Me.OnPlaceOfServiceDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._PlaceOfServiceDescription = value
				Me.SendPropertyChanged("PlaceOfServiceDescription")
				Me.OnPlaceOfServiceDescriptionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PlaceOfServiceCategoryId", DbType:="Int")>  _
	Public Property PlaceOfServiceCategoryId() As System.Nullable(Of Integer)
		Get
			Return Me._PlaceOfServiceCategoryId
		End Get
		Set
			If (Me._PlaceOfServiceCategoryId.Equals(value) = false) Then
				Me.OnPlaceOfServiceCategoryIdChanging(value)
				Me.SendPropertyChanging
				Me._PlaceOfServiceCategoryId = value
				Me.SendPropertyChanged("PlaceOfServiceCategoryId")
				Me.OnPlaceOfServiceCategoryIdChanged
			End If
		End Set
	End Property
	
	<Association(Name:="OverlandParkTrizzetoPlaceOfService_OverlandParkTrizzeto_BenefitMapping", Storage:="_OverlandParkTrizzeto_BenefitMappings", ThisKey:="PlaceOfServiceCode", OtherKey:="OverlandParkTrizzetoPlaceOfService")>  _
	Public Property OverlandParkTrizzeto_BenefitMappings() As EntitySet(Of OverlandParkTrizzeto_BenefitMapping)
		Get
			Return Me._OverlandParkTrizzeto_BenefitMappings
		End Get
		Set
			Me._OverlandParkTrizzeto_BenefitMappings.Assign(value)
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
	
	Private Sub attach_OverlandParkTrizzeto_BenefitMappings(ByVal entity As OverlandParkTrizzeto_BenefitMapping)
		Me.SendPropertyChanging
		entity.OverlandParkTrizzeto_PlaceOfService = Me
	End Sub
	
	Private Sub detach_OverlandParkTrizzeto_BenefitMappings(ByVal entity As OverlandParkTrizzeto_BenefitMapping)
		Me.SendPropertyChanging
		entity.OverlandParkTrizzeto_PlaceOfService = Nothing
	End Sub
End Class
