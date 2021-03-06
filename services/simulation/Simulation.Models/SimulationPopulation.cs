﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simulation.Models
{
    public class SimulationPopulation
    {
        public int ID { get; set; }

        public ProjectSimulation ProjectSimulation { get; set; }

        public string PopulationKey { get; set; }

        public int VirtualPopulationSize { get; set; }

        public string Message { get; set; }

        public int ResourceID { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }
    }
}
