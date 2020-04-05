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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //mediaGrid.ItemsSource =null;
            //ModifyMedia.Foreground = Brushes.Blue//;
            mediaGrid.ItemsSource = Library.AllMedia;
            libraryMembersGrid.ItemsSource = Library.allLibraryMember;
        }
        public void RefreshDataGrid()
        {
            libraryMembersGrid.ItemsSource = null;
            libraryMembersGrid.ItemsSource = Library.allLibraryMember;

            mediaGrid.ItemsSource = null;
            mediaGrid.ItemsSource = Library.AllMedia;
        }






        private void MediaInfo_Click(object sender, RoutedEventArgs e)
        {
            if (mediaGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a Media to view more detailed Info.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var message = ((Media)mediaGrid.SelectedItem).MediaInfo();
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MemberInfo_Click(object sender, RoutedEventArgs e)
        {
            if (libraryMembersGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a Member to view more detailed Info.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var message = ((LibraryMember)libraryMembersGrid.SelectedItem).MemberInfo();
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ModifyMember_Click(object sender, RoutedEventArgs e)
        {
            ModifyMemberPage modifyMemberPage;
            if (((LibraryMember)libraryMembersGrid.SelectedItem) != null)
            {
                modifyMemberPage = new ModifyMemberPage((LibraryMember)(libraryMembersGrid.SelectedItem), this.Content);
                this.Content = modifyMemberPage;
            }
            else
            {
                MessageBox.Show("Please select a Member to  change  their Info.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void ModifyMedia_Click(object sender, RoutedEventArgs e)
        {
            ModifyMediaPage modifyMediaPage;
            if (((Media)mediaGrid.SelectedItem) != null)
            {
                modifyMediaPage = new ModifyMediaPage((Media)(mediaGrid.SelectedItem), this.Content);
                this.Content = modifyMediaPage;
            }
            else
            {
                MessageBox.Show("Please select a library item to  change  their Info.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }
        private void LendMedia_Click(object sender, RoutedEventArgs e)
        {
            Media selectedMedia = (Media)mediaGrid.SelectedItem;
            if ((mediaGrid.SelectedItem == null) || (libraryMembersGrid.SelectedItem == null))
            {
                MessageBox.Show("Make sure to select one member and one media that is lenting.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!selectedMedia.IsBorrowed)
            {
                MessageBox.Show("'" + selectedMedia.Title + "' is currently unavailable.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var media = selectedMedia;
                var member = ((LibraryMember)libraryMembersGrid.SelectedItem);
                var name = member.Name;
                media.LentMedia(name);
                member.AddMediaToHistory(media);
                member.AddMediaToBorrowedList(media);
                MessageBox.Show("'" + selectedMedia.Title + "' is Lent to " + member.Name, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            RefreshDataGrid();
        }
        private void ReturnMedia_Click(object sender, RoutedEventArgs e)
        {
            Media selectedMedia = (Media)mediaGrid.SelectedItem;
            if (mediaGrid.SelectedItem == null)
            {
                MessageBox.Show("Make sure to select one media to return it back .", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                var media = selectedMedia;
                var member = Library.allLibraryMember.Find(x => x.Name == selectedMedia.NameOfBorrower);
                if (!media.IsBorrowed)
                {
                    media.ReturnMedia();
                    member.RemoveMediaFromBorrowedList(media);
                    MessageBox.Show("'" + media.Title + "' is returned by " + member.Name, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("'" + media.Title + "' is currently in the Library.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            RefreshDataGrid();
        }
    }
}
