# ReqIF_ Sharp
This is a fork for the ReqIF Sharp Library by RHEA Group. This fork includes a method to load embedded objects that are included in .reqifz file and referred to in XHTML data objects
## Changelog
### [3.0.1]
* Updated to ReqIFSharp 3.0.0
* No more distinction between Objects and Images. Every embedded Object is loaded as MemoryStream
* Implemented INotfiyPropertyChanged for AttributeValue.ObjectValue
### [2.2.1]
* Added Serialize method that returns a string
* Ignore embedded files that cannot be found in filesystem
### [2.2.0]
* Load embedded files referred to in XHTML data objects
