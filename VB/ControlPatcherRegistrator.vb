Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Class ControlPatcher(Of T As Control)
        Private _ProcessControlAction As Action(Of T)
        Public Sub New(ByVal processControlAction As Action(Of T))
            _ProcessControlAction = processControlAction
        End Sub

        Public Sub ProcessContainer(ByVal container As Control)
            For Each control As Control In container.Controls
                If control.GetType() Is GetType(T) Then
                    ProcessControl(control)
                Else
                    ProcessContainer(control)
                End If
            Next control
        End Sub

        Private Sub ProcessControl(ByVal control As Object)
            _ProcessControlAction(TryCast(control, T))
        End Sub
    End Class

    Public Class ControlPatcherRegistrator
        Inherits Component

        Private Function IsDesignMode() As Boolean
            Return DesignMode OrElse DevExpress.Utils.Design.DesignTimeTools.IsDesignMode
        End Function

        Public Sub New(ByVal container As IContainer)
            If Not IsDesignMode() Then
                Return
            End If


        End Sub

        Public Property ContainerControl() As Form
            Get
                Return _containerControl
            End Get
            Set(ByVal value As Form)
                _containerControl = value
                SubscribeEvents()
            End Set
        End Property
        Private _containerControl As Form = Nothing

        Public Overrides Property Site() As ISite
            Get
                Return MyBase.Site
            End Get
            Set(ByVal value As ISite)
                MyBase.Site = value
                If value Is Nothing Then
                    Return
                End If
                Dim host As IDesignerHost = TryCast(value.GetService(GetType(IDesignerHost)), IDesignerHost)
                If host Is Nothing Then
                    Return
                End If
                Dim componentHost As IComponent = host.RootComponent
                If TypeOf componentHost Is Form Then
                    _containerControl = TryCast(componentHost, Form)
                End If
            End Set
        End Property

        Private Sub SubscribeEvents()
            If ContainerControl Is Nothing Then
                Return
            End If
            RemoveHandler ContainerControl.Load, AddressOf ContainerControl_Load
            AddHandler ContainerControl.Load, AddressOf ContainerControl_Load
        End Sub

        Private Sub ContainerControl_Load(ByVal sender As Object, ByVal e As EventArgs)
            Register()
        End Sub

        Public Sub Register()
            CType(New ControlPatcher(Of ButtonEdit)(Sub(edit) edit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor), ControlPatcher(Of ButtonEdit)).ProcessContainer(ContainerControl)
            CType(New ControlPatcher(Of DateEdit)(Sub(edit) edit.Properties.WeekDayAbbreviationLength = 3), ControlPatcher(Of DateEdit)).ProcessContainer(ContainerControl)
            CType(New ControlPatcher(Of TextEdit)(Sub(edit) edit.Properties.NullValuePrompt = "Enter your text here"), ControlPatcher(Of TextEdit)).ProcessContainer(ContainerControl)
        End Sub
    End Class
End Namespace
