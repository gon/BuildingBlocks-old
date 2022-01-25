// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Amazon;
using Amazon.Lambda.Core;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace LevelBySketch
{
    public class Function
    {
        // Cache the model store for use by subsequent
        // executions of this lambda.
        private IModelStore<LevelBySketchInputs> store;

        public async Task<LevelBySketchOutputs> Handler(LevelBySketchInputs args, ILambdaContext context)
        {
            // Preload dependencies (if they exist),
            // so that they are available during model deserialization.

            var sw = System.Diagnostics.Stopwatch.StartNew();
            var asmLocation = this.GetType().Assembly.Location;
            var asmDir = Path.GetDirectoryName(asmLocation);

            // Explicitly load the dependencies project, it might have types
            // that aren't used in the function but are necessary for correct
            // deserialization.
            var asmName = Path.GetFileNameWithoutExtension(asmLocation);
            var depPath = Path.Combine(asmDir, $"{asmName}.Dependencies.dll");
            if(File.Exists(depPath))
            {
                Console.WriteLine($"Loading dependencies assembly from: {depPath}...");
                Assembly.LoadFrom(depPath);
                Console.WriteLine("Dependencies assembly loaded.");
            }

            // Load all reference assemblies.
            Console.WriteLine($"Loading all referenced assemblies.");
            foreach (var asm in this.GetType().Assembly.GetReferencedAssemblies())
            {
                try
                {
                    Assembly.Load(asm);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to load {asm.FullName}");
                    Console.WriteLine(e.Message);
                }
            }
            sw.Stop();
            Console.WriteLine($"Time to load assemblies: {sw.Elapsed.TotalSeconds})");

            if(this.store == null)
            {
                this.store = new S3ModelStore<LevelBySketchInputs>(RegionEndpoint.USWest1);
            }

            var l = new InvocationWrapper<LevelBySketchInputs,LevelBySketchOutputs>(store, LevelBySketch.Execute);
            var output = await l.InvokeAsync(args);
            return output;
        }
      }
}