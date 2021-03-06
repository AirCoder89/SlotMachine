//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly OutOfRangeComponent outOfRangeComponent = new OutOfRangeComponent();

    public bool isOutOfRange {
        get { return HasComponent(GameComponentsLookup.OutOfRange); }
        set {
            if (value != isOutOfRange) {
                var index = GameComponentsLookup.OutOfRange;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : outOfRangeComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherOutOfRange;

    public static Entitas.IMatcher<GameEntity> OutOfRange {
        get {
            if (_matcherOutOfRange == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.OutOfRange);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherOutOfRange = matcher;
            }

            return _matcherOutOfRange;
        }
    }
}
