using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSInternal
{
    public partial class SetupSettingsForm : Form
    {
        public SetupSettingsForm()
        {
            InitializeComponent();
            //set enums as dataSources for the comboboxes
            cmbGyroRange.DataSource = Enum.GetValues(typeof(ImuGyroRange));
            cmbGyroODR.DataSource = Enum.GetValues(typeof(ImuGyroRefreshRate));
            cmbAccelRange.DataSource = Enum.GetValues(typeof(ImuAccelRange));
            cmbAccelODR.DataSource = Enum.GetValues(typeof(ImuAccelRefreshRate));
            cmbAntiAliasingBW.DataSource = Enum.GetValues(typeof(AntialiasingFilterBandwidth));

            cmbGyroRange.SelectedIndexChanged += cmbGyroRange_SelectedIndexChanged;
            cmbGyroODR.SelectedIndexChanged += cmbGyroODR_SelectedIndexChanged;
            cmbAccelRange.SelectedIndexChanged += cmbAccelRange_SelectedIndexChanged;
            cmbAccelODR.SelectedIndexChanged += cmbAccelODR_SelectedIndexChanged;
            cmbAntiAliasingBW.SelectedIndexChanged += cmbAntiAliasingBW_SelectedIndexChanged;
            //set the values of the fields to their current values
            cmbGyroRange.SelectedIndex = Properties.Settings.Default.GyroRange;
            cmbGyroODR.SelectedIndex = Properties.Settings.Default.GyroRefreshRate;
            cmbAccelRange.SelectedIndex = Properties.Settings.Default.AccelRange;
            cmbAccelODR.SelectedIndex = Properties.Settings.Default.AccelRefreshrate;
            cmbAntiAliasingBW.SelectedIndex = Properties.Settings.Default.AntiAliasingFilterBandwidth;
            chkAutoAntiAliasing.Checked = Properties.Settings.Default.SetAntiAliasingFilterAutomatically;

            numAccelOffsetX.Value = (decimal)Properties.Settings.Default.AccelOffsetX;
            numAccelOffsetY.Value = (decimal)Properties.Settings.Default.AccelOffsetY;
            numAccelOffsetZ.Value = (decimal)Properties.Settings.Default.AccelOffsetZ;

            numGyroOffsetX.Value = (decimal)Properties.Settings.Default.GyroOffsetX;
            numGyroOffsetY.Value = (decimal)Properties.Settings.Default.GyroOffsetY;
            numGyroOffsetZ.Value = (decimal)Properties.Settings.Default.GyroOffsetZ;
            chkLocalDataStorage.Checked = Properties.Settings.Default.LocalDataStorage;
            txtLocalDataStorage.Text = Properties.Settings.Default.LocalDataStorage? Properties.Settings.Default.LocalDataStoragePath: "";
        }

        private void cmbGyroRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GyroRange = ((ComboBox)sender).SelectedIndex;
        }

        private void cmbGyroODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GyroRefreshRate = ((ComboBox)sender).SelectedIndex;
        }

        private void cmbAccelRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccelRange = ((ComboBox)sender).SelectedIndex;
        }

        private void cmbAccelODR_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccelRefreshrate = ((ComboBox)sender).SelectedIndex;
        }

        private void numGyroOffsetX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GyroOffsetX = (double)((NumericUpDown)sender).Value;
        }

        private void numGyroOffsetY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GyroOffsetY = (double)((NumericUpDown)sender).Value;
        }

        private void numGyroOffsetZ_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GyroOffsetZ = (double)((NumericUpDown)sender).Value;
        }

        private void numAccelOffsetX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccelOffsetX = (double)((NumericUpDown)sender).Value;
        }

        private void numAccelOffsetY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccelOffsetY = (double)((NumericUpDown)sender).Value;
        }

        private void numAccelOffsetZ_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccelOffsetZ = (double)((NumericUpDown)sender).Value;
        }

        private void SetupSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cmbAntiAliasingBW_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AntiAliasingFilterBandwidth = ((ComboBox)sender).SelectedIndex;
        }

        private void chkAutoAntiAliasing_CheckedChanged(object sender, EventArgs e)
        {
            cmbAntiAliasingBW.Enabled = !((CheckBox)sender).Checked;
            Properties.Settings.Default.SetAntiAliasingFilterAutomatically = ((CheckBox)sender).Checked;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }

        private void chkLocalDataStorage_CheckedChanged(object sender, EventArgs e)
        {
            lblPath.Enabled = chkLocalDataStorage.Checked;
            txtLocalDataStorage.Enabled = chkLocalDataStorage.Checked;
            Properties.Settings.Default.LocalDataStorage = chkLocalDataStorage.Checked;
        }

        private void txtLocalDataStorage_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                InitialDirectory = Application.StartupPath,
                Title = "Select where to save the data",
                FileName = "data.csv",
                Filter = "Comma-separated values |*.csv",
                AddExtension = true,
                //CheckFileExists = true,

            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtLocalDataStorage.Text = sfd.FileName;
                Properties.Settings.Default.LocalDataStoragePath = sfd.FileName;
            }
            Select();
        }
        private void btnSheetsSetup_Click(object sender, EventArgs e)
        {
            if (File.Exists("token.json")) File.Delete("token.json");
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, new string[] { SheetsService.Scope.Spreadsheets }, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }
        }
    }
}
