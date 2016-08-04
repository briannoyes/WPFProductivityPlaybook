using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SmartConverters
{
    public class User : INotifyPropertyChanged
    {
        private string _lastName;
        private string _middleName;
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MiddleName"));
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
