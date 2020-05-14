using System.Collections.Generic;
using System.Data.Entity;
using RetroLogger.Models;

namespace RetroLogger.DAL
{
    public class GameInitializer : DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            var games = new List<Game>
            {
            new Game{Title="The Legend of Zelda",Year=1986,Rank=10,Beaten=true,Clean=true,Duplicate=true},
            new Game{Title="Metroid",Year=1986,Rank=10,Beaten=true,Clean=true,Duplicate=false},
            new Game{Title="Heavy Barrel",Year=1988,Rank=9,Beaten=true,Clean=true,Duplicate=false},
            new Game{Title="Jackal",Year=1987,Rank=10,Beaten=true,Clean=true,Duplicate=true},
            new Game{Title="Super Mario Bros",Year=1986,Rank=10,Beaten=true,Clean=true,Duplicate=true},
            new Game{Title="The Legend of Zelda: Link's Adventures",Year=1987,Rank=8,Beaten=true,Clean=true,Duplicate=false},
            new Game{Title="Battletoads",Year=1989,Rank=8,Beaten=false,Clean=true,Duplicate=true},
            new Game{Title="Bad Dudes",Year=1986,Rank=7,Beaten=false,Clean=true,Duplicate=false},
            new Game{Title="Paperboy",Year=1986,Rank=7,Beaten=false,Clean=true,Duplicate=false},
            new Game{Title="Mega Man",Year=1987,Rank=8,Beaten=false,Clean=true,Duplicate=false}
            };

            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();
            var controllers = new List<Controller>
            {
            new Controller{Model="NES-004",Type="NES Standard",Functional=true,},
            new Controller{Model="NES-026",Type=" NES Advantage",Functional=true,},
            new Controller{Model="NES-039",Type="NES Dogbone",Functional=true,},
            new Controller{Model="NES-027",Type="NES MAX",Functional=true,},
            new Controller{Model="HC66-7",Type="Joycard SSS",Functional=false,},
            new Controller{Model="NES-013",Type="Zapper",Functional=true,},
            };
            controllers.ForEach(s => context.Controllers.Add(s));
            context.SaveChanges();
            var consoles = new List<Console>
            {
            new Console{Type="NES",Model="NES 001",Functional=true},
            new Console{Type="NES",Model="NES 001",Functional=false},

            };
            consoles.ForEach(s => context.Consoles.Add(s));
            context.SaveChanges();
        }
    }
}