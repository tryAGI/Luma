using System.Text.RegularExpressions;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

// Replaces strings like
// aspect_ratio: '2024-10-25T16:09:00.0000000+00:00'
// with
// aspect_ratio: '16:9'
yamlOrJson = Regex.Replace(yamlOrJson, @"aspect_ratio: '.*?'", "aspect_ratio: '16:9'");

await File.WriteAllTextAsync(path, yamlOrJson);
return;