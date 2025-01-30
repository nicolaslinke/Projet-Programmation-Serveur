using LapinCouvert.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class AuthentificationTest
    {
        DbContextOptions<ApplicationDbContext> options;
        public AuthentificationTest()
        {
            options = new DbContextOptionsBuilder<ApplicationDbContext>()
            // TODO il faut installer la dépendance Microsoft.EntityFrameworkCore.InMemory
            .UseInMemoryDatabase(databaseName: "CardsService")
            .Options;
        }
    }
}
