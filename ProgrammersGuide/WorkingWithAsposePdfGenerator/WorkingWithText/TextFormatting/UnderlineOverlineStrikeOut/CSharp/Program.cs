//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace UnderlineOverlineStrikeOut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

             // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Pdf instance by calling its empty constructor
Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

//Create a section in the Pdf object
Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

//Create 1st text paragraph
Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1,"Text underline");

//Set IsUnderline property of Text.TextInfo to true
text1.TextInfo.IsUnderline=true;

//Create 2nd text paragraph
Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(sec1,"Text overline");

//Set IsOverline property of Text.TextInfo to true
text2.TextInfo.IsOverline=true;

//Create 3rd text paragraph
Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text(sec1,"Text strike out");

//Set IsStrikeOut property of Text.TextInfo to true
text3.TextInfo.IsStrikeOut=true;

//Add 1st, 2nd and 3rd text paragraphs to the section
sec1.Paragraphs.Add(text1);
sec1.Paragraphs.Add(text2);
sec1.Paragraphs.Add(text3);

//Save the Pdf
pdf1.Save(dataDir+ "Output.pdf");
            
            
        }
    }
}