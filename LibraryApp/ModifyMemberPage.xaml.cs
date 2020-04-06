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

namespace LibraryApp
{
    /// <summary>
    /// Interaction logic for ModifyMemberPage.xaml
    /// </summary>
    public partial class ModifyMemberPage : Page
    {
        #region Class Veriables
        LibraryMember toModify;
        object previouscontent;
        #endregion
        #region construtor
        public ModifyMemberPage(LibraryMember _toModify, object _previousContent)
        {
            InitializeComponent();
            toModify = _toModify;
            previouscontent = _previousContent;
            SetInitialValues();
        }
        #endregion
        #region Private Methods
        private void SetInitialValues()
        {
            fullNameBox.Text = toModify.Name;
        }
        private void SubmitRecord_Click(object sender, RoutedEventArgs e)
        {
            toModify.ModifyField(fullNameBox.Text);
            ((MainWindow)(Application.Current.MainWindow)).RefreshDataGrid();
            Application.Current.MainWindow.Content = previouscontent;
        }
        #endregion
    }
}
