using BusinessLayer_EF;
using EFGetStarted;
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

namespace WPFview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CrudManager _crudManager = new CrudManager();
        public MainWindow()
        {
            InitializeComponent();
            PopulateBlogBox();
        }

        public void PopulateBlogBox()
        {
            ListBoxBlogs.ItemsSource = _crudManager.ReadAllBlogs();
        }

        public void PopulatePostBox()
        {
            if (_crudManager.selectedBlog != null)
            {
                ListBoxPosts.ItemsSource = _crudManager.ReadAllPosts(_crudManager.selectedBlog.BlogId);
            }
        }

        public void PopulateBlogFields()
        {
            if(_crudManager.selectedBlog != null)
            {
                BlogId.Text = _crudManager.selectedBlog.BlogId.ToString();
                BlogAuthorField.Text = _crudManager.selectedBlog.Author;
                BlogUrl.Text = _crudManager.selectedBlog.Url;
            }
        }

        public void PopulatePostFields()
        {
            if(_crudManager.selectedPost != null)
            {
                TextpostTitle.Text = _crudManager.selectedPost.Title;
                TextpostContent.Text = _crudManager.selectedPost.Content;
                TextpostAuthor.Text = _crudManager.selectedBlog.Author;
            }
        }

        public void CreateNewBlog(string url, string author)
        {
            _crudManager.CreateBlog(url, author);
            PopulateBlogBox();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddBlog addBlog = new AddBlog();
            addBlog.Show();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if(_crudManager.selectedBlog != null)
            {
                _crudManager.DeleteABlog(_crudManager.selectedBlog.BlogId);
                PopulateBlogBox();
            }
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (_crudManager.selectedBlog != null)
            {
                _crudManager.UpdateABlog(_crudManager.selectedBlog.BlogId, BlogUrl.Text, BlogAuthorField.Text);
                PopulateBlogFields();
            }
        }

        private void ButtonUpdatePost_Click(object sender, RoutedEventArgs e)
        {
            if(_crudManager.selectedPost != null)
            {
                _crudManager.UpdateAPost(_crudManager.selectedPost.PostId, TextpostTitle.Text, TextpostContent.Text);
                PopulatePostFields();
            }
        }

        private void ListBoxBlogs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBoxBlogs.SelectedItem != null)
            {
                _crudManager.SetSelectedBlog(ListBoxBlogs.SelectedItem);
                PopulateBlogFields();
                PopulatePostBox();
            }
        }

        private void ListBoxPosts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBoxPosts.SelectedItem != null)
            {
                _crudManager.setSelectedPost(ListBoxPosts.SelectedItem);
                PopulatePostFields();
            }
        }
    }
}
