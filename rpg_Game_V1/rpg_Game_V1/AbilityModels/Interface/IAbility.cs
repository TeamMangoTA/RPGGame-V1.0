namespace rpg_Game_V1.AbilityModels.Interface
{
    using ActionModels;

    public interface IAbility
    {
        int HealtDmg { get; set; }
        int StaminaEffect { get; set; }
        int ManaEffect { get; set; }
        string Name { get; set; }

        GameAction CreatAction();
    }
}
