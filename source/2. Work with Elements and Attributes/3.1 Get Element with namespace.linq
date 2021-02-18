<Query Kind="Statements" />

#region Load BigStarCollectibles xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

XNamespace theNamespace = "http://bigstarcollectibles.com/course-examples";


// when the XML data uses a XSD schema namespace, 
// the code must use the namespace to fully qualify the request for the element.
var theCard1 = collectibles.Element(theNamespace + "Card");
theCard1.Dump("The Card - with namespace string");

// or 

XNamespace theNamespace2 = collectibles.GetDefaultNamespace();
var theCard2 = collectibles.Element(theNamespace + "Card");
theCard2.Dump("The Card - with GetDefaultNamespace()");


