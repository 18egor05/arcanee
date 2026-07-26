// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Prototypes;

namespace Content.Server.NPC.HTN;

/// <summary>
/// Represents a network of multiple tasks. This gets expanded out to its relevant nodes.
/// </summary>
[Prototype("htnCompound")]
public sealed class HTNCompoundPrototype : IPrototype
{
    [IdDataField] public string ID { get; private set; } = string.Empty;

    [DataField("branches", required: true)]
    public List<HTNBranch> Branches = new();

    /// <summary>
    /// Exclude this compound task from the CompoundRecursion integration test.
    /// </summary>
    [DataField]
    public bool AllowRecursion;
}