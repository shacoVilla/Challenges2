// <copyright file="ResultCase.cs" company="VOXELGROUP">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Core.Output
{
    using System.Collections.Generic;

    public class ResultCase
    {
        public ResultCase(int nr)
        {
            this.CaseNumber = nr;
            this.Names = new List<string>();
        }

        public int CaseNumber { get; set; }

        public List<string> Names { get; set; }
    }
}
