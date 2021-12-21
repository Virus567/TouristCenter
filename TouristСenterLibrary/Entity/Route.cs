﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

namespace TouristСenterLibrary.Entity
{
    public class Route
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int NumberDays { get; set; }
        [Required] public List<CheckpointRoute> Checkpoints { get; set; } = new List<CheckpointRoute>();
        public static List<string> GetNameRoute()
        {
             return db.Route.Select(x => x.Name).ToList();
        }
        public static int GetDaysAmountByRouteName(string routeName)
        {
            Route route = db.Route.Where(r => r.Name == routeName).ToList()[0];            
            return route.NumberDays;
        }
    }
}
