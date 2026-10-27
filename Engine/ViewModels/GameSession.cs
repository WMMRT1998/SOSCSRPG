namespace Engine.ViewModels;
using Engine.Models;


public class GameSession
{
    public Player CurrentPlayer { get; set; }

    public GameSession()
    {
        CurrentPlayer = new Player();
        CurrentPlayer.Name = "Russell";
        CurrentPlayer.Gold = 1000000;
        CurrentPlayer.Level = 1;
        CurrentPlayer.CharacterClass = "Fighter";
        CurrentPlayer.HitPoints = 10;
        CurrentPlayer.ExperiencePoints = 0;
    }
}