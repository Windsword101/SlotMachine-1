//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TranslateToPositionComponent translateToPosition { get { return (TranslateToPositionComponent)GetComponent(GameComponentsLookup.TranslateToPosition); } }
    public bool hasTranslateToPosition { get { return HasComponent(GameComponentsLookup.TranslateToPosition); } }

    public void AddTranslateToPosition(float newStartSpeed) {
        var index = GameComponentsLookup.TranslateToPosition;
        var component = CreateComponent<TranslateToPositionComponent>(index);
        component.startSpeed = newStartSpeed;
        AddComponent(index, component);
    }

    public void ReplaceTranslateToPosition(float newStartSpeed) {
        var index = GameComponentsLookup.TranslateToPosition;
        var component = CreateComponent<TranslateToPositionComponent>(index);
        component.startSpeed = newStartSpeed;
        ReplaceComponent(index, component);
    }

    public void RemoveTranslateToPosition() {
        RemoveComponent(GameComponentsLookup.TranslateToPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherTranslateToPosition;

    public static Entitas.IMatcher<GameEntity> TranslateToPosition {
        get {
            if (_matcherTranslateToPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TranslateToPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTranslateToPosition = matcher;
            }

            return _matcherTranslateToPosition;
        }
    }
}
