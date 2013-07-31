<!DOCTYPE html>

<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>

<html lang="fr">

<body>
	<div class="container">
		<h1>Ajouter une formation</h1>

		<form:form modelAttribute="ctrlAttributesEnregistrer" method="save" class="form-horizontal" id="add-owner-form">
			<table>
				<tr>
					<td>Niveau formation:</td>
					<td><form:input path="param_f_niveau_formation"/></td>
				</tr>
				<tr>
                    <td>Date début :</td>
                    <td>
                        Année <form:input path="param_f_formation1_date_debut_annee"/>
                        Mois <form:input path="param_f_formation1_date_debut_mois"/>
                    </td>
                </tr>
                <tr>
                    <td>Date fin:</td>
                    <td>
                        Année <form:input path="param_f_formation1_date_fin_annee"/>
                        Mois <form:input path="param_f_formation1_date_fin_mois"/>
                    </td>
                </tr>
                <tr>
                    <td>Etablissement :</td>
                    <td><form:input path="param_f_formation1_etablissement"/></td>
                </tr>
                <tr>
                    <td>Lieu :</td>
                    <td><form:input path="param_f_formation1_lieu"/></td>
                </tr>
                <tr>
                    <td>Diplôme :</td>
                    <td><form:input path="param_f_formation1_diplome"/></td>
                </tr>
                <tr>
                    <td>Obtenu ?:</td>
                    <td><form:input path="param_f_formation1_obtenu"/></td>
                </tr>
                <tr>
                    <td>Spécialisation :</td>
                    <td><form:input path="param_f_formation1_specialisation"/></td>
                </tr>

			</table>

			<div class="form-actions">
				<button type="submit">Sauvegarder</button>
			</div>
		</form:form>
	</div>
</body>

</html>