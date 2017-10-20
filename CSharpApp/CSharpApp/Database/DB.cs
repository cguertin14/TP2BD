using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpApp.Database.Models;
using System.Configuration;
using System.Data;

namespace CSharpApp.Database
{
    public sealed class DB
    {
        private static readonly DB instance = new DB();
        public  static SqlConnection Connection { get; set; }

        private DB() {}

        public static void Initialize()
        {
            try
            {
                Connection = new SqlConnection("data source = .\\SQLEXPRESS; Initial Catalog = CharlesGuertinStageBd;" +
                                               "User Id = CharlesGuertinStage; password = Charles14");
                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #region Raw Queries
        public static void getEntreprises(ComboBox cmb)
        {
            try
            {
                fillCombobox("Select * From ENTREPRISES", cmb,1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void getStages(ComboBox cmb)
        {
            try
            {
                fillCombobox("Select * From STAGES", cmb,1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void getSuperviseurs(ComboBox cmb)
        {
            try
            {
                fillCombobox("Select * From SUPERVISEURS", cmb,2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void getMoniteurs(ComboBox cmb)
        {
            try
            {
                fillCombobox("Select * From MONITEURS", cmb,2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void getStagiaires(ComboBox cmb)
        {
            try
            {
                fillCombobox("Select * From STAGIAIRES", cmb,2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Stored Procedures

        public static void addStage(Stage stage)
        {
            try
            {
                #region Create command
                SqlCommand command = new SqlCommand("ADDSTAGE", Connection);
                command.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Create parameters
                SqlParameter pdescription = new SqlParameter("@PDESCRIPTION", SqlDbType.Text);
                pdescription.Direction = ParameterDirection.Input;
                pdescription.Value = stage.Description;

                SqlParameter ptypestg = new SqlParameter("@PTYPESTG", SqlDbType.VarChar, 255);
                ptypestg.Direction = ParameterDirection.Input;
                ptypestg.Value = stage.TypeStg;

                SqlParameter plangages = new SqlParameter("@PLANGAGES", SqlDbType.VarChar, 255);
                plangages.Direction = ParameterDirection.Input;
                plangages.Value = stage.Langages;

                SqlParameter pplateforme = new SqlParameter("@PPLATEFORME", SqlDbType.VarChar, 255);
                pplateforme.Direction = ParameterDirection.Input;
                pplateforme.Value = stage.Plateformes;

                SqlParameter pnument = new SqlParameter("@PNUMENT", SqlDbType.Int);
                pnument.Direction = ParameterDirection.Input;
                pnument.Value = stage.NumEnt;

                SqlParameter pnumtr = new SqlParameter("@PNUMTR", SqlDbType.Int);
                pnumtr.Direction = ParameterDirection.Input;
                pnumtr.Value = stage.NumTr;

                SqlParameter pnumad = new SqlParameter("@PNUMAD", SqlDbType.Int);
                pnumad.Direction = ParameterDirection.Input;
                pnumad.Value = stage.NumAd;

                #endregion

                #region Add parameters to command
                command.Parameters.Add(pdescription);
                command.Parameters.Add(ptypestg);
                command.Parameters.Add(plangages);
                command.Parameters.Add(pplateforme);
                command.Parameters.Add(pnument);
                command.Parameters.Add(pnumtr);
                command.Parameters.Add(pnumad);
                #endregion

                #region Execute procedure
                command.ExecuteNonQuery();
                #endregion

                // Notify User of insertion in database
                MessageBox.Show("Stage créé!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                // Notify User of insertion failure in database
                MessageBox.Show("Le stage n'a pas pu être créé, vérifiez que vos entrées soient valides.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deleteStage(Stage stage)
        {
            try
            {
                #region Create command
                SqlCommand command = new SqlCommand("DELETESTAGE", Connection);
                command.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Create parameters
                SqlParameter pnumstage = new SqlParameter("@PNUMSTAGE", SqlDbType.Int);
                pnumstage.Direction = ParameterDirection.Input;
                pnumstage.Value = stage.NumStage;
                #endregion

                #region Add parameters to command
                command.Parameters.Add(pnumstage);
                #endregion

                #region Execute procedure
                command.ExecuteNonQuery();
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void getStagesFromEntreprise(string noment,DataGridView dgv)
        {
            try
            {            
                #region Create command
                SqlCommand command = new SqlCommand("GETSTAGESFROMENTREPRISE",Connection);
                command.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Create parameter
                SqlParameter pnoment = new SqlParameter("@PNOMENT", SqlDbType.VarChar, 255);
                pnoment.Direction = ParameterDirection.Input;
                pnoment.Value = noment;
                #endregion

                #region Add parameter to command
                command.Parameters.Add(pnoment);
                #endregion

                #region Fill data into DGV
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                BindingSource source = new BindingSource(dt, dt.TableName);
                dgv.DataSource = source;
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void getStagesDGV(DataGridView dgv)
        {
            try
            {
                List<ComboBoxItem> toAppend = new List<ComboBoxItem>();
                #region Create command
                SqlCommand command = new SqlCommand("GETEVERYSTAGES", Connection);
                command.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Fill data into DGV
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                BindingSource source = new BindingSource(dt, dt.TableName);
                dgv.DataSource = source;
                dgv.Columns[0].Visible = false;
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void updateDescription(Stage stage)
        {
            try
            {
                #region Create command
                SqlCommand command = new SqlCommand("UPDATEDESCRIPTION", Connection);
                command.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Create parameters
                SqlParameter pnumstage = new SqlParameter("@PNUMSTAGE", SqlDbType.Int);
                pnumstage.Direction = ParameterDirection.Input;
                pnumstage.Value = stage.NumStage;

                SqlParameter pdescription = new SqlParameter("@PDESCRIPTION", SqlDbType.Text);
                pdescription.Direction = ParameterDirection.Input;
                pdescription.Value = stage.Description;
                #endregion

                #region Add parameters to command
                command.Parameters.Add(pnumstage);
                command.Parameters.Add(pdescription);
                #endregion

                #region Execute procedure
                command.ExecuteNonQuery();
                #endregion

                MessageBox.Show("Description modifiée!","Succès",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                // Notify User of insertion failure in database
                MessageBox.Show("La description n'a pas pu être modifiée, vérifiez que votre entrée soit valide.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        public static void getMoniteursFromEntreprise(ComboBox cmb,int nument)
        {
            try
            {
                #region Create command
                SqlCommand command = new SqlCommand("GETMONITEURSFROMENTREPRISE", Connection);
                command.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Create parameters
                SqlParameter pnumstage = new SqlParameter("@PNUMENT", SqlDbType.Int);
                pnumstage.Direction = ParameterDirection.Input;
                pnumstage.Value = nument;
                #endregion

                #region Add parameters to command
                command.Parameters.Add(pnumstage);
                #endregion

                #region Execute procedure and put data into combobox
                using (var reader = command.ExecuteReader())
                {
                    cmb.Items.Clear();
                    while (reader.Read())
                        cmb.Items.Add(new ComboBoxItem(reader[1].ToString() + " " + reader[2].ToString(), reader[0].ToString()));
                    cmb.SelectedIndex = 0;
                    reader.Close();
                }
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Stored Functions

        public static void getEtudiants(DataGridView dgv)
        {
            try
            {
                #region Create command
                SqlCommand command = new SqlCommand("Select * from GETETUDIANTS()", Connection);
                command.CommandType = CommandType.Text;
                #endregion

                #region Fill data into DGV
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                BindingSource source = new BindingSource(dt,dt.TableName);
                dgv.DataSource = source;
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static int getNbStagesByEntreprise(int nument)
        {
            try
            {
                #region Create command
                SqlCommand command = new SqlCommand("select dbo.GETNBSTAGESBYENTREPRISE(@PNUMENT)", Connection);
                command.CommandType = CommandType.Text;
                #endregion

                #region Create parameters
                SqlParameter pnument = new SqlParameter("@PNUMENT", SqlDbType.Int);
                pnument.Direction = ParameterDirection.Input;
                pnument.Value = nument;
                #endregion

                #region Add parameters to command
                command.Parameters.Add(pnument);
                #endregion
                #region Return result of query
                return Int32.Parse(command.ExecuteScalar().ToString());
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                // -1 for an error
                return -1;
            }
        }

        #endregion

        #region ComboBox data utility
        private static void fillCombobox(string query, ComboBox cmb, int nbItems)
        {
            try
            {
                List<ComboBoxItem> toAppend = new List<ComboBoxItem>();
                #region Create command
                SqlCommand command = new SqlCommand(query, Connection);
                command.CommandType = CommandType.Text;
                #endregion
                #region Fill data into list
                using (var reader = command.ExecuteReader())
                {
                    string result = "";
                    while (reader.Read())
                    {
                        for (int i = 1; i <= nbItems; ++i)
                            result += (i > 1 ? " " + reader[i] : reader[i]);
                        toAppend.Add(new ComboBoxItem(result, reader[0].ToString()));
                        result = "";
                    }
                    reader.Close();
                }
                foreach (ComboBoxItem cmbItem in toAppend)
                    cmb.Items.Add(cmbItem);
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
    }
}