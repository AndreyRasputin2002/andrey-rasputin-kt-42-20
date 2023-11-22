using andrey_rasputin_kt_42_20.Database;
using andrey_rasputin_kt_42_20.Filters.PrepodDegreeFilters;
using andrey_rasputin_kt_42_20.Interfaces;
using andrey_rasputin_kt_42_20.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andrey_rasputin_kt_42_20.Test
{
    public class PepodDegreeIntegrationTests
    {
        public readonly DbContextOptions<PrepodDbContext> _dbContextOptions;

        public PepodDegreeIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<PrepodDbContext>()
            .UseInMemoryDatabase(databaseName: "prepod_db")
            .Options;
        }

        [Fact]
        public async Task GetPrepodsByDegreeAsync_KT4220_TwoObjects()
        {
            // Arrange
            var ctx = new PrepodDbContext(_dbContextOptions);
            var degreeService = new DegreeService(ctx);
   


            await ctx.SaveChangesAsync();

            // Act
            var filter = new PrepodDegreeFilter
            {
                Name_degree = "кандидат наук"
            };
            var prepodsResult = await degreeService.GetPrepodsByDegreeAsync(filter, CancellationToken.None);

            Assert.Equal(1, prepodsResult.Length);
        }
    }
}
