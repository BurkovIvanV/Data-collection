using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        XmlSerializer formatter = new XmlSerializer(typeof(Data));
        public Data data
        {
            get => new Data
            {
                FullName = fullNameBox.Text,
                Raiting = raitingBox.Text,
                Rank = rankBox.Text,
                BirthDate = birthDateBox.Value,
                Tournamets = listView.Items.Cast<ListViewItem>().Select(x => x.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(y => y.Text).ToArray()).ToArray()
            };
            set
            {
                fullNameBox.Text = value.FullName;
                raitingBox.Text = value.Raiting;
                rankBox.Text = value.Rank;
                birthDateBox.Value = value.BirthDate;
                listView.Items.AddRange(value.Tournamets.Select(x => new ListViewItem(x)).ToArray());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            raitingBox.Mask = "0000";
            birthDateBox.MaxDate = DateTime.Today;
            dateTournamentBox.MaxDate = DateTime.Today;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listView.Items.Add(new ListViewItem(new[] { tournametntNameBox.Text, Convert.ToString(placeBox.Value), Convert.ToString(scoreBox.Value), Convert.ToString(dateTournamentBox.Value) }));
            tournametntNameBox.Clear();
            scoreBox.Value = 1;
            placeBox.Value = 1;
            dateTournamentBox.Value = DateTime.Today;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Items.RemoveAt(listView.SelectedIndices[0]);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Запись не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все несохраненные данные будут утеряны", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.Cancel || openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                data = (Data)formatter.Deserialize(fs);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                formatter.Serialize(fs, data);
            }
        }
    }
}
