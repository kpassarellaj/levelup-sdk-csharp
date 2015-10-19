//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// <copyright file="Location.cs" company="SCVNGR, Inc. d/b/a LevelUp">
//   Copyright(c) 2015 SCVNGR, Inc. d/b/a LevelUp. All rights reserved.
// </copyright>
// <license publisher="Apache Software Foundation" date="January 2004" version="2.0">
//   Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
//   in compliance with the License. You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software distributed under the License
//   is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
//   or implied. See the License for the specific language governing permissions and limitations under
//   the License.
// </license>
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

using Newtonsoft.Json;

namespace LevelUp.Api.Client.Models.Responses
{
    /// <summary>
    /// Class representing a basic LevelUp merchant location
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Location
    {
        public Location()
        {
            LocationContainer = new LocationContainerBase();
        }

        /// <summary>
        /// Identification number for the location
        /// </summary>
        public virtual int LocationId { get { return LocationContainer.LocationId; } }

        /// <summary>
        /// Name of the location
        /// </summary>
        public virtual string Name { get { return LocationContainer.Name; } }

        /// <summary>
        /// Tip preference for the location
        /// </summary>
        public virtual string TipPreference { get { return LocationContainer.TipPreference; } }

        /// <summary>
        /// This container is used to aid in correct JSON serialization
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        private LocationContainerBase LocationContainer { get; set; }

        public override string ToString()
        {
            return LocationContainer.ToString();
        }
    }
}