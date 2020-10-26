// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace StructureByEnvelope
{
    public class StructureByEnvelopeInputs: S3Args
    {
		/// <summary>
		/// Grid interval in the X direction.
		/// </summary>
		[JsonProperty("Grid X-Axis Interval")]
		public double GridXAxisInterval {get;}

		/// <summary>
		/// Grid interval in the Y direction.
		/// </summary>
		[JsonProperty("Grid Y-Axis Interval")]
		public double GridYAxisInterval {get;}

		/// <summary>
		/// The offset of the grid lines from the slab edge.
		/// </summary>
		[JsonProperty("Slab Edge Offset")]
		public double SlabEdgeOffset {get;}

		/// <summary>
		/// The system used for construction.
		/// </summary>
		[JsonProperty("Type of Construction")]
		[JsonConverter(typeof(StringEnumConverter))]
		public TypeOfConstruction TypeOfConstruction {get;}



        /// <summary>
        /// Construct a StructureByEnvelopeInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public StructureByEnvelopeInputs() : base()
        {
			this.GridXAxisInterval = 10;
			this.GridYAxisInterval = 10;
			this.SlabEdgeOffset = 3;
			this.TypeOfConstruction = TypeOfConstruction.Steel;

        }


        /// <summary>
        /// Construct a StructureByEnvelopeInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public StructureByEnvelopeInputs(double gridXAxisInterval, double gridYAxisInterval, double slabEdgeOffset, TypeOfConstruction typeOfConstruction, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.GridXAxisInterval = gridXAxisInterval;
			this.GridYAxisInterval = gridYAxisInterval;
			this.SlabEdgeOffset = slabEdgeOffset;
			this.TypeOfConstruction = typeOfConstruction;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}