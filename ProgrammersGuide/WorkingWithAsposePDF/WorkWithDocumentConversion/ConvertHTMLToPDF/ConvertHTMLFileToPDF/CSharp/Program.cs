//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;

namespace ConvertHTMLFileToPDFExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Specify the The base path/url for the html file which serves as images database
            String basePath = "C:/temp/";
            HtmlLoadOptions htmloptions = new HtmlLoadOptions(basePath);
            // Load HTML file
            Document doc = new Document(dataDir+ "Input.html", htmloptions);
            // Save HTML file
            doc.Save(dataDir+ "output.pdf");
        }
    }
}
