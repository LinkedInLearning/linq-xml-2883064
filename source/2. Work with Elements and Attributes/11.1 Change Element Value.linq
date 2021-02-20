<Query Kind="Statements" />

#region Load BigStarCollectibles-NoSchema xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"BigStarCollectibles-NoSchema.xml";
var collectibles = XElement.Load(root + upPath + path);
#endregion

// returns the XML data (including the element tags)
XElement monsterElement = collectibles.Element("Card").Element("Monster");
monsterElement.Dump("Monster element");

// change the child element values

// change exising child element value
monsterElement.SetElementValue(name: "Antenna", true);
monsterElement.Dump("Change antenna value");

// add new child element
monsterElement.SetElementValue(name: "IsScary", value: false);
monsterElement.Dump("added child element");

// remove child element
monsterElement.SetElementValue(name: "Spikes", value: null);
monsterElement.Dump("remove child element");
