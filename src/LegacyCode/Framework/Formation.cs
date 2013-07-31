using System;
using System.Data;

namespace Framework
{
    public class Formation {
	
        private long intId;

        private long frmId;

        private DateTime frmDateDebut;

        private DateTime frmDateFin;

        private String frmEcole = null;

        private String frmLieu = null;

        private String frmSpecialite = null;

        private String frmDiplome = null;

        private byte frmObtenu;

        private long tfoCode;

        private String tfoLibelle = null;

        public void populateFromRs(IDataReader res)
        {
            intId = FactoryUtils.GetLongValueFromRs(res, "INT_ID");
            frmId = FactoryUtils.GetLongValueFromRs(res, "FRM_ID");
            frmDateDebut = (DateTime) FactoryUtils.GetValueFromRs(res, "FRM_DATE_DEBUT");
            frmDateFin = (DateTime) FactoryUtils.GetValueFromRs(res, "FRM_DATE_FIN");
            frmEcole = (String) FactoryUtils.GetValueFromRs(res, "FRM_ECOLE");
            frmLieu = (String) FactoryUtils.GetValueFromRs(res, "FRM_LIEU");
            frmSpecialite = (String) FactoryUtils.GetValueFromRs(res, "FRM_SPECIALITE");
            frmDiplome = (String) FactoryUtils.GetValueFromRs(res, "FRM_DIPLOME");
            frmObtenu = FactoryUtils.GetByteValueFromRs(res, "FRM_OBTENU");
            tfoCode = FactoryUtils.GetLongValueFromRs(res, "TFO_CODE");
            tfoLibelle = (String) FactoryUtils.GetValueFromRs(res, "TFO_LIBELLE");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime getFrmDateDebut() {
            return frmDateDebut;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime getFrmDateFin() {
            return frmDateFin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getFrmDiplome() {
            return frmDiplome;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getFrmEtablisssement() {
            return frmEcole;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long getFrmId() {
            return frmId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getFrmLieu() {
            return frmLieu;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Byte getFrmObtenu() {
            return frmObtenu;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String getFrmSpecialite() {
            return frmSpecialite;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long getIntId() {
            return intId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long getTfoCode() {
            return tfoCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        public void setFrmDateDebut(DateTime date) {
            frmDateDebut = date;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        public void setFrmDateFin(DateTime date) {
            frmDateFin = date;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string"></param>
        public void setFrmDiplome(String @string) {
            frmDiplome = @string;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string"></param>
        public void setFrmEtablisssement(String @string) {
            frmEcole = @string;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="decimal"></param>
        public void setFrmId(long @decimal) {
            frmId = @decimal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string"></param>
        public void setFrmLieu(String @string) {
            frmLieu = @string;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="decimal"></param>
        public void setFrmObtenu(Byte @decimal) {
            frmObtenu = @decimal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string"></param>
        public void setFrmSpecialite(String @string) {
            frmSpecialite = @string;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="decimal"></param>
        public void setIntId(long @decimal) {
            intId = @decimal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="decimal"></param>
        public void setTfoCode(long @decimal) {
            tfoCode = @decimal;
        }

        
        public override String ToString() {
            return "<tr><td>" + intId + "</td><td>" + frmId + "</td><td>" + frmDateDebut + "</td><td>" + frmDateFin + "</td><td>"
                   + frmEcole + "</td><td>" + frmLieu + "</td><td>" + frmSpecialite + "</td><td>" + frmDiplome + "</td><td>" + frmObtenu
                   + "</td><td>" + tfoCode + "</td><td>" + tfoLibelle + "</td></tr>";
        }
	
    }
}
