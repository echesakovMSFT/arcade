// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Maestro.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BuildData
    {
        /// <summary>
        /// Initializes a new instance of the BuildData class.
        /// </summary>
        public BuildData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildData class.
        /// </summary>
        public BuildData(string repository, string commit, string buildNumber, string branch = default(string), IList<AssetData> assets = default(IList<AssetData>), IList<int?> dependencies = default(IList<int?>))
        {
            Repository = repository;
            Branch = branch;
            Commit = commit;
            BuildNumber = buildNumber;
            Assets = assets;
            Dependencies = dependencies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string Commit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "buildNumber")]
        public string BuildNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assets")]
        public IList<AssetData> Assets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependencies")]
        public IList<int?> Dependencies { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Repository == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Repository");
            }
            if (Commit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Commit");
            }
            if (BuildNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BuildNumber");
            }
        }
    }
}
