using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using calculator_back_end1.Models;

namespace calculator_back_end1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorHistoriesController : ControllerBase
    {
        private readonly CalculatorContext _context;

        public CalculatorHistoriesController(CalculatorContext context)
        {
            _context = context;
        }

        // GET: api/CalculatorHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalculatorHistory>>> GetcalculatorHistories()
        {
            return await _context.calculatorHistories.ToListAsync();
        }

        // GET: api/CalculatorHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalculatorHistory>> GetCalculatorHistory(long id)
        {
            var calculatorHistory = await _context.calculatorHistories.FindAsync(id);

            if (calculatorHistory == null)
            {
                return NotFound();
            }

            return calculatorHistory;
        }

       

        // POST: api/CalculatorHistories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CalculatorHistory>> PostCalculatorHistory(CalculatorHistory calculatorHistory)
        {
            _context.calculatorHistories.Add(calculatorHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalculatorHistory", new { id = calculatorHistory.Id }, calculatorHistory);
        }

    }
}
