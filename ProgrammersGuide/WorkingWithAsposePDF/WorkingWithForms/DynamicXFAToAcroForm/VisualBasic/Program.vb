'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.InteractiveFeatures.Forms

Namespace DynamicXFAToAcroForm
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' load dynamic XFA form
			Dim document As New Document(dataDir & "Dynamic_XFA.pdf")

			' set the form fields type as standard AcroForm
			document.Form.Type = FormType.Standard

			' save the resultant PDF
			document.Save(dataDir & "Standard_AcroForm.pdf")

		End Sub
	End Class
End Namespace