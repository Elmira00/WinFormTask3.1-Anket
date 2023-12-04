using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormTask3._1_Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>
            {                 
            };
        
        private void add_Click(object sender, EventArgs e)
        {
            var newUser = new User(nameTxtb.Text, surnameTxtb.Text,
                emailTxtb.Text, phoneMTxtb.Text, birthDateTimePicker.Value, "");
            users.Add( newUser );
            listBox1.Items.Clear();
            listBox1.Items.AddRange(users.ToArray());
            listBox1.DisplayMember = nameof(newUser.Name);
            fileNameTxtb.Text = newUser.Name + ".json";
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {            
            var serializer = new JsonSerializer();
            var selectedUser = new User();
            foreach (var user in users)
            {
                if (user.Name+".json" == fileNameTxtb.Text)
                {
                    selectedUser = user;
                }
            }
            using (var sw = new StreamWriter($"{selectedUser.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, selectedUser);
                }
            }
            MessageBox.Show("Your anket was saved");
            nameTxtb.Text = default;
            surnameTxtb.Text = default;
            emailTxtb.Text = default;
            phoneMTxtb.Text = default;
            birthDateTimePicker.Value=DateTime.Now;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var serializer = new JsonSerializer();
            var selectedUser = new User();
            using (var sr = new StreamReader($"{fileNameTxtb.Text}"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    selectedUser = serializer.Deserialize<User>(jr);
                }                
            }
            nameTxtb.Text = selectedUser.Name;
            surnameTxtb.Text = selectedUser.Surname;
            emailTxtb.Text = selectedUser.Email;
            phoneMTxtb.Text = selectedUser.Phone;
            birthDateTimePicker.Value = selectedUser.BirthDate;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user= (User)listBox1.SelectedItem;
            fileNameTxtb.Text = user.Name + ".json";
        }

        private void change_Click(object sender, EventArgs e)
        {
            add_Click(sender, e);
        }
    }
}
