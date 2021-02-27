using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
              new Command {Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pen"},
              new Command {Id=1, HowTo="Cut Bread", Line="Get a knife", Platform="Chopping Board"},
              new Command {Id=2, HowTo="Make Koolaid", Line="Boil water", Platform="Container"}
            };

            return commands;
        }
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pen" };
        }
    }
}

