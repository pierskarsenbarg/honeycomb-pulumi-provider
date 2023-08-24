using System.Collections.Generic;
using Pulumi;
using Pulumi.Honeycomb;

return await Deployment.RunAsync(() =>
{
   // Add your resources here
   // e.g. var resource = new Resource("name", new ResourceArgs { });

   var provider = new Pulumi.Honeycomb.Provider("provider", new() {Apikey = "lMX5t4qsjOa0UQSuJhgPFC"});

   var dataset = new Pulumi.Honeycomb.Dataset.Dataset("ds", new () {
      Description = "test",
      Name = "test"
   }, new CustomResourceOptions()
   {
      Provider = provider
   });

   // Export outputs here
   return new Dictionary<string, object?>
   {
      ["outputKey"] = "outputValue"
   };
});
