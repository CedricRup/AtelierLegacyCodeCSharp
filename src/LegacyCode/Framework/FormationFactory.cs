// ----------------------------------------------------------------------------79
// SMILE
//
// @(#) $Header:
// /home/cvs/RefonteEspacePro/src/fr/cadremploi/biz/formation/FormationFactory.java,v
// 1.5 2005/12/06 17:20:09 lapag Exp $
//
// Langage : C#
//
// Description : Gestion des Formations
//
// Auteur : Jean Codemal
// Date creation : 26/02/2004
//
// Historique :
//
// ----------------------------------------------------------------------------79


using System;
using System.Collections.Generic;
using log4net;

namespace Framework
{
    public class FormationFactory
    {

        private static ILog logger = LogManager.GetLogger(typeof(FormationFactory));

        public static void Insert(Formation formation)
        {
            // Warning : fake for exercise
            long newId = Database.formationTable.Count;
            formation.setFrmId(newId);
            Database.formationTable.Add(newId, formation);
            logger.Info("inserting Formation :" + formation.ToString());
        }

        public static void Update(Formation formation)
        {
            // Warning : fake for exercise
            if (Database.formationTable[formation.getFrmId()] == null)
            {
                throw new Exception("No ROW in table FORMATION with given Identifier : " + formation.getFrmId());
            }
            Database.formationTable.Add(formation.getFrmId(), formation);
            logger.Info("Updating Formation :" + formation.ToString());
        }


        public static int GetPourcent(long intId)
        {
            // Warning : fake for exercise
            CV cv = Database.cvTable[intId];
            return cv.GetCuvPourcentFormation();
        }

        public static List<Formation> List(long intId)
        {
            // Warning : fake for exercise
            return new List<Formation>(Database.formationTable.Values);
        }
    }
}
