using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GestionStageTP {
    public partial class GestionDesStages : Form {
        public GestionDesStages() {
            InitializeComponent();
        }
        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder() {
            DataSource = ".",
            InitialCatalog = "BdStage00",
            IntegratedSecurity = true
        };
        String query;
        private void GestionDesStages_Load(object sender, EventArgs e) {
            query = "SELECT code_stage AS 'NOSTA', type_stage AS 'TYPSTA', nbInscrit_stage AS 'NBINS'," +
                " debut_stage AS 'DATEDEB', fin_stage AS 'DATFIN' FROM stage " +
                " WHERE debut_stage >= GETDATE()" +
                " ORDER BY debut_stage";
            loadData(query);
        }
        protected void loadData(String query) {
            try {
                // instantiating a new connection
                using (SqlConnection connection = new SqlConnection(connectionString.ToString())) {
                    // instantiating a new command
                    using (SqlCommand command = new SqlCommand()) {
                        // assigning the query
                        command.CommandText = query;
                        // opening and assingning the connetion
                        connection.Open();
                        command.Connection = connection;

                        // instantiating a new reader
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            // filling in a new table using the reader
                            DataTable table = new DataTable();
                            table.Load(reader);

                            // linking the table and our dgv
                            dgv.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void SortByTypeBtn_Click(object sender, EventArgs e) {
            try {
                // loading data
                query = "SELECT code_stage AS 'NOSTA', type_stage AS 'TYPSTA', nbInscrit_stage AS 'NBINS'," +
                    " debut_stage AS 'DATEDEB', fin_stage AS 'DATFIN' FROM stage ORDER BY type_stage";
                loadData(query);
                // switching colors
                SortByDateBtn.BackColor = Color.White;
                SortByTypeBtn.BackColor = Color.FromArgb(224, 224, 224);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }

        }

        private void SortByDateBtn_Click(object sender, EventArgs e) {
            try {
                // loading data
                query = "SELECT code_stage AS 'NOSTA', type_stage AS 'TYPSTA', nbInscrit_stage AS 'NBINS'," +
                    " debut_stage AS 'DATEDEB', fin_stage AS 'DATFIN' FROM stage ORDER BY debut_stage";
                loadData(query);
                // switchig colors
                SortByTypeBtn.BackColor = Color.White;
                SortByDateBtn.BackColor = Color.FromArgb(224, 224, 224);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }

        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e) {
            try {
                // dealing with non aviliable "stages"
                if (DateTime.Compare((DateTime)dgv.CurrentRow.Cells["DATEDEB"].Value, DateTime.Now) <= 0) {
                    MessageBox.Show("Plus d'Inscription pour ce stage!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    // opening a new form and passing data 
                    ListInscritForm listInscritForm = new ListInscritForm();
                    listInscritForm.Controls["typeStageTb"].Text = dgv.CurrentRow.Cells["TYPSTA"].Value.ToString();
                    listInscritForm.Controls["dateDebutTB"].Text = ((DateTime)dgv.CurrentRow.Cells["DATEDEB"].Value).ToShortDateString();
                    listInscritForm.Controls["dateFinTB"].Text = ((DateTime)dgv.CurrentRow.Cells["DATFIN"].Value).ToShortDateString();
                    listInscritForm.codeStage = Convert.ToInt32(dgv.CurrentRow.Cells["NOSTA"].Value);
                    // switching forms
                    this.Hide();
                    listInscritForm.Show();
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}
