using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace GestionStageTP {
    public partial class NewStagaireForm : Form {
        public NewStagaireForm() {
            InitializeComponent();
        }
        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder() {
            DataSource = ".",
            InitialCatalog = "BdStage00",
            IntegratedSecurity = true
        };
        public int codeStage;
        public Dictionary<String, String> dico = new Dictionary<string, string>();

        private void mouseClickTB(object sender, MouseEventArgs e) {

        }

        private void retourDebutBTN_Click(object sender, EventArgs e) {
            GestionDesStages gestionDesStages = new GestionDesStages();
            this.Hide();
            gestionDesStages.Show();
        }

        private void retourInscriptionBTN_Click(object sender, EventArgs e) {
            back2Inscription();
        }
        //method to get back to the inscription form 
        private void back2Inscription() {
            try {
                InscriptionStageForm inscriptionForm = new InscriptionStageForm();

                // we fetch the data we stored in the dico....
                foreach (var pair in dico)
                    inscriptionForm.Controls[pair.Key].Text = pair.Value;
                inscriptionForm.codeStage = this.codeStage;
                this.Hide();
                inscriptionForm.Show();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        // method that generates the id for a new "stagaire"
        private int generateID() {
            int newID = 0;
            // isntantiating a new connection 
            using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                // instantiating a new command
                using (SqlCommand command = new SqlCommand()) {
                    // passing the command arguments
                    String query = "SELECT TOP 1 (ROW_NUMBER() OVER(ORDER BY num_stagaire)) AS 'rn' " +
                        "FROM stagaire ORDER BY rn DESC";
                    command.CommandText = query;
                    command.Connection = connection;
                    connection.Open();

                    newID = Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
            return newID;
        }
        private void ajouterStagaireBTN_Click(object sender, EventArgs e) {
            try {
                if (nomTB.Text == "" || prenomTB.Text == "")
                    MessageBox.Show("Renseignez nom et prénom SVP");
                else if (anneeNaissanceTB.Text == "")
                    MessageBox.Show("Renseignez une annee de naissance SVP");
                else if (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(anneeNaissanceTB.Text) < 18)
                    MessageBox.Show("annee de naissance non valid!!");
                else if (diplomeTB.Text == "")
                    MessageBox.Show("Renseigner Diplôme SVP !!");
                else if (!(new[] { "BAC", "BEP", "CAP" }.Contains(diplomeTB.Text.ToUpper())))
                    MessageBox.Show("diplome non valid!!");
                else if (hommeRBTN.Checked == false && femmeRBTN.Checked == false)
                    MessageBox.Show("choisir votre sex SVP!!");

                else {
                    try {
                        // instantiating a new connection
                        using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                            // instantiating a new adapter
                            String query = "SELECT * FROM stagaire";
                            connection.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection)) {
                                // instantiating a new command builder 
                                using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter)) {
                                    // instantiating a new command
                                    using (SqlCommand command = builder.GetInsertCommand(true)) {
                                        command.Parameters.Clear();
                                        // stagaire id parameters
                                        command.Parameters.AddWithValue("num_stagaire", generateID());
                                        command.Parameters.AddWithValue("nom_stagaire", nomTB.Text.ToLower());
                                        command.Parameters.AddWithValue("prenom_stagaire", prenomTB.Text.ToLower());
                                        command.Parameters.AddWithValue("sexe_stagaire", hommeRBTN.Checked ? "H" : "F");
                                        command.Parameters.AddWithValue("dnaiss_stagaire", "01-01-" + anneeNaissanceTB.Text);
                                        command.Parameters.AddWithValue("diplo_stagaire", diplomeTB.Text.ToUpper());
                                        // executing the command
                                        command.ExecuteNonQuery();

                                        // success message
                                        MessageBox.Show("Stagaire added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // back to the inscription form
                                        back2Inscription();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex) {
                        Debug.WriteLine(ex.ToString());
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void NewStagaireForm_Load(object sender, EventArgs e) {
            nomTB.Select();
            nomTB.Focus();
        }
    }
}
