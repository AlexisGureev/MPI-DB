using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MPI_DB.Data;

namespace MPI_DB.Controllers
{
    public class MPIController : Controller
    {
        private readonly MpiContext _context;

        public MPIController(MpiContext context)
        {
            _context = context;
        }

        // GET: MPI
        public async Task<IActionResult> Index()
        {
            var mpiContext = _context.Mpi; ///.Set<Mpi>()
            //.Include(m => m.ClssNavigation)
            //.Include(m => m.D)
            //.Include(m => m.DsNavigation)
            //.Include(m => m.GtNavigation)
            //.Include(m => m.MgNavigation)
            //.Include(m => m.OqNavigation)
            //.Include(m => m.ParentNavigation)
            //.Include(m => m.Rgf)
            //.Include(m => m.TypeNavigation);
            //int c = mpiContext.Count();
            //var arr = mpiContext.ToArray();
            return View(mpiContext);
        }

        // GET: MPI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _context.SkdGeolage.Load();
            var mpi = await _context.Mpi
                .Include(m => m.ClssNavigation)
                
                .Include(m => m.DsNavigation)
                .Include(m => m.GtNavigation)
                .Include(m => m.MgNavigation)
                .Include(m => m.OqNavigation)
                .Include(m => m.ParentNavigation)
                .Include(m => m.Rgf)
                .Include(m => m.TypeNavigation)
                .Include(m => m.Deposit1810)
                .Include(m => m.Rgf.Isnd)
                .Include(m => m.D.T2Geolunits)
                .Include(m => m.D.T3Rock)
                .Include(m => m.D.T4OreBody)
                .Include(m => m.D.T5Mineral)
                .Include(m => m.D.T6Reser)
                .Include(m => m.Isnd.KdGeolage)
                .Include(m => m.Isnd.KdText)

                .FirstOrDefaultAsync(m => m.Id == id);
            var fld_name = _context.SysFldstxt;
            ViewBag.fld = fld_name.ToDictionary(k => k.ColName.Replace("_", "").ToLower(), e => e.ColLbl);
            if (mpi == null)
            {
                return NotFound();
            }

            return View(mpi);
        }

        //// GET: MPI/Create
        //public IActionResult Create()
        //{
        //    ViewData["Clss"] = new SelectList(_context.DepositType, "Id", "ValEn");
        //    ViewData["DId"] = new SelectList(_context.Deposit1810, "Id", "Id");
        //    ViewData["Ds"] = new SelectList(_context.DepositSize, "Code", "Code");
        //    ViewData["Gt"] = new SelectList(_context.GenType, "Code", "Code");
        //    ViewData["Mg"] = new SelectList(_context.MineralGroup, "Code", "Code");
        //    ViewData["Oq"] = new SelectList(_context.OreQuality, "Code", "Code");
        //    ViewData["Parent"] = new SelectList(_context.Mpi, "Id", "Oq");
        //    ViewData["RgfId"] = new SelectList(_context.Deposit1810, "KdId", "KdId");
        //    ViewData["Type"] = new SelectList(_context.PlacedType, "Id", "ValEn");
        //    return View();
        //}

        //// POST: MPI/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Mdgid,Ui,IndNum,DnRu,SdnRu,DnEng,SdnEng,Mg,Mm,Am,Gt,Ct,Ds,Oq,Mor,Age,AgeGroup,Met,Sta,Comment,RegCountry,ChenTy201,Act,Lip,F5mShow,RgfId,ValidUser,Admin,Ncea25m,OreUnits,ComUnits,OreRes,Content,ContUnit,ReserCom,Comments,MmFirst,AgeTect,DId,Parent,Type,Clss,SrcMark,RgfUrl,MmFiltered,AmFiltered")] Mpi mpi)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(mpi);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["Clss"] = new SelectList(_context.DepositType, "Id", "ValEn", mpi.Clss);
        //    ViewData["DId"] = new SelectList(_context.Deposit1810, "Id", "Id", mpi.DId);
        //    ViewData["Ds"] = new SelectList(_context.DepositSize, "Code", "Code", mpi.Ds);
        //    ViewData["Gt"] = new SelectList(_context.GenType, "Code", "Code", mpi.Gt);
        //    ViewData["Mg"] = new SelectList(_context.MineralGroup, "Code", "Code", mpi.Mg);
        //    ViewData["Oq"] = new SelectList(_context.OreQuality, "Code", "Code", mpi.Oq);
        //    ViewData["Parent"] = new SelectList(_context.Mpi, "Id", "Oq", mpi.Parent);
        //    ViewData["RgfId"] = new SelectList(_context.Deposit1810, "KdId", "KdId", mpi.RgfId);
        //    ViewData["Type"] = new SelectList(_context.PlacedType, "Id", "ValEn", mpi.Type);
        //    return View(mpi);
        //}

