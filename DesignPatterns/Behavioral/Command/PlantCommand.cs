using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class PlantCommand : ICommand
    {
        private Garden _garden;
        private string _plant;

        public PlantCommand(Garden garden, string plant)
        {
            _garden = garden;
            _plant = plant;
        }

        public bool Execute()
        {
            return _garden.Plant(_plant);
        }

        public void Undo()
        {
            _garden.Remove(_plant);
        }
    }
}
