using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvToCSharpClass.Library;
using System.IO;
using System.Text.RegularExpressions;

namespace CsvToCSharpClass.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var cSharpClass = CsvToClass.CSharpClassCodeFromCsvFile(@"..\..\..\ExampleFiles\InputFile.csv", ",", "[DelimitedRecord(\",\")]", "[FieldOptional()]");
            File.WriteAllText(@"..\..\..\ExampleFiles\OutputFile.cs", cSharpClass);
        }
    }
}
