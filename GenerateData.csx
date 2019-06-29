#!/usr/bin/env dotnet-script

var inputFolder = "./img/buttons";
var outputFile = "./_data/buttons.yaml";

var builder = new StringBuilder();
foreach(var file in Directory.GetFiles(inputFolder))
{
    builder.AppendLine($"- img: {Path.GetFileName(file)}");
}

File.WriteAllText(outputFile, builder.ToString());