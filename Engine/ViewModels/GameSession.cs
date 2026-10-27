namespace Engine.ViewModels;
using Engine.Models;


public class GameSession
{
    Player CurrentPlayer { get; set; }

    public GameSession()
    {
        CurrentPlayer = new Player();
        CurrentPlayer.Name = "Russell";
        CurrentPlayer.Gold = 1000000;
    }
}