<Query Kind="Expression" />

// Code Challenge:
// // use the WebColorsA.xml file as the data source

// Transform the XML with LINQ
// Original XML
	//<Color color-name="Crimson" color-family="Red">
	//	<Hex>DC143C</Hex>
	//	<Red>220</Red>
	//	<Green>20</Green>
	//	<Blue>60</Blue>
	//	<Hue>348</Hue>
	//	<Saturation>83</Saturation>
	//	<Lightness>47</Lightness>
	//</Color>
	
	
// Transformed XML
// With RGB and HSL elements
// remove attributes and make them elements

	//<Color>
	// <ColorName>Crimson</ColorName>
	// <ColorFamily>Red</ColorFamily>
	// <Hex>DC143C</Hex>
	//	<RGB>
	//		<Red>220</Red>
	//		<Green>20</Green>
	//		<Blue>60</Blue>
	//	</RGB>
	//	<HSL>
	//		<Hue>348</Hue>
	//		<Saturation>83</Saturation>
	//		<Lightness>47</Lightness>
	//	</HSL>
	//</Color>