<Query Kind="Statements">
  <Namespace>System.Numerics</Namespace>
</Query>

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var xDoc = XDocument.Load(root + upPath + path);
var xElem = XElement.Load(root + upPath + path);
#endregion

// XElement vs XDocument

// XElement.Load returns an element, the root element
// XDocument.Load return a document, which represents the entire XML doc


xDoc.Elements().Dump("Root element, one XElement in the enumerable");

xElem.Elements().Dump("The children of the root element");

