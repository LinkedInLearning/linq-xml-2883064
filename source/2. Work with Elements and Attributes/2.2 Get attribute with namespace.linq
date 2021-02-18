<Query Kind="Statements" />

#region Load BigStarCollectibles xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// An attribute is not considered a child of its parent element.
// An attribute never inherits the namespace of its parent element. 
// For that reason an attribute is only in a namespace if it has a proper namespace prefix. 
// To repeat: An attribute without a prefix is never in a namespace. 

XNamespace theNamespace = "http://bigstarcollectibles.com/course-examples";


// when the XML data uses a XSD schema namespace, 
// the code must use the namespace to fully qualify the request for the element.
var theCard1 = collectibles.Element(theNamespace + "Card");
theCard1.Dump("The Card - with namespace string");

XAttribute theAttribute = collectibles.Element(theNamespace + "Card").Attribute("card-name");
theAttribute.Dump();
