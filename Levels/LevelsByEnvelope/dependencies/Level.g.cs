//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A horizontal planer datum.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Level : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public Level(double @elevation, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.Elevation = @elevation;
            }
        
        // Empty constructor
        public Level()
            : base()
        {
        }
    
        /// <summary>The elevation of the level.</summary>
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Elevation { get; set; }
    
    
    }
}