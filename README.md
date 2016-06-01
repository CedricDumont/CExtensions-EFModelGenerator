# CExtensions.EFModelGenerator    

(Note : currently in beta and preview)

[![cextensions-efmodelgenerator MyGet Build Status](https://www.myget.org/BuildSource/Badge/cextensions-efmodelgenerator?identifier=a699acc9-c13f-462c-8526-3050bbceda1c)](https://www.myget.org/)

### Contribute
Want to start coding in c# or you have a need for this kind of tool, then check issues marked with [Help Wanted Label](https://github.com/CedricDumont/CExtensions-EFModelGenerator/labels/help%20wanted).

### Description 

CExtensions.EFModelGenerator is a tool used to generate code first model (more widely files) from a database schema.

The tool is configurable, customizable and currently supports Oracle and SqlServer out of the box. It is possible to write your own Provider. Check CExtensions.EFModelGenerator.Oracle as an example on how to implement a provider.

The code is generated using Serializers. There is a serilizer to generate Poco classes and a DbContext. You can write your own serilizer and it does not have to generate c# code. Check CExtensions.EFModelGenerator.Serializers for implementations.

There is a Visual Studio extension : [CExtensions.EFModelGenerator](https://visualstudiogallery.msdn.microsoft.com/ffe41640-7dfa-45c6-b398-ed73709c6170)

It's alos available on nuget.org : 
 - [CExtensions.EFModelGenerator](https://www.nuget.org/packages/CExtensions.EFModelGenerator)
 - [CExtensions.EFModelGenerator.Oracle](https://www.nuget.org/packages/CExtensions.EFModelGenerator.Oracle)

### How to use

1. you will need a config file (some samples : [simple model](https://github.com/CedricDumont/CExtensions-EFModelGenerator/blob/master/src/Sample/SimpleSample/Models.json))
2. If you are using the Vs extension, then simply right click on the file and Generate.
3. If you are using the nuget packags, create a Console Project and it's simple as:
```csharp
 Generator.Generate(@"c:\Temp:\MyConfig.json");
```
 
### Config Samples:

the following project:  [Configuration Samples](https://github.com/CedricDumont/CExtensions-EFModelGenerator/tree/master/src/Sample/SimpleSample) lists some configuration samples.

