using System;

namespace Framework
{
    /// <summary>
    /// lasse CtrlAttributes pour l'action Enregistrer du controleur EnregistrerCtrl
    /// </summary>
    public class CtrlAttributesEnregistrer : ControllerBaseAttributes
    {

        public long param_f_niveau_formation;

        public long param_f_formation1_frmid = 0L;

        public int param_f_formation1_date_debut_mois;

        public int param_f_formation1_date_debut_annee;

        public int param_f_formation1_date_fin_mois;

        public int param_f_formation1_date_fin_annee;

        public string param_f_formation1_etablissement;

        public string param_f_formation1_lieu;

        public string param_f_formation1_diplome;

        public byte param_f_formation1_obtenu;

        public string param_f_formation1_specialisation;

        public long param_f_formation1_tfo_code;

        //Type : continue ou scolaire
        public string param_f_formation1_type;

        public string param_f_formation1_nom_formation_continue;
    }
}
