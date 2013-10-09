using System;

namespace Framework
{
    public class AjoutFormationSvc
    {

        public void DoEnregistrer(SessionContainer scc, ControllerBaseAttributes attributes) 
        {
            CtrlAttributesEnregistrer attEnregistrer = (CtrlAttributesEnregistrer) attributes;
            attributes.enableRedirectParam = true;
            Internaute internaute = scc.Internaute;
            CV cv = new CV();
            // On r�cup�re le Pourcentage d'origine
            CVFactory cvFactory = new CVFactory();
            cv = cvFactory.GetTableauBord(internaute.IntId);
            // On cr� un nouveau pour la mise � jour
            cv = new CV();
            cv.IntId = internaute.IntId;
            // poucentage pour ajout
            Formation formation1 = new Formation();
            formation1.setIntId(internaute.IntId);
            int param_renseign = 0;
            /* Formation 1 */
            if (HasStartingMonthAndYear(attEnregistrer)) {
                param_renseign = FormatAndSetFormationDate(attEnregistrer, formation1, param_renseign);
            }
            if (attEnregistrer.param_f_formation1_date_fin_mois != null
                && attEnregistrer.param_f_formation1_date_fin_annee != null)
            {
                    DateTime date = new DateTime(attEnregistrer.param_f_formation1_date_fin_annee.Value, attEnregistrer.param_f_formation1_date_fin_mois.Value, 1);
                    formation1.setFrmDateFin(date);
                    param_renseign++;
                }
            if (attEnregistrer.param_f_formation1_etablissement != null) {
                formation1.setFrmEtablisssement(attEnregistrer.param_f_formation1_etablissement);
                param_renseign++;
            }
            if (attEnregistrer.param_f_formation1_lieu != null) {
                formation1.setFrmLieu(attEnregistrer.param_f_formation1_lieu);
                param_renseign++;
            }
            if (attEnregistrer.param_f_formation1_diplome != null) {
                formation1.setFrmDiplome(attEnregistrer.param_f_formation1_diplome);
                param_renseign++;
            }
            if (attEnregistrer.param_f_formation1_obtenu != null)
            {
                formation1.setFrmObtenu(attEnregistrer.param_f_formation1_obtenu.Value);
                param_renseign++;
            }
            if (attEnregistrer.param_f_formation1_specialisation != null) {
                formation1.setFrmSpecialite(attEnregistrer.param_f_formation1_specialisation);
                param_renseign++;
            }
            if (attEnregistrer.param_f_formation1_tfo_code != null)
            {
                formation1.setTfoCode(attEnregistrer.param_f_formation1_tfo_code.Value);
                param_renseign++;
            }
            if (param_renseign > 0) {
                if (attEnregistrer.param_f_formation1_frmid == null
                    || attEnregistrer.param_f_formation1_frmid == null)
                {
                        FormationFactory.Insert(formation1);
                    }
                else {
                    formation1.setFrmId(attEnregistrer.param_f_formation1_frmid.Value);
                    FormationFactory.Update(formation1);
                }
            }
            int pourcent = FormationFactory.GetPourcent(internaute.IntId);
            if (attEnregistrer.param_f_niveau_formation != null)
            {
                cv.NivCode = (attEnregistrer.param_f_niveau_formation.Value);
                pourcent = pourcent + 5;
            }
            cv.SetCuvPourcentFormation(pourcent);
            cvFactory.InsertFormation(cv);
        }

        private int FormatAndSetFormationDate(CtrlAttributesEnregistrer attEnregistrer, Formation formation1, int param_renseign) {
            DateTime date = new DateTime(attEnregistrer.param_f_formation1_date_debut_annee.Value, attEnregistrer.param_f_formation1_date_debut_mois.Value, 1);
            formation1.setFrmDateDebut(date);
            param_renseign++;
            return param_renseign;
        }

        private bool HasStartingMonthAndYear(CtrlAttributesEnregistrer attEnregistrer) {
            return attEnregistrer.param_f_formation1_date_debut_mois != null
                   && attEnregistrer.param_f_formation1_date_debut_annee != null;
        }

    }
}
