﻿Imports PluginInterface
''' <summary>
''' This interface allows for the main script to execute plugins, the plugins must implement this interface
''' by building an interface the main script know which functions are available in the plugin
'''
''' </summary>
''' <remarks></remarks>
Public Interface IPlugin
    ''' <summary>
    ''' This is the name of the Plugin Name = "MyPlugin"
    ''' </summary>
    ''' <value></value>
    ''' <returns>this is s tring of the name of the plugin this is an identifier for the main script</returns>
    ''' <remarks></remarks>
    ReadOnly Property Name As String
    ''' <summary>
    ''' this is the response to be returned to the main script
    ''' </summary>
    ''' <value></value>
    ''' <returns>String: the response that is generated by the plugin
    ''' is stored here for retreival by the main script</returns>
    ''' <remarks></remarks>
    Property Response As String
    ''' <summary>
    ''' This is the response algorythm, this is the main function
    ''' the user input is sent to this function
    ''' </summary>
    ''' <param name="UserInput"></param>
    ''' <returns>True : If a response has been found</returns>
    ''' <remarks></remarks>
    Function GetResponse(ByVal UserInput As String) As Boolean
End Interface