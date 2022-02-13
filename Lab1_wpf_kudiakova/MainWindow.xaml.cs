using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab1_wpf_kudiakova
{

    public partial class MainWindow : Window
    {
		DateTime? _birtDate;
        public MainWindow()
        {
            InitializeComponent();
        }

		private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
		{
           _birtDate = (sender as DatePicker).SelectedDate;
			
		}

		private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_birtDate == null)
            {
                MessageBox.Show("You didn't enter your date of birth");
            } else if (!Validator.ValidateAge(_birtDate.Value))
            {
                MessageBox.Show("Entered date is incorrect");
            } else
            {
                Person person = new Person(_birtDate.Value);
                if (person.HaveBirthday())
                {
                    MessageBox.Show("Happy Birthday!!!!! You’re one step closer to diapers being mandatory!");
                }
                AgeBlock.Text = person.DefineAge().ToString();
                ZodiacBlock.Text = person.DefineAstrologicalSign();
                AnimalBlock.Text = person.DefineChineseZodiac();
            }

        }
    }
}
