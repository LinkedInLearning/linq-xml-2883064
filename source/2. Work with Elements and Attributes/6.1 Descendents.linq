<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// Elements finds those elements that are direct descendants, i.e. immediate children.
// Descendants finds children at any level, i.e. children, grand-children, etc..

  collectibles.Descendants("EyeCount").Dump();