﻿Imports System
Imports System.Windows.Controls

Imports Hearthstone_Deck_Tracker.Plugins
Public Class HDTVoice
    Implements IPlugin
    Public ReadOnly Property Author As String Implements IPlugin.Author
        Get
            Return "Chris Sheridan"
        End Get
    End Property

    Public ReadOnly Property ButtonText As String Implements IPlugin.ButtonText
        Get
            Return "Settings"
        End Get
    End Property

    Public ReadOnly Property Description As String Implements IPlugin.Description
        Get
            Return "Control Hearthstone using simple voice commands"
        End Get
    End Property

    Public ReadOnly Property MenuItem As MenuItem Implements IPlugin.MenuItem
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IPlugin.Name
        Get
            Return "HDT-Voice"
        End Get
    End Property

    Public ReadOnly Property Version As Version Implements IPlugin.Version
        Get
            Return New Version(0, 5, 0)
        End Get
    End Property

    Public Sub OnButtonPress() Implements IPlugin.OnButtonPress
        Dim fc As New formConfig
        fc.ShowDialog()

        Return
    End Sub

    Public Sub OnLoad() Implements IPlugin.OnLoad
        Dim voicePlugin As New hsVoicePlugin
        voicePlugin.Load()
    End Sub

    Public Sub OnUnload() Implements IPlugin.OnUnload
        Return
    End Sub

    Public Sub OnUpdate() Implements IPlugin.OnUpdate
        Return
    End Sub
End Class