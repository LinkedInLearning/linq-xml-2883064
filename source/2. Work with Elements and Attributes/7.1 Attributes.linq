<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

collectibles.Element("Card").Attributes().Dump("All Card Attributes");
collectibles.Element("Card").Attribute("team-name").Dump("team-name attribute");