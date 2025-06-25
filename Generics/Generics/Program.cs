using Generics;
using System.Reflection.Metadata;

DataFlow<string> dataFlow = new DataFlow<string>();
dataFlow.AddBlock(new ReverseBlock());
dataFlow.AddBlock(new ReplaceAWithSixBlock());
dataFlow.AddBlock(new ReverseBlock());
dataFlow.AddBlock(new UpperCaseBlock());

string output = dataFlow.RunFlow("hallo");
Console.WriteLine(output);