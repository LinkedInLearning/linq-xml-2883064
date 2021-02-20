<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// return the attribute name-value pair
XAttribute teamnameAttribute = collectibles.Element("Card").Attribute("team-name");
teamnameAttribute.Dump("team-name attribute");

teamnameAttribute.Value.Dump("team-name value");

teamnameAttribute.Value = "DarkShadows";
teamnameAttribute.Dump("team-name attribute");


teamnameAttribute.Value.Dump("Modified team-name value");