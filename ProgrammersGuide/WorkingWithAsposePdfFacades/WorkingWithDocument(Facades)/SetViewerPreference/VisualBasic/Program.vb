'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace SetViewerPreferenceExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'open document
			Dim contentEditor As New PdfContentEditor()
			contentEditor.BindPdf(dataDir & "input.pdf")

			'change Viewer Preferences
			contentEditor.ChangeViewerPreference(ViewerPreference.CenterWindow)
			contentEditor.ChangeViewerPreference(ViewerPreference.HideMenubar)
			contentEditor.ChangeViewerPreference(ViewerPreference.PageModeUseNone)

			'save output PDF file
			contentEditor.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace