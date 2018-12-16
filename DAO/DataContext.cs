﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DataContext : DbContext
    {
        // Usefull to create the necessary tables in Database
        public DbSet<Action> Action { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<IngredientType> IngredientType { get; set; }
        public DbSet<Instruction> Instruction { get; set; }
        public DbSet<KitchenTool> KitchenTool { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<InstructionInDish> InstructionInDish { get; set; }

        // Initialize the data in Database
        public void initialize()
        {
            var initializer = new Initializer();
            initializer.Seed(this);
        }
    }
}
