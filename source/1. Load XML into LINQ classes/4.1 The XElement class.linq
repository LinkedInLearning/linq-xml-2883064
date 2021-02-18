<Query Kind="Statements" />

var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path1 = @"BigStarCollectibles.xml";
var path2 = @"BigStarCollectibles-NoSchema.xml";
var loaded1 = XElement.Load(root + upPath + path1);
var loaded2 = XElement.Load(root + upPath + path2);

// The root element of the XML file is represented in the XElement instance
// more details about XElement and XAttribute later in course.
loaded1.GetType().FullName.Dump("XElement class represents an XML Element");
loaded1.Name.Dump("The XML element name (with schema)");
loaded2.Name.Dump("The XML element name (no schema)");

loaded1.Name.Namespace.Dump("The XML Namespace");
loaded2.Name.Namespace.Dump("The XML Namespace (no schema)");