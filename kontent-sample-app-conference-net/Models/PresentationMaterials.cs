// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery;

namespace KenticoKontentModels
{
    public partial class PresentationMaterials
    {
        public const string Codename = "presentation_materials";
        public const string PresentationFileCodename = "presentation_file";
        public const string PresentationNameCodename = "presentation_name";

        public IEnumerable<Asset> PresentationFile { get; set; }
        public string PresentationName { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}