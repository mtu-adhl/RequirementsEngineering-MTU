using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    public partial class frmSchedule : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams = frmMainMenu.AllTeams;
        private static bool scheduleExists = false;

        public frmSchedule(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            foreach (Team team in allTeams)
            {
                dtgTeamDetails.Rows.Add(team.TeamID, team.TeamName, team.Gm, team.HeadCoach, team.AsstCoach, team.HomeCourt);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!scheduleExists) {
                DialogResult cfm = MessageBox.Show("Proceed with these Teams?", "Teams Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cfm == DialogResult.Yes)
                {
                    MessageBox.Show("Schedule has been auto-generated by algorithm.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    scheduleExists = true;
                }
            }else
            {
                MessageBox.Show("A Schedule has already been generated, go to [Reschedule Game] to reschedule a specific Game, or [Admin]>[View Schedule] to view the generated Schedule.", "Schedule Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
