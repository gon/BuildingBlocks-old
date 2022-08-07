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

    /// <summary>A polyline that has been thickened into a polygon.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ThickenedPolyline 
    {
        [Newtonsoft.Json.JsonConstructor]
        public ThickenedPolyline(Polyline @polyline, double @width, bool @flip, double @leftWidth, double @rightWidth)
        {
            this.Polyline = @polyline;
            this.Width = @width;
            this.Flip = @flip;
            this.LeftWidth = @leftWidth;
            this.RightWidth = @rightWidth;
            }
        
        // Empty constructor
        public ThickenedPolyline()
        {
        }
    
        [Newtonsoft.Json.JsonProperty("polyline", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polyline Polyline { get; set; }
    
        [Newtonsoft.Json.JsonProperty("width", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Width { get; set; }
    
        [Newtonsoft.Json.JsonProperty("flip", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Flip { get; set; }
    
        /// <summary>The amount to thicken the polyline on its "left" side, imagining that the polyline is extending away from you. That is, if the polyline starts at (0,0,0) and follows the +Z axis, the left side extends into the -X quadrant.</summary>
        [Newtonsoft.Json.JsonProperty("leftWidth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double LeftWidth { get; set; }
    
        /// <summary>The amount to thicken the polyline on its "right" side, imagining that the polyline is extending away from you. That is, if the polyline starts at (0,0,0) and follows the +Z axis, the right side extends into the +X quadrant.</summary>
        [Newtonsoft.Json.JsonProperty("rightWidth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RightWidth { get; set; }
    
    
    }
}