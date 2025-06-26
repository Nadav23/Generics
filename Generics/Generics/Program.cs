using Generics;

DataFlow<string> dataFlow = new DataFlow<string>();
dataFlow.AddBlock(new UpperCaseBlock());
dataFlow.AddBlock(new ReverseBlock());
dataFlow.AddBlock(new ReplaceAWithSixBlock());

string output = dataFlow.RunFlow("hallo");
Console.WriteLine(output);