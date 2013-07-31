using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Framework;

namespace MvcApplication.Controllers
{
    public class FormationController : Controller
    {
        //
        // GET: /Formation/

        public ActionResult Index(int intId = 1)
        {
                    List<Formation> results = FormationFactory. List(intId) ; 

                    String output = "<h1>Liste des formations</h1><table>";
                    int pourcent = FormationFactory.GetPourcent(intId);
                        
                    output+="<h4>Pourcentage de remplissage : "+pourcent +"</h4>";

                    output+="<tr><td>ID internaute</td><td>ID Formation</td><td> Date Début</td><td> Date Fin</td><td>Ecole"
                            +"</td><td>Lieu</td><td>Specialite</td><td>Diplome</td><td>Obtenu"
                            + "</td><td>Code</td><td>Libelle</td></tr>";
                    foreach(Formation result in results){
                        output+=result;
                    }
                    output+="</table>";
                    this.ViewData["Result"] = output;
                    return View();
        }

        
        // GET: /Formation/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Formation/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                
                AjoutFormationSvc controller = new AjoutFormationSvc();
                SessionContainer scc = new SessionContainer();

                CtrlAttributesEnregistrer attributes = new CtrlAttributesEnregistrer();
                attributes.param_f_formation1_diplome = collection["Diplome"];
                attributes.param_f_formation1_lieu = collection["Lieu"];
                attributes.param_f_niveau_formation = int.Parse(collection["Niveau"]);

                
                controller.DoEnregistrer(scc, attributes);
               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Formation/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Formation/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Formation/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Formation/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
