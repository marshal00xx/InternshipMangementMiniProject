using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace GestionStageTP {
    public partial class ListInscritForm : Form {
        public ListInscritForm() {
            InitializeComponent();
        }
        private enum operations { deleteFromListPrincipale, deleteFromListAttente }
        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder() {
            DataSource = ".",
            InitialCatalog = "BdStage00",
            IntegratedSecurity = true
        };
        public int codeStage;
        private void label2_Click(object sender, EventArgs e) {

        }

        private void ListInscritForm_Load(object sender, EventArgs e) {
            loadData();
        }
        public void loadData() {
            try {
                listPrincipaleLB.Items.Clear();
                listAttenteLB.Items.Clear();
                // instantiating a new connection
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    // instantiating a new command
                    using (SqlCommand command = new SqlCommand()) {
                        connection.Open();
                        command.Connection = connection;
                        // getting the "nbPlace_stage"
                        String query = "SELECT nbPlace_stage FROM stage WHERE code_stage = @codeStage";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@codeStage", codeStage);
                        int nbPlace = Convert.ToInt32(command.ExecuteScalar());
                        // building the main command
                        query = "SELECT nom_stagaire, prenom_stagaire FROM stagaire " +
                            "INNER JOIN inscription ON stagaire.num_stagaire = inscription.num_stagaire " +
                            "INNER JOIN stage ON inscription.code_stage = stage.code_stage " +
                            "WHERE stage.code_stage = @codeStage " +
                            "ORDER BY stagaire.num_stagaire";
                        command.CommandText = query;
                        //instantiating a new data reader
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            // filling in the list box with data
                            String data = "";
                            int counter = 0;
                            while (reader.Read()) {
                                for (int i = 0; i < reader.FieldCount; i++) {
                                    data += reader.GetString(i) + " ";
                                }
                                data.Trim();
                                var action = counter < nbPlace ? listPrincipaleLB.Items.Add(data) : listAttenteLB.Items.Add(data);
                                counter++;
                                data = "";
                            }
                        }
                    }

                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void deleteStagaire(int index, operations operation) {
            /**
             * operation = operations.deleteFromListPrincipale
             *      --> we wanna delete from "listPrincipalLB"
             *      --> we simply delete the "stagaire" using the collected <numStagaire, codeStage>
             *      --> then we update the first item in "listAttente" by changing his "codePosition from 3 to 2 
             *      --> we update "nbInscrit_Stage" by substracting 1
             *      --> we reload the 2 LBs
             *      
             * operation = operations.deleteFromListAttente
             *      --> we wanna delete from the listAttente.deleteFromListAttente
             *      --> we simply delete the item +_+
             *      --> we update "nbInscrit_Stage" by substracting 1
             *      --> we reload the 2 LBs
             * **/
            // instantiating a new connection
            try {
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    int numStagaire = 0;
                    // instantiating a new command
                    using (SqlCommand command = new SqlCommand()) {
                        connection.Open();
                        command.Connection = connection;
                        String query = "SELECT * FROM (SELECT s.num_stagaire, " +
                            "(ROW_NUMBER() OVER(ORDER BY s.num_stagaire)) AS 'rn' FROM stagaire s " +
                            "INNER JOIN inscription i ON s.num_stagaire = i.num_stagaire " +
                            "INNER JOIN stage st ON i.code_stage = st.code_stage " +
                            "WHERE st.code_stage = @codeStage) AS SQ " +
                            "WHERE SQ.rn = @rowNumber";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@codeStage", codeStage);
                        command.Parameters.AddWithValue("@rowNumber", index);

                        // instantiating a new reader 
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            // storing the data in the reader in hashMap<columnName, columnData>
                            while (reader.Read())
                                numStagaire = Convert.ToInt32(reader.GetValue(0));
                        }
                        switch (operation) {
                            case operations.deleteFromListPrincipale:
                                deletePrincipaleCondidat(codeStage, numStagaire);
                                break;
                            case operations.deleteFromListAttente:
                                deleteCondidatLogic(codeStage, numStagaire);
                                break;
                            default:
                                break;
                        }
                        loadData();
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void deleteCondidatLogic(int codeStage, int numStagaire) {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        connection.Open();

                        // we delete the "inscription" using <codeStage, numStagaire>
                        String query = "DELETE FROM inscription " +
                            "WHERE code_stage = @codeStage " +
                            "AND num_stagaire = @numStagaire";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@codeStage", codeStage);
                        command.Parameters.AddWithValue("@numStagaire", numStagaire);
                        command.ExecuteNonQuery();

                        // we update the "stage" table 
                        query = "UPDATE stage " +
                            "SET nbInscrit_stage -= 1 " +
                            "WHERE code_stage = @codeStage";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void deletePrincipaleCondidat(int codeStage, int numStagaire) {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    using (SqlCommand command = new SqlCommand()) {
                        command.Connection = connection;
                        connection.Open();

                        // we delete the "inscription" using <codeStage, numStagaire>
                        deleteCondidatLogic(codeStage, numStagaire);

                        // we update the first element in the listBox
                        String query = "UPDATE inscription" +
                            "SET code_position = 2" +
                            "WHERE code_stage = @codeStage" +
                            "AND num_stagaire = @numStagaire";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@codeStage", codeStage);
                        command.Parameters.AddWithValue("@numStagaire", numStagaire);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private void retourListStageBtn_Click(object sender, EventArgs e) {
            try {
                GestionDesStages gestionDesStages = new GestionDesStages();
                this.Hide();
                gestionDesStages.Show();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void nouvelleInscriptionTB_Click(object sender, EventArgs e) {
            try {
                InscriptionStageForm inscriptionStageForm = new InscriptionStageForm();
                inscriptionStageForm.Controls["typeStageTb"].Text = typeStageTb.Text;
                inscriptionStageForm.Controls["dateDebutTB"].Text = dateDebutTB.Text;
                inscriptionStageForm.Controls["dateFinTB"].Text = dateFinTB.Text;
                inscriptionStageForm.codeStage = this.codeStage;
                this.Hide();
                inscriptionStageForm.Show();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void listItemDblClick(object sender, MouseEventArgs e) {
            ListBox listBox = (ListBox)sender;
            int index = listBox.SelectedIndex + 1;

            if (MessageBox.Show("Voulez vous vraiment supprimer se stagaire?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes) {
                if (listBox.Name == "listPrincipaleLB")
                    deleteStagaire(index, operations.deleteFromListPrincipale);
                else {
                    // we add the numbers of item in the "principal list" to the actual index to get the id of the "stagaire" in the db
                    index += listPrincipaleLB.Items.Count;
                    deleteStagaire(index, operations.deleteFromListAttente);
                }

            }
        }
    }
}
