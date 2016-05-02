using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using System.Net;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using TunablesEditorCode.Enumeration;
using TunablesEditorCode.Classes;

namespace TunablesEditorCode
{
    public partial class Main : Form
    {
        public PS3API PS3 = new PS3API();

        private TE_Region region;
        private TE_API api;

        //list of tunable objects
        private List<Tunable> dasTunablesList = new List<Tunable>();

        Tunable dasSelectedTunable;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("tunables.json"))
            {
                MessageBox.Show(@"Unable to find file 'tunables.json' in program directory.\n
                Please download again and extract all contents to the same folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            string[] contents = File.ReadAllLines("tunables.json");
            foreach (string tunable in contents)
            {
                //load contents into tunable object
                Tunable t_obj = JsonConvert.DeserializeObject<Tunable>(tunable);
                dasTunablesList.Add(t_obj);
                //load into listbox
                dasTunables.Items.Add(t_obj.name);
            }

            SetMessage(string.Format("Successfully loaded {0} tunables.", dasTunablesList.Count));

            region = TE_Region.BLES;
            ConnectToPS3.Enabled = true;
        }

        void controls(bool value)
        {
            dasSearch.Enabled = value;
            tunableValue.Enabled = value;
            pokeTunable.Enabled = value;
            dasTunables.Enabled = value;
        }
        private void SetMessage(string msg)
        {
            MessagesLabel.Text = msg;
        }

        private void AboutOpen_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Manage_Click(object sender, EventArgs e)
        {
            ManageMenu.Show(Manage, 0, Manage.Height);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            /*
            region = TE_Region.BLUS;
            SelectBLUS.Image = Properties.Resources.Done16x;
            SelectBLES.Image = null;
            ConnectToPS3.Enabled = true;
            SetMessage("Set region to BLUS.");
             */
        }

        private void SelectBLES_Click(object sender, EventArgs e)
        {

        }

        private void cCAPICEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                PS3.ConnectTarget(0);
                PS3.AttachProcess();
                Globals.CurrentAddress = (region == TE_Region.BLES) ? PS3.Extension.ReadUInt32(Globals.BLES) + 4 : PS3.Extension.ReadUInt32(Globals.BLUS) + 4;
                SetMessage(string.Format("Successfully connected using CCAPI. Tunable address: {0}", Globals.CurrentAddress.ToString("X")));
                CCAPIConnect.Image = Properties.Resources.Done16x;
                TMAPIConnect.Image = null;
                controls(true);
            }
            catch
            {
                SetMessage("An error occurred when trying to establish a connection.");
            }
        }

        private void TMAPIConnect_Click(object sender, EventArgs e)
        {
            try
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                PS3.ConnectTarget(0);
                PS3.AttachProcess();
                Globals.CurrentAddress = (region == TE_Region.BLES) ? PS3.Extension.ReadUInt32(Globals.BLES) + 4 : PS3.Extension.ReadUInt32(Globals.BLUS) + 4;
                api = TE_API.TMAPI;
                SetMessage(string.Format("Successfully connected using TMAPI. Tunable address: {0}", Globals.CurrentAddress.ToString("X")));
                TMAPIConnect.Image = Properties.Resources.Done16x;
                CCAPIConnect.Image = null;
                controls(true);
            }
            catch
            {
                SetMessage("An error occurred when trying to establish a connection.");
            }
        }
        private void pokeTunable_Click(object sender, EventArgs e)
        {
            //pretty messy
            if (dasSelectedTunable.type == "int")
                if (Tunable.Poke(dasSelectedTunable, Convert.ToInt32(tunableValue.Text), PS3))
                    SetMessage(string.Format("Successfully set index {0} to {1}", dasSelectedTunable.index, tunableValue.Text));
                else
                    SetMessage(string.Format("Failed to set {0}", dasSelectedTunable.name));
            else
                if (Tunable.Poke(dasSelectedTunable, Convert.ToSingle(tunableValue.Text), PS3))
                    SetMessage(string.Format("Successfully set index {0} to {1}", dasSelectedTunable.index, tunableValue.Text));
                else
                    SetMessage(string.Format("Failed to set {0}", dasSelectedTunable.name));
        }

        private void dasTunables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dasTunables.SelectedIndex == -1)
                return;

            string selected_tunable = dasTunables.Items[dasTunables.SelectedIndex].ToString();

            if (selected_tunable.Length > 45)
                selected_tunable = selected_tunable.Substring(0, 44);

            label1.Text = string.Format("Selected: {0}", selected_tunable);
            currentTunable.Text = string.Format("Edit {0}", selected_tunable);

            dasSelectedTunable = dasTunablesList[dasTunables.SelectedIndex];
            if (dasSelectedTunable.type == "int")
            {
                int memory = PS3.Extension.ReadInt32(Globals.CurrentAddress + ((uint)dasSelectedTunable.index * 4));
                Clipboard.SetText((Globals.CurrentAddress + ((uint)dasSelectedTunable.index * 4)).ToString());
                tunableValue.Text = memory.ToString();
            }
            else
            {
                float memory = PS3.Extension.ReadFloat(Globals.CurrentAddress + ((uint)dasSelectedTunable.index * 4));
                tunableValue.Text =memory.ToString();
            }
        }

        private void dasSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = dasSearch.Text;
            if (search.Length == 0)
            {
                dasTunables.SetSelected(0, false);
                return;
            }
            for (int i = 0; i < dasTunables.Items.Count; i++)
            {
                if (dasTunables.Items[i].ToString().ToLower().Contains(search))
                {
                    dasTunables.SetSelected(i, true);
                    return;
                }
            }
        }

        private void RegionMenu_Click(object sender, EventArgs e)
        {

        }
    }
}