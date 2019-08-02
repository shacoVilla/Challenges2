// <copyright file="InputData.cs" company="VOXELGROUP">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Core.Input
{
    using System.Collections.Generic;

    public class InputData
    {
        public InputData()
        {
            this.Genders = new List<string>();
            this.AcademicYears = new List<string>();
            this.Studies = new List<string>();
            this.Ages = new List<string>();
        }

        public List<string> Genders { get; set; }

        public List<string> Ages { get; set; }

        public List<string> Studies { get; set; }

        public List<string> AcademicYears { get; set; }
    }
}
