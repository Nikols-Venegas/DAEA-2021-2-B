using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using System.Web.Helpers;
using Lab15.Models;
using Microsoft.Reporting.WebForms;
using System.IO;


namespace Lab15.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        #region Contexto
        private SchoolEntities _contexto;
        public SchoolEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new SchoolEntities();
                return _contexto;
            }
        }
        #endregion
        public ActionResult Index()
        {
            return View(Contexto.Person.ToList());
        }

        public ActionResult Reporte()
        {
            List<Person> listado = new List<Person>();
            listado = Contexto.Person.ToList();

            var rptviewer = new ReportViewer();
            rptviewer.ProcessingMode = ProcessingMode.Local;
            rptviewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reporte.rdlc";

            ReportDataSource rptdatasource = new ReportDataSource("dsPersona", listado);
            rptviewer.LocalReport.DataSources.Add(rptdatasource);
            rptviewer.SizeToReportContent = true;

            ViewBag.ReportViewer = rptviewer;
            return View();
        }
    }
}