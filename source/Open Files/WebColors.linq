<Query Kind="Statements" />

#region Load WebColors xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\";
var path = @"WebColorsA.xml";
var allElements = XElement.Load(root + upPath + path);
#endregion

allElements.Dump();

