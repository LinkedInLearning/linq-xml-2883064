<Query Kind="Statements">
  <Namespace>System.Numerics</Namespace>
</Query>

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";

var collectibles = XElement.Load(root + upPath + path);
#endregion

// Use the LINQPad DumpFormatted to 
// write output to a separate window with outlining enabled.
// Extension method for XElement


collectibles.DumpFormatted("collectables");

collectibles.Element("Card").Element("Prices").DumpFormatted("prices");
