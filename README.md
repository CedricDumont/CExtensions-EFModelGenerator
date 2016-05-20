# CExtensions.EFModelGenerator

currently in beta and preview

CExtensions.EFModelGenerator is a tool to generate code first model from a database schema.

The tool is configurable and customizable and currently supports Oracle and SqlServer out of the box.

Check CExtensions.EFModelGenerator.Oracle or CExtensions.EFModelGenerator.SqlServer  for an example on how to implement a provider

check CExtensions.EFModelGenerator.Serializers for an example on how to implement serializers.

this tool is alos available as a visual studio exetension and available on http://nuget.org

you will need a config file with some information to generate the code:

```
{
  "FilePath": "Models.cs",
  "Options": {
    "SchemaName": "dbo",
    "ProviderType": "CExtensions.EFModelGenerator.SqlServer.SqlDataProvider, CExtensions.EFModelGenerator.SqlServer",
    "ProviderTypeArguments": [ "Server=MC0QKBSC\\SQLEXPRESS;Database=FSEND_NET;Trusted_Connection=True;", "dbo" ],
    "SerializerType": "CExtensions.EFModelGenerator.Serializers.ModelSerializer, CExtensions.EFModelGenerator.Serializers",
    "SerializerTypeArguments": [ "my.business.space" ],
    "IgnoreTableRegex": [ "^backup" ]
  }

}
```