namespace rpg_Game_V1.ActionModels.Interface
{
    public interface IOffensive
    {
        int DmgValue { get; set; }
        bool Defend { get; set; }

        int Resolve();
    }
}
