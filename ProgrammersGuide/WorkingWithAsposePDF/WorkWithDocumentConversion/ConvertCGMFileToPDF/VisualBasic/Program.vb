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

Namespace ConvertCGMFileToPDFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Instantiate LoadOption object using CGMLoadOption
			Dim cgmload As New Aspose.Pdf.CgmLoadOptions()
			' instantiate Document object
			Dim doc As New Document(dataDir & "TECHDRAW.CGM", cgmload)
			' Save the resultant PDF document
			doc.Save(dataDir & "TECHDRAW.pdf")
		End Sub
	End Class
End Namespace