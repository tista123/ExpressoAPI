using ExpressoAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ExpressoAPI.Data
{
    public class ExpressoDbContext :DbContext
    {
        public DbSet<Menu> Menus;

        public DbSet<Reservation> Reservations;
    } 
}