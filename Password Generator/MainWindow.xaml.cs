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

namespace Password_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Fields

        // All Characters available
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialCharacters = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";

        // Lengths
        private int length = 15;
        private int minLength = 6;
        private int maxLength = 30;

        // Password
        private string password = "";

        // Check if the password is visible or not
        private bool isTextVisible;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            StartWindow();
        }

        // This method will call when the application started
        public void StartWindow()
        {
            this.LengthNumber.Text = length.ToString();

            this.CapitalLettersCheckBox.IsChecked = 
                this.SmallLettersCheckBox.IsChecked = 
                this.DigitsCheckBox.IsChecked = 
                this.SpecialCharactersCheckBox.IsChecked = true;

            this.isTextVisible = false;
        }

        #region Buttons

        // Show or Don't Dhow the password Button
        private void VisibilityButton_Click(object sender, RoutedEventArgs e)
        {
            isTextVisible ^= true;
            this.VisibilityButton.Content = isTextVisible ? "Don't Show" : "Show";

            if (this.isTextVisible)
            {
                this.PasswordText.Text = password;
            }

            else if (!this.isTextVisible)
            {
                this.PasswordText.Text = GenerateInvisiblePassword(password.Length);
            }

        }

        // Copy Button
        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(this.password);
        }

        // Check All
        private void CheckAllButton_Click(object sender, RoutedEventArgs e)
        {
            this.CapitalLettersCheckBox.IsChecked =
                this.SmallLettersCheckBox.IsChecked =
                this.DigitsCheckBox.IsChecked =
                this.SpecialCharactersCheckBox.IsChecked = true;
        }

        #region Up and Down Buttons

        // Up Button
        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if ((this.length - 1) < this.minLength)
            {
                return;
            }

            this.length--;
            this.LengthNumber.Text = length.ToString();
        }

        // Down Button
        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if ((this.length + 1) > maxLength)
            {
                return;
            }

            this.length++;
            this.LengthNumber.Text = length.ToString();
        }

        #endregion

        #endregion

        /* Check and Uncheck Methods below
         * 
         * 
         * I tried to make a single method for check and 
         * uncheck for each button with "^" but I failed :D
         * 
         * I also tried to disable unchecking if only one
         * is checked but I failed :D
         * 
         */

        #region Check Methods

        // Check Capital Letters Method
        private void CapitalLettersCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.CapitalLettersCheckBox.IsChecked = true;
        }

        // Check Small Letters Method
        private void SmallLettersCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.SmallLettersCheckBox.IsChecked = true;
        }

        // Check Digits Method
        private void DigitsCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.DigitsCheckBox.IsChecked = true;
        }
        
        // Check Special Characters Method
        private void SpecialCharactersCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.SpecialCharactersCheckBox.IsChecked = true;
        }

        #endregion

        #region Uncheck Methods

        private void CapitalLettersCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.CapitalLettersCheckBox.IsChecked = false;
        }

        private void SmallLettersCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.SmallLettersCheckBox.IsChecked = false;
        }

        private void DigitsCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.DigitsCheckBox.IsChecked = false;
        }

        private void SpecialCharactersCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.SpecialCharactersCheckBox.IsChecked = false;
        }

        #endregion

        #region Generating Password

        // Generate Button
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            string characters = SetCharacters((bool)CapitalLettersCheckBox.IsChecked, 
                (bool)SmallLettersCheckBox.IsChecked, 
                (bool)DigitsCheckBox.IsChecked, 
                (bool)SpecialCharactersCheckBox.IsChecked);

            string password = GeneratePassword(characters, length);
            this.password = password;

            if (this.isTextVisible)
            {
                this.PasswordText.Text = password;
            }

            else if (!this.isTextVisible)
            {
                this.PasswordText.Text = GenerateInvisiblePassword(password.Length);
            }
        }

        // Set the characters
        private string SetCharacters(bool isCapitalLettersIncluded, 
            bool isSmallLettersIncluded, bool isDigitsIncluded, bool isSpecialCharactersIncluded)
        {
            StringBuilder characters = new StringBuilder();

            if (isCapitalLettersIncluded)
            {
                characters.Append(CapitalLetters);
            }
            if (isSmallLettersIncluded)
            {
                characters.Append(SmallLetters);
            }
            if (isDigitsIncluded)
            {
                characters.Append(Digits);
            }
            if (isSpecialCharactersIncluded)
            {
                characters.Append(SpecialCharacters);
            }

            return characters.ToString();
        }

        // Generate Password Method
        private string GeneratePassword(string characters, int length)
        {
            StringBuilder password = new StringBuilder(length);
            Random random = new Random();

            if (characters.Length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    password.Append(characters[random.Next(0, characters.Length)]);
                }
            }

            return password.ToString();
        }

        private string GenerateInvisiblePassword(int length)
        {
            StringBuilder password = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                password.Append("*");
            }

            return password.ToString();
        }

        #endregion 
    }
}
