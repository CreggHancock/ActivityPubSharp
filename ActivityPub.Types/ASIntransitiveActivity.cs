// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Text.Json.Serialization;
using ActivityPub.Types.Attributes;

namespace ActivityPub.Types;

/// <summary>
/// Instances of IntransitiveActivity are a subtype of Activity representing intransitive actions.
/// The object property is therefore inappropriate for these activities. 
/// </summary>
/// <seealso href="https://www.w3.org/TR/activitystreams-vocabulary/#dfn-intransitiveactivity"/>
public class ASIntransitiveActivity : ASActivity
{
    private ASIntransitiveActivityEntity Entity { get; }

    public ASIntransitiveActivity() => Entity = new ASIntransitiveActivityEntity(TypeMap);
    public ASIntransitiveActivity(TypeMap typeMap) : base(typeMap) => Entity = TypeMap.AsEntity<ASIntransitiveActivityEntity>();
}

/// <inheritdoc cref="ASIntransitiveActivity"/>
[ASTypeKey(IntransitiveActivityType)]
[ImpliesOtherEntity(typeof(ASActivityEntity))]
public sealed class ASIntransitiveActivityEntity : ASBase<ASIntransitiveActivity>
{
    public const string IntransitiveActivityType = "IntransitiveActivity";

    private static readonly IReadOnlySet<string> ReplacedTypes = new HashSet<string>()
    {
        ASActivityEntity.ActivityType
    };

    /// <inheritdoc cref="ASBase{TType}(ActivityPub.Types.TypeMap,string,System.Collections.Generic.IReadOnlySet{string}?)"/>
    public ASIntransitiveActivityEntity(TypeMap typeMap) : base(typeMap, IntransitiveActivityType, ReplacedTypes) {}

    /// <inheritdoc cref="ASBase{T}(string, IReadOnlySet{string}?)"/>
    [JsonConstructor]
    public ASIntransitiveActivityEntity() : base(IntransitiveActivityType, ReplacedTypes) {}
}