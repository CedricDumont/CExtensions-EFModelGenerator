# CExtensions.EFModelGenerator    

(Note : currently in beta and preview)

[Build status : ](https://www.myget.org/Content/images/badges/successful.svg)


CExtensions.EFModelGenerator is a tool to generate code first model from a database schema.

The tool is configurable and customizable and currently supports Oracle and SqlServer out of the box.

Check CExtensions.EFModelGenerator.Oracle for an example on how to implement a provider

check CExtensions.EFModelGenerator.Serializers for an example on how to implement serializers.

Visual Studio extension : 
 - [CExtensions.EFModelGenerator](https://visualstudiogallery.msdn.microsoft.com/ffe41640-7dfa-45c6-b398-ed73709c6170)

Available on nuget.org : 
 - [CExtensions.EFModelGenerator](https://www.nuget.org/packages/CExtensions.EFModelGenerator)
 - [CExtensions.EFModelGenerator.Oracle](https://www.nuget.org/packages/CExtensions.EFModelGenerator.Oracle)


you will need a config file with some information to generate the code:
 - [simple model](https://github.com/CedricDumont/CExtensions-EFModelGenerator/blob/master/src/Sample/SimpleSample/Models.json)
 - [Multiple file generation](https://github.com/CedricDumont/CExtensions-EFModelGenerator/blob/master/src/Sample/SimpleSample/MultipleSettings.json)
 - [Sample for Oracle](https://github.com/CedricDumont/CExtensions-EFModelGenerator/blob/master/src/Sample/SimpleSample/OracleSample.json)
 
 check out the samples:
  - [Configuration Samples](https://github.com/CedricDumont/CExtensions-EFModelGenerator/tree/master/src/Sample/SimpleSample)

