// <copyright file="ResultCase.cs" company="VOXELGROUP">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Core.Output
{
    using System.Collections.Generic;

    public class ResultCase
    {
        public int CaseNumber { get; set; }

        public List<string> Names { get; set; }

        public ResultCase(int nr)
        {
            this.CaseNumber = nr;
            this.Names = new List<string>();
        }

        public override string ToString()
        {
            return $"Case #{this.CaseNumber}: {string.Join(",", this.Names)}";
        }
    }
}
