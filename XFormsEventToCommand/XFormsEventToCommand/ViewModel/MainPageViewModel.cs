using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XFormsEventToCommand.Model;

namespace XFormsEventToCommand.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; private set; }

        public ICommand OutputAgeCommand { get; private set; }

        public string SelectedItemText { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            People = new ObservableCollection<Person> {
                new Person() {Name = "Marco", Surname = "Panzeri", Age = 43 },
                new Person() {Name = "Paolo", Surname = "Rossi", Age = 4 },
                new Person() {Name = "Flavio", Surname = "Verdi", Age = 12 },
                new Person() {Name = "Luca", Surname = "Molteni", Age = 21  },
                new Person() {Name = "Andrea", Surname = "Filippi", Age = 32 },
                new Person() {Name = "Gioia", Surname = "Panzeri", Age = 8  }
            };
            OutputAgeCommand = new Command<Person>(OutputAge);
        }

        void OutputAge(Person person)
        {
            SelectedItemText = $"{person.Name} ha {person.Age} anni.";
            OnPropertyChanged("SelectedItemText");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
