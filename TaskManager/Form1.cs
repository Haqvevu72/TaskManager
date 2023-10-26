using System.ComponentModel;
using System.Diagnostics;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            InitializeSchedule();
        }

        public void InitializeSchedule()
        {
            List<T_Manager> ProcessList = new List<T_Manager>();
            var _processlist = Process.GetProcesses();
            for (int i = 0; i < _processlist.Length; i++)
            {
                ProcessList.Add(new T_Manager() { processName = _processlist[i].ProcessName, processID = _processlist[i].Id });
            }
            list_processes.DataSource = ProcessList;
        }

        private void btn_addprocess_Click(object sender, EventArgs e)
        {
            Process.Start(txtbox_processname.Text);
            InitializeSchedule();
        }

        private void btn_removeprocess_Click(object sender, EventArgs e)
        {
            foreach (var item in Process.GetProcessesByName(txtbox_processname.Text))
            {
                item.Kill();
            }
            InitializeSchedule();
        }






















    }
}