using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Variables_2.Config;
using Variables_2.Models;

namespace Variables_2.Controllers
{
    public class EmprendedorController : Controller
    {
        private readonly Variables2DbContext _context;

        public EmprendedorController(Variables2DbContext context)
        {
            _context = context;
        }

        // GET: Emprendedor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Emprendedores.ToListAsync());
        }

        // GET: Emprendedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendedorModel = await _context.Emprendedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprendedorModel == null)
            {
                return NotFound();
            }

            return View(emprendedorModel);
        }

        // GET: Emprendedor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emprendedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cedula_Ruc,Nombre,Apellido,Direccion,Telefono,Edad,Genero,Fecha_Nacimiento")] EmprendedorModel emprendedorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emprendedorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emprendedorModel);
        }

        // GET: Emprendedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendedorModel = await _context.Emprendedores.FindAsync(id);
            if (emprendedorModel == null)
            {
                return NotFound();
            }
            return View(emprendedorModel);
        }

        // POST: Emprendedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cedula_Ruc,Nombre,Apellido,Direccion,Telefono,Edad,Genero,Fecha_Nacimiento")] EmprendedorModel emprendedorModel)
        {
            if (id != emprendedorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emprendedorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmprendedorModelExists(emprendedorModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(emprendedorModel);
        }

        // GET: Emprendedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendedorModel = await _context.Emprendedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprendedorModel == null)
            {
                return NotFound();
            }

            return View(emprendedorModel);
        }

        // POST: Emprendedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emprendedorModel = await _context.Emprendedores.FindAsync(id);
            if (emprendedorModel != null)
            {
                _context.Emprendedores.Remove(emprendedorModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmprendedorModelExists(int id)
        {
            return _context.Emprendedores.Any(e => e.Id == id);
        }
    }
}
