using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace SmartConverters
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            User = new User();
            User.PropertyChanged += UserChanged;
            User.FirstName = "Fred";
            User.MiddleName = "Ferdinand";
            User.LastName = "Flintstone";
        }

        private void UserChanged(object sender, PropertyChangedEventArgs e)
        {
            IsDirty = true;
        }

        public User User
        {
            get { return (User)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

        public static readonly DependencyProperty UserProperty =
            DependencyProperty.Register("User", typeof(User), 
                typeof(MainWindow), new PropertyMetadata(null));


        public bool IsDirty
        {
            get { return (bool)GetValue(IsDirtyProperty); }
            set { SetValue(IsDirtyProperty, value); }
        }

        public static readonly DependencyProperty IsDirtyProperty =
            DependencyProperty.Register("IsDirty", typeof(bool), 
                typeof(MainWindow), new PropertyMetadata(false));

        private void OnSave(object sender, RoutedEventArgs e)
        {
            IsDirty = false;
        }
    }
}