        // GET: MPI/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mpi = await _context.Mpi.FindAsync(id);
            if (mpi == null)
            {
                return NotFound();
            }
            ViewData["Clss"] = new SelectList(_context.DepositType, "Id", "ValEn", mpi.Clss);
            ViewData["DId"] = new SelectList(_context.Deposit1810, "Id", "Id", mpi.DId);
            ViewData["Ds"] = new SelectList(_context.DepositSize, "Code", "Code", mpi.Ds);
            ViewData["Gt"] = new SelectList(_context.GenType, "Code", "Code", mpi.Gt);
            ViewData["Mg"] = new SelectList(_context.MineralGroup, "Code", "Code", mpi.Mg);
            ViewData["Oq"] = new SelectList(_context.OreQuality, "Code", "Code", mpi.Oq);
            ViewData["Parent"] = new SelectList(_context.Mpi, "Id", "Oq", mpi.Parent);
            //ViewData["RgfId"] = new SelectList(_context.Deposit1810, "KdId", "KdId", mpi.RgfId);
            ViewData["Type"] = new SelectList(_context.PlacedType, "Id", "ValEn", mpi.Type);
            return View(mpi);
        }

        // POST: MPI/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mdgid,Ui,IndNum,DnRu,SdnRu,DnEng,SdnEng,Mg,Mm,Am,Gt,Ct,Ds,Oq,Mor,Age,AgeGroup,Met,Sta,Comment,RegCountry,ChenTy201,Act,Lip,F5mShow,RgfId,ValidUser,Admin,Ncea25m,OreUnits,ComUnits,OreRes,Content,ContUnit,ReserCom,Comments,MmFirst,AgeTect,DId,Parent,Type,Clss,SrcMark,RgfUrl,MmFiltered,AmFiltered")] Mpi mpi)
        {
            if (id != mpi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mpi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MpiExists(mpi.Id))
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
            ViewData["Clss"] = new SelectList(_context.DepositType, "Id", "ValEn", mpi.Clss);
            ViewData["DId"] = new SelectList(_context.Deposit1810, "Id", "Id", mpi.DId);
            ViewData["Ds"] = new SelectList(_context.DepositSize, "Code", "Code", mpi.Ds);
            ViewData["Gt"] = new SelectList(_context.GenType, "Code", "Code", mpi.Gt);
            ViewData["Mg"] = new SelectList(_context.MineralGroup, "Code", "Code", mpi.Mg);
            ViewData["Oq"] = new SelectList(_context.OreQuality, "Code", "Code", mpi.Oq);
            ViewData["Parent"] = new SelectList(_context.Mpi, "Id", "Oq", mpi.Parent);
            //ViewData["RgfId"] = new SelectList(_context.Deposit1810, "KdId", "KdId", mpi.RgfId);
            ViewData["Type"] = new SelectList(_context.PlacedType, "Id", "ValEn", mpi.Type);
            return View(mpi);
        }

        //// GET: MPI/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var mpi = await _context.Mpi
        //        .Include(m => m.ClssNavigation)
        //        .Include(m => m.D)
        //        .Include(m => m.DsNavigation)
        //        .Include(m => m.GtNavigation)
        //        .Include(m => m.MgNavigation)
        //        .Include(m => m.OqNavigation)
        //        .Include(m => m.ParentNavigation)
        //        .Include(m => m.Rgf)
        //        .Include(m => m.TypeNavigation)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (mpi == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(mpi);
        //}

        //// POST: MPI/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var mpi = await _context.Mpi.FindAsync(id);
        //    _context.Mpi.Remove(mpi);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool MpiExists(int id)
        {
            return _context.Mpi.Any(e => e.Id == id);
        }
    }
}