using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace GestionStageTP {
    public partial class InscriptionStageForm : Form {
        public InscriptionStageForm() {
            InitializeComponent();
        }
        // declaring and initializing the variables
        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder() {
            DataSource = ".",
            InitialCatalog = "BdStage00",
            IntegratedSecurity = true
        };
        public int codeStage;
        private void InscriptionStageForm_Load(object sender, EventArgs e) {
            loadData();
        }
        //protected void loadData()
        private void retourStageBTN_Click(object sender, EventArgs e) {
            // passing the data and rooling back
            try {
                ListInscritForm listInscritForm = new ListInscritForm();
                listInscritForm.Controls["typeStageTb"].Text = typeStageTb.Text;
                listInscritForm.Controls["dateDebutTB"].Text = dateDebutTB.Text;
                listInscritForm.Controls["dateFinTB"].Text = dateFinTB.Text;
                this.Hide();
                listInscritForm.codeStage = this.codeStage;  
                listInscritForm.Show();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        // this method loads the data to the combo boxes

        private void loadData() {
            // instantiating a new connection 
            using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                // instantiating a new command
                String query = "SELECT nom_stagaire, prenom_stagaire FROM stagaire ORDER BY CAST(num_stagaire AS int);";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    // instantiating a new datareader 
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        String data = "";
                        while (reader.Read()) {
                            // we just concat the data from the stream
                            for (int i = 0; i < reader.FieldCount; i++) {
                                data += reader.GetString(i).Trim() + " ";
                            }
                            choixStagaireCB.Items.Add(data);
                            data = "";
                        }

                    }
                }
            }
            // now we fill in the statut cb 
            choixStatutCB.Items.Add("CIF");
            choixStatutCB.Items.Add("SIFE");
            choixStatutCB.Items.Add("Ch.Force");
            choixStatutCB.Items.Add("Cde.Public");

            // we focus on the first control
            choixStagaireCB.Select();
            choixStagaireCB.Focus();
        }

        private void choixStagaireCB_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // we split the chosen data into 2 then put each half in its place
                nomTB.Text = choixStagaireCB.Text.Split(' ')[0];
                prenomTB.Text = choixStagaireCB.Text.Split(' ')[1];
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void nouvelleStagaireBTN_Click(object sender, EventArgs e) {
            try {
                NewStagaireForm newStagaireForm = new NewStagaireForm();
                newStagaireForm.dico.Add(typeStageTb.Name, typeStageTb.Text);
                newStagaireForm.dico.Add(dateDebutTB.Name, dateDebutTB.Text);
                newStagaireForm.dico.Add(dateFinTB.Name, dateFinTB.Text);
                newStagaireForm.codeStage = this.codeStage;
                this.Hide();
                newStagaireForm.Show();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        /**
        * This methods checks if 
        *         --> "nom" and "prenom" controls are blanc <passed>
        *         --> "status" not selected <passed>
        *         --> the stagaire have already finished his past stage <passed>
        *         --> the stagaire have the needed degree for the stage <passed>
        *         --> the stagaire has not already subscribed in 3 stages <passed>
        * **/
        private Boolean hasBlancs() {
            try {
                if (nomTB.Text == "" || prenomTB.Text == "") {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
        private Boolean nullStatus() {
            Boolean statusIsNull = false;
            try {
                if (choixStatutCB.SelectedIndex == -1)
                    statusIsNull = true;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return statusIsNull;
        }
        private Boolean isNotDoneYet() {
            Boolean isDone = false;
            try {
                // the stagaire have already finished his last "stage"
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    // the following query returns 0 if the "stagaire" have finished his last "stage" otherwise 1
                    String query = "SELECT TOP 1 CASE WHEN stage.fin_stage >= GETDATE() THEN 1 ELSE 0 END FROM stage " +
                        "INNER JOIN inscription ON stage.code_stage = inscription.code_stage " +
                        "WHERE inscription.num_stagaire = @num_stagaire " +
                        "ORDER BY stage.code_stage";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        int numStagaire = choixStagaireCB.SelectedIndex + 1;
                        command.Parameters.AddWithValue("@num_stagaire", numStagaire);
                        // if the "stagaire" haven't been already signed up to a "stage" it will crush while the command is returning a nullable 
                        isDone = (command.ExecuteScalar() != null && (int)command.ExecuteScalar() == 1) ? true : false;
                    }
                }

            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return isDone;
        }
        private Boolean doesntHaveDegree() {
            try {
                Boolean notHaveNeededDegree = false;
                // the stagaire have the needed degree for the stage 
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    using (SqlCommand command = new SqlCommand()) {
                        connection.Open();
                        command.Connection = connection;
                        // get the diplom
                        int num_stagaire = choixStagaireCB.SelectedIndex + 1;
                        String query = "SELECT diplo_stagaire FROM stagaire WHERE num_stagaire = @num_stagaire";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@num_stagaire", num_stagaire);
                        String diplomName = command.ExecuteScalar().ToString();
                        int niveau_Stage = 0;
                        // decrypte the diplom name +_+
                        if (diplomName.Equals("BAC"))
                            niveau_Stage = 3;
                        else if (diplomName.Equals("BEP"))
                            niveau_Stage = 4;
                        else
                            niveau_Stage = 5;
                        // if the stagaire have the needed degree the query returns 1 otherwise 0
                        query = "SELECT TOP 1 CASE WHEN typeStage.niveau_stage = @niveau_Stage THEN 1 ELSE 0 END FROM typeStage " +
                            "WHERE type_stage = @type_Stage";

                        String type_stage = typeStageTb.Text;

                        command.CommandText = query;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("niveau_Stage", niveau_Stage);
                        command.Parameters.AddWithValue("@type_Stage", type_stage);
                        // the query returns null if the staagaire haven't been signed in already at least once
                        notHaveNeededDegree = (command.ExecuteScalar() != null && (int)command.ExecuteScalar() == 1) ? false : true;
                    }
                    return notHaveNeededDegree;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
        private Boolean plusDe3() {
            Boolean has3Stages = false;
            try {
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    using (SqlCommand command = new SqlCommand()) {
                        connection.Open();
                        command.Connection = connection;
                        int num_stagaire = choixStagaireCB.SelectedIndex + 1;
                        String query = "SELECT COUNT(*) FROM inscription WHERE num_stagaire = @num_stagaire";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@num_stagaire", num_stagaire);
                        int nbrOfInscriptions = (int)(command.ExecuteScalar());
                        if (nbrOfInscriptions >= 3)
                            has3Stages = true;
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return has3Stages;
        }
        private Boolean isAllRight() {
            Boolean right = false;
            try {
                if (hasBlancs() || nullStatus() || isNotDoneYet() || doesntHaveDegree() || plusDe3())
                    right = false;
                else
                    right = true;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return right;
        }

        private void validationBTN_Click(object sender, EventArgs e) {
            try {
                if (isAllRight()) {
                    using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                        using (SqlCommand command = new SqlCommand()) {
                            connection.Open();
                            command.Connection = connection;

                            // we query the result of nbPlace_stage - nbInscrit_stage
                            String query = "SELECT nbPlace_stage - nbInscrit_stage FROM stage WHERE code_stage = @codeStage";
                            command.CommandText = query;
                            command.Parameters.AddWithValue("@codeStage", codeStage);
                            int nbrOfPlaces = Convert.ToInt32(command.ExecuteScalar());

                            // we add the new inscription
                            String statutInscription = (choixStatutCB.SelectedIndex + 1).ToString();
                            char codePosition = (char)(nbrOfPlaces > 0 ? '2' : '3');
                            String type_stage = typeStageTb.Text;
                            String numeroStagaire = (choixStagaireCB.SelectedIndex + 1).ToString();
                            // we build the query and assign it to the command
                            query = "INSERT INTO inscription VALUES " +
                                "((SELECT code_stage FROM stage WHERE code_stage = @codeStage), " +
                                "(SELECT num_stagaire FROM stagaire WHERE num_stagaire = @numeroStagaire), " +
                                "GETDATE(), @statutInscription, @codePosition)";
                            command.CommandText = query;

                            // we clear and add the new parameters
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@codeStage", codeStage);
                            command.Parameters.AddWithValue("@numeroStagaire", numeroStagaire);
                            command.Parameters.AddWithValue("@statutInscription", statutInscription);
                            command.Parameters.AddWithValue("@codePosition", codePosition);

                            // we execute the non query
                            command.ExecuteNonQuery();

                            // we update the stage row in the table stage 
                            query = "UPDATE stage SET nbInscrit_stage += 1 WHERE code_stage = @codeStage;";

                            command.CommandText = query;
                            command.ExecuteNonQuery();

                            if (MessageBox.Show("Inscription enregistrée", "success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                                this.Hide();
                                ListInscritForm listInscritForm = new ListInscritForm();
                                listInscritForm.Controls["typeStageTb"].Text = typeStageTb.Text;
                                listInscritForm.Controls["dateDebutTB"].Text = dateDebutTB.Text;
                                listInscritForm.Controls["dateFinTB"].Text = dateFinTB.Text;
                                listInscritForm.codeStage = this.codeStage;
                                listInscritForm.Show();
                            }
                        }
                    }
                }
                else {
                    if (hasBlancs())
                        MessageBox.Show("Renseignez nom et prénom SVP!!");
                    else if (nullStatus())
                        MessageBox.Show("renseignez un statu SVP!!");
                    else if (isNotDoneYet())
                        MessageBox.Show("Stage précédent non terminé");
                    else if (doesntHaveDegree())
                        MessageBox.Show("Diplôme incompatible avec le stage");
                    else if (plusDe3())
                        MessageBox.Show("Pas plus de 3 Stages");
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
