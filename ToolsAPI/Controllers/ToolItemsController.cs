﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToolsAPI.Models;

namespace ToolsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolItemsController : ControllerBase
    {
        private readonly ToolContext _context;

        public ToolItemsController(ToolContext context)
        {
            _context = context;
        }

        // GET: api/ToolItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToolItemDTO>>> GetToolItems()
        {
            return await _context.ToolItems.Select(x => ToolDTO(x)).ToListAsync();
        }
        // GET: api/ToolItems/5

        [HttpGet("{id}")]
        public async Task<ActionResult<ToolItemDTO>> GetToolItem(long id)
        {
            var toolItem = await _context.ToolItems.FindAsync(id);

            if (toolItem == null)
            {
                return NotFound();
            }

            return ToolDTO(toolItem);
        }

        // PUT: api/ToolItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToolItem(long id, ToolItemDTO toolDTO)
        {
            if (id != toolDTO.Id)
            {
                return BadRequest();
            }

            var toolItem = await _context.ToolItems.FindAsync(id);
            if (toolDTO == null)
            {
                return NotFound();
            }

            toolItem.Name = toolDTO.Name;
            toolItem.InToolbox = toolDTO.InToolbox;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ToolItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/ToolItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ToolItemDTO>> PostToolItem(ToolItemDTO toolDTO)
        {
            var toolItem = new ToolItem
            {
                InToolbox = toolDTO.InToolbox,
                Name = toolDTO.Name,
                Fastener = toolDTO.Fastener
            };

            _context.ToolItems.Add(toolItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetToolItem),
                new { id = toolItem.Id },
                ToolDTO(toolItem));
        }

        // DELETE: api/ToolItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToolItem(long id)
        {
            var toolItem = await _context.ToolItems.FindAsync(id);
            if (toolItem == null)
            {
                return NotFound();
            }

            _context.ToolItems.Remove(toolItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToolItemExists(long id)
        {
            return _context.ToolItems.Any(e => e.Id == id);
        }

        private static ToolItemDTO ToolDTO(ToolItem toolItem) => new ToolItemDTO
        {
            Id = toolItem.Id,
            Name = toolItem.Name,
            Fastener = toolItem.Fastener,
            InToolbox = toolItem.InToolbox
        };
    }
}
