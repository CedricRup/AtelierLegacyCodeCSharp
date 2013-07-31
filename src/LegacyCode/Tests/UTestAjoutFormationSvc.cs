using Framework;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class UTestAjoutFormationCtrl
    {

        [Test]
        public void dummyTest()
        {
            AjoutFormationSvc controller = new AjoutFormationSvc();
            SessionContainer scc = new SessionContainer();

            CtrlAttributesEnregistrer attributes = new CtrlAttributesEnregistrer();
            attributes.param_f_formation1_diplome = "Master";
            attributes.param_f_formation1_lieu = "Paris";
            attributes.param_f_niveau_formation = 5L;
            attributes.param_f_formation1_date_debut_annee = 2013;
            attributes.param_f_formation1_date_debut_mois = 12;

            for (int i = 0; i < 21; i++)
            {
                controller.DoEnregistrer(scc, attributes);
            }

            CV retrieved = CVFactory.GetTableauBord(scc.Internaute.IntId);

            Assert.That(retrieved.GetCuvPourcentFormation(), Is.EqualTo(100));
        }
    }

}
