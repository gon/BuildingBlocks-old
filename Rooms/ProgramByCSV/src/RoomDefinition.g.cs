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

    /// <summary>A room definition for space planning.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class RoomDefinition : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public RoomDefinition(string @suiteName, string @suiteNumber, string @roomDepartment, string @roomName, double @roomQuantity, double @roomArea, double @roomDimensionRatio, double @roomHeight, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<RoomDefinition>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @suiteName, @suiteNumber, @roomDepartment, @roomName, @roomQuantity, @roomArea, @roomDimensionRatio, @roomHeight, @id, @name});
            }
        
            this.SuiteName = @suiteName;
            this.SuiteNumber = @suiteNumber;
            this.RoomDepartment = @roomDepartment;
            this.RoomName = @roomName;
            this.RoomQuantity = @roomQuantity;
            this.RoomArea = @roomArea;
            this.RoomDimensionRatio = @roomDimensionRatio;
            this.RoomHeight = @roomHeight;
            
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Name of the suite to be assigned to the room.</summary>
        [Newtonsoft.Json.JsonProperty("Suite Name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SuiteName { get; set; }
    
        /// <summary>Number of the suite to be assigned to the room.</summary>
        [Newtonsoft.Json.JsonProperty("Suite Number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string SuiteNumber { get; set; }
    
        /// <summary>Name of the department to be assigned to the room.</summary>
        [Newtonsoft.Json.JsonProperty("Room Department", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string RoomDepartment { get; set; }
    
        /// <summary>Name of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Room Name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string RoomName { get; set; }
    
        /// <summary>Desired quantity of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Room Quantity", Required = Newtonsoft.Json.Required.Always)]
        public double RoomQuantity { get; set; }
    
        /// <summary>Desired area of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Room Area", Required = Newtonsoft.Json.Required.Always)]
        public double RoomArea { get; set; }
    
        /// <summary>Desired ratio of the X to Y dimensions of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Room Dimension Ratio", Required = Newtonsoft.Json.Required.Always)]
        public double RoomDimensionRatio { get; set; }
    
        /// <summary>Desired height of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Room Height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RoomHeight { get; set; }
    
    
    }
}