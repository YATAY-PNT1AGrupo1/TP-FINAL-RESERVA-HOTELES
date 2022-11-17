using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROYECTO_TP_PNT1.Context;
using PROYECTO_TP_PNT1.Models;

namespace PROYECTO_TP_PNT1.Controllers
{
    public class ReservaController : Controller
    {
        private readonly ReservaDatabaseContext _context;

        public ReservaController(ReservaDatabaseContext context)
        {
            _context = context;
        }

        // GET: Reserva
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservas.ToListAsync());
        }

        // GET: Reserva/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .FirstOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reserva/Create
        public IActionResult Create()

        {
            List<Alojamiento> al = new List<Alojamiento>();
            al = (from a in _context.Alojamientos select a).ToList();
            al.Insert(0, new Alojamiento { idAlojamiento = 0, nombre = "--Seleccione el nombre del alojamiento--" });
            ViewBag.almessage = al;

            List<Cliente> cl = new List<Cliente>();
            cl = (from c in _context.Clientes select c).ToList();
            cl.Insert(0, new Cliente { idCliente = 0, nombre = "--Seleccione el nombre del cliente--" });
            ViewBag.clmessage = cl;

            return View();
        }
      
        // POST: Reserva/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,idAlojamiento, alojamiento,idCliente,cliente, entrada,salida,cantPersonas,CantHabitaciones,desayuno,confirmado")] Reserva reserva)
        {
            

            if (ModelState.IsValid)
            {
                //antes del add armar un metodo que le pasemos por parametro el objeto reserva, y dentro del metodo hay que tomar el dbContextDeReserva
                //hacer lo que esta en el pdf en la pagina dos. es decir hay que hacer una consulta a la reserva, y ver si existe. si existe no se hace el add.
                if (!ReservaExists(reserva.idReserva))
                {

                    reserva.precioTotal = (reserva.salida - reserva.entrada).TotalDays * precioAlojamiento((int)reserva.idAlojamiento) * reserva.cantPersonas * reserva.CantHabitaciones;

                    // reserva.precioTotal = (reserva.salida - reserva.entrada).TotalDays * reserva.alojamiento.precio * reserva.cantPersonas * reserva.CantHabitaciones;
                    _context.Add(reserva);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
             
            }
            return View(reserva);
        }

        // GET: Reserva/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            return View(reserva);
        }

        // POST: Reserva/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,entrada,salida,precio,confirmado,desayuno,cantPersonas,CantHabitaciones, alojamiento")] Reserva reserva)
        {
            if (id != reserva.idReserva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.idReserva))
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
            return View(reserva);
        }

        // GET: Reserva/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .FirstOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reserva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            _context.Reservas.Remove(reserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reservas.Any(e => e.idReserva == id);
        }

        public double precioAlojamiento(int id)
        {
            //var precio = from a in _context.Alojamientos where a.idAlojamiento == id select a.precio;
            //return Convert.ToDouble(precio);

            Alojamiento alojamientoId = _context.Alojamientos.Where(a => a.idAlojamiento == id).FirstOrDefault();


            return alojamientoId.precio;
        }

    }
}
