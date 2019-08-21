// <copyright file="IResultCase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Core.Output
{
    using System.Collections.Generic;

    public interface IResultCase
    {
        int CaseNumber { get; set; }

        List<string> Names { get; set; }
    }
}