
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Reporting.WinForms;
using newClass1;
namespace learning_rdlc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// install extension microsoft rdlc report design 
    ///  add package Microsoft.reportingservices.reportviewercontrol.winforms
    ///  add references System.Windows.Forms
    ///  add references System.Windows.FormIntegration
    ///  xmlns:mrv="clr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.Winforms" for the package running
    ///  </summary>
    public partial class MainWindow : Window
    {
        private Student stdnclass = new Student();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnshowrpt_Click(object sender, RoutedEventArgs e)
        {
            if (this.cbSelect.SelectedItem == null)
                return;
            string added = ((ComboBoxItem)(this.cbSelect.SelectedItem)).Tag.ToString();
            this.rptview.LocalReport.ReportPath = added;    //"C:\\Users\\islam\\source\\repos\\learning_rdlc\\learning_rdlc\\Report1.rdlc";
            if (added.Contains("Student Report"))
            {
                this.stdnclass.GetStudents();
                var try1 = this.rptview.LocalReport;
                try1.DataSources.Clear();
                try1.DataSources.Add(new ReportDataSource("DataSet1", this.stdnclass.studentList));
            }

            else if (added.Contains("trial")) {
                this.stdnclass.GetStudents();
                var try1 = this.rptview.LocalReport;
                try1.DataSources.Clear();
                try1.DataSources.Add(new ReportDataSource("DataSet1", this.stdnclass.studentList));
            }
            this.rptview.RefreshReport();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.cbSelect.Items.Count > 0)
                return;
            this.cbSelect.Items.Add(new ComboBoxItem()
            {
                Content = "Trial",
                Tag = @"C:\Users\islam\source\repos\learning_rdlc\learning_rdlc\trial.rdlc"
            });
            this.cbSelect.Items.Add(new ComboBoxItem()
            {
                Content = "Error",
                Tag = @"C:\Users\islam\source\repos\learning_rdlc\learning_rdlc\error.rdlc"
            });
            this.cbSelect.Items.Add(new ComboBoxItem()
            {
                Content = "Random",
                Tag = @"C:\Users\islam\source\repos\learning_rdlc\learning_rdlc\random.rdlc"
            });
            this.cbSelect.Items.Add(new ComboBoxItem()
            {
                Content = "Not So Random",
                Tag = @"C:\Users\islam\source\repos\learning_rdlc\learning_rdlc\notSoRandom.rdlc"
            });
            this.cbSelect.Items.Add(new ComboBoxItem()
            {
                Content = "Student Report",
                Tag = @"C:\Users\islam\source\repos\learning_rdlc\learning_rdlc\Report1.rdlc"
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.stdnclass.GetStudents();
            this.stdndgv1.ItemsSource = this.stdnclass.studentList;
        }
    }
}
