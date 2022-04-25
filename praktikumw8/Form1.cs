using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikumw8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league";   
            public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
            public MySqlCommand sqlCommand;
            public MySqlDataAdapter sqlAdapter;
            string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "SELECT team_id as `team_id`, team_name as `team_name` from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable isiData = new DataTable();
            sqlAdapter.Fill(isiData);
            comboBox1.DataSource = isiData;
            comboBox1.DisplayMember = "team_name";
            comboBox1.ValueMember = "team_id";

            sqlQuery = "SELECT team_id as `team_id`, team_name as `team_name` from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable isiData2 = new DataTable();
            sqlAdapter.Fill(isiData2);
            comboBox2.DataSource = isiData2;
            comboBox2.DisplayMember = "team_name";
            comboBox2.ValueMember = "team_id";
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT m.manager_name as `manager_name`, t.team_id as `team_id`, team_name as `team_name` , t.manager_id as `manager_id` , captain_id as `captain_id` , home_stadium as `home_stadium` , capacity as `capacity` , p.player_name as `player_name` FROM manager m, team t, player p where m.manager_id = t.manager_id and p.player_id = t.captain_id and t.team_id = '" + comboBox1.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable isiData3 = new DataTable();
                sqlAdapter.Fill(isiData3);
                labelOutputManager1.Text = isiData3.Rows[0]["manager_name"].ToString();
                labelOutputCaptain1.Text = isiData3.Rows[0]["player_name"].ToString();
                labelIsiStadium.Text = isiData3.Rows[0]["home_stadium"].ToString();
                labelIsiCapacity.Text = isiData3.Rows[0]["capacity"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void labelOutputManager1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT m.manager_name as `manager_name`, t.team_id as `team_id`, team_name as `team_name` , t.manager_id as `manager_id` , captain_id as `captain_id` , home_stadium as `home_stadium` , capacity as `capacity` , p.player_name as `player_name` FROM manager m, team t, player p where m.manager_id = t.manager_id and p.player_id = t.captain_id and t.team_id = '" + comboBox2.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable isiData4 = new DataTable();
                sqlAdapter.Fill(isiData4);
                labelOutputManager2.Text = isiData4.Rows[0]["manager_name"].ToString();
                labelOutputCaptain2.Text = isiData4.Rows[0]["player_name"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sqlQuery = "select date_format(m.match_date, \"%e %M %Y\") as Tanggal, concat(m.goal_home, ' - ', m.goal_away) as Skor from `match` m where m.team_home = '" + comboBox1.SelectedValue.ToString() + "' and m.team_away = '" + comboBox2.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable TanggalnSkor = new DataTable();
            sqlAdapter.Fill(TanggalnSkor);
            labelOutputTanggal.Text = TanggalnSkor.Rows[0]["Tanggal"].ToString();
            labelOutputSkor.Text = TanggalnSkor.Rows[0]["Skor"].ToString();



            //detail pertandingan
            sqlQuery = "select d.minute as Minute, if(p.team_id != m.team_home, '', p.player_name) as 'Player Name 1', if(p.team_id != m.team_home, '', if(d.type = 'CY', 'Yellow Card', if(d.type = 'CR', 'Red Card', if(d.type = 'GO', 'Goal', if(d.type = 'GP', 'Goal Penalty', if(d.type = 'GW', 'Own Goal', if(d.type = 'PM', 'Penalty Miss', ''))))))) as 'Tipe 1', if(p.team_id != m.team_away, '', p.player_name) as 'Player Name 2', if(p.team_id != m.team_away, '', if(d.type = 'CY', 'Yellow Card', if(d.type = 'CR', 'Red Card', if(d.type = 'GO', 'Goal', if(d.type = 'GP', 'Goal Penalty', if(d.type = 'GW', 'Own Goal', if(d.type = 'PM', 'Penalty Miss', ''))))))) as 'Tipe 2'  from dmatch d, player p, `match` m where d.match_id = m.match_id and p.player_id = d.player_id and m.team_home = '" + comboBox1.SelectedValue.ToString() + "' and m.team_away = '" + comboBox2.SelectedValue.ToString() + "' order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable datagrid = new DataTable();
            sqlAdapter.Fill(datagrid);
            dataGridView1.DataSource = datagrid;

  
     
        }
    }
}

