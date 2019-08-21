// <copyright file="ResultCase.cs" company="VOXELGROUP">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Core.Output
{
    using System.Collections.Generic;
    using System.Linq;

    public class ResultCase : IResultCase
    {
        public int CaseNumber { get; set; }

        public List<string> Names { get; set; }

        public ResultCase(int nr)
        {
            this.CaseNumber = nr;
            this.Names = new List<string>();
        }

        public void AddResultCaseName(string name)
        {
            this.Names.Add(name);
        }

        public override string ToString()
        {
            return this.Names.Any() ? $"Case #{this.CaseNumber}: {string.Join(",", this.Names)}" : $"Case #{this.CaseNumber}: None";
        }
    }
}
