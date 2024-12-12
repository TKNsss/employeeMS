using System;
using System.Windows.Forms;

namespace employeeMS
{
    public partial class DashboardForm : UserControl
    {
        private EmployeeDAO emDAO = new EmployeeDAO();
        public DashboardForm()
        {
            InitializeComponent();
       
            totalEm.Text = emDAO.DisplayTotalEmployee().ToString();
            totalStaff.Text = emDAO.DisplayTotalRoleMember("Staff").ToString();
            totalLeader.Text = emDAO.DisplayTotalRoleMember("Leader").ToString();           
        }

        public void ReloadData()
        {
            totalEm.Text = emDAO.DisplayTotalEmployee().ToString();
            totalStaff.Text = emDAO.DisplayTotalRoleMember("Staff").ToString();
            totalLeader.Text = emDAO.DisplayTotalRoleMember("Leader").ToString();
        }
    }
}
