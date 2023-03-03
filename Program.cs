using Antlr4.Runtime;
using ConsoleApp1;
using ConsoleApp1.Content;

var filename = "Content\\test.ss";

var fileContents = File.ReadAllText(filename);

var inputStream = new AntlrInputStream(fileContents);

var simpleLexer = new SimpleLexer(inputStream);

CommonTokenStream commonTokenStream = new CommonTokenStream(simpleLexer);

var simpleParser = new SimpleParser(commonTokenStream);

simpleParser.AddErrorListener(new DiagnosticErrorListener());

var simpleContext = simpleParser.program();

var visitor = new SimpleVisitor();

visitor.Visit(simpleContext);