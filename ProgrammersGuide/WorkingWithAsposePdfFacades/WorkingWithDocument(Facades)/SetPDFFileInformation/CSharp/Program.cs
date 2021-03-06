//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace SetPDFFileInformationExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open document
            PdfFileInfo fileInfo = new PdfFileInfo(dataDir+ "input.pdf");
            //set PDF information
            fileInfo.Author = "Aspose";
            fileInfo.Title = "Hello World!";
            fileInfo.Keywords = "Peace and Development";
            fileInfo.Creator = "Aspose";
            fileInfo.CreationDate = DateTime.Now.ToString();
            fileInfo.ModDate = DateTime.Now.ToString();
            //save updated file
            fileInfo.SaveNewInfo(dataDir+ "output.pdf");
            
            
        }
    }
}