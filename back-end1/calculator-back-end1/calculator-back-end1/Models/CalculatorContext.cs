using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator_back_end1.Models
{
    public class CalculatorContext: DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options): base(options)
        {
        }

        public DbSet<CalculatorHistory> calculatorHistories { get; set; }
    }
}
