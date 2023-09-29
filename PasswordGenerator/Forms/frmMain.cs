using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class frmMain : Form
    {
        public enum PasswordDifficulty: byte
        {
            Easy = 0,
            Middle,
            Hard
        }
        private Random myRandom;
        private PasswordDifficulty passwordDiffictulty;
        public frmMain()
        {
            InitializeComponent();
            myRandom = new Random();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbPasswordDifficulty.SelectedIndex = 0;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string generatedPassword = "";
            int index;
            switch (passwordDiffictulty)
            {
                case PasswordDifficulty.Easy:
                
                    for (int i = 0; i < nudCharacters.Value; i++)
                    {
                        int charSet = myRandom.Next(0,2); // 0 = lowcase letters; 1 = uppercase letters
                        switch (charSet)
                        {
                            case 0:
                                index = myRandom.Next(0, SymbolConstants.LOWCASE_LETTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.LOWCASE_LETTERS.ElementAt(index);
                                break;
                            case 1:
                                index = myRandom.Next(0, SymbolConstants.UPPERCASE_LETTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.UPPERCASE_LETTERS.ElementAt(index);
                                break;
                        }
                    }
                    break;
                case PasswordDifficulty.Middle:

                    for (int i = 0; i < nudCharacters.Value; i++)
                    {
                        int charSet = myRandom.Next(0, 3); // 0 = lowcase letters; 1 = uppercase letters; 2 = numbers
                        switch (charSet)
                        {
                            case 0:
                                index = myRandom.Next(0, SymbolConstants.LOWCASE_LETTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.LOWCASE_LETTERS.ElementAt(index);
                                break;
                            case 1:
                                index = myRandom.Next(0, SymbolConstants.UPPERCASE_LETTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.UPPERCASE_LETTERS.ElementAt(index);
                                break;
                            case 2:
                                index = myRandom.Next(0, SymbolConstants.NUMBERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.NUMBERS.ElementAt(index);
                                break;
                        }
                    }
                    break;
                case PasswordDifficulty.Hard:
                    for (int i = 0; i < nudCharacters.Value; i++)
                    {
                        int charSet = myRandom.Next(0, 4); // 0 = lowcase letters; 1 = uppercase letters; 2 = numbers; 3 = special symbols
                        switch (charSet)
                        {
                            case 0:
                                index = myRandom.Next(0, SymbolConstants.LOWCASE_LETTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.LOWCASE_LETTERS.ElementAt(index);
                                break;
                            case 1:
                                index = myRandom.Next(0, SymbolConstants.UPPERCASE_LETTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.UPPERCASE_LETTERS.ElementAt(index);
                                break;
                            case 2:
                                index = myRandom.Next(0, SymbolConstants.NUMBERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.NUMBERS.ElementAt(index);
                                break;
                            case 3:
                                index = myRandom.Next(0, SymbolConstants.SPECIAL_CHARACTERS.Length - 1);
                                generatedPassword = generatedPassword + SymbolConstants.SPECIAL_CHARACTERS.ElementAt(index);
                                break;
                        }
                    }
                    break;
            }
            tbGeneratedPassword.Text = generatedPassword;
        }
        private void cbPasswordDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPasswordDifficulty.SelectedIndex)
            {
                case 0:
                    passwordDiffictulty = PasswordDifficulty.Easy;
                    break;
                case 1:
                    passwordDiffictulty = PasswordDifficulty.Middle;
                    break;
                case 2:
                    passwordDiffictulty = PasswordDifficulty.Hard;
                    break;
            }
        }
        private void tbGeneratedPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbGeneratedPassword.Text;
            if (password.ContainsAnyCharacter(SymbolConstants.UPPERCASE_LETTERS, SymbolConstants.LOWCASE_LETTERS, SymbolConstants.NUMBERS, SymbolConstants.SPECIAL_CHARACTERS))
                tbGeneratedPassword.BackColor = Color.LightGreen;
            else if (password.ContainsAnyCharacter(SymbolConstants.UPPERCASE_LETTERS, SymbolConstants.LOWCASE_LETTERS, SymbolConstants.NUMBERS))
                tbGeneratedPassword.BackColor = Color.Orange;
            else if (password.ContainsAnyCharacter(SymbolConstants.UPPERCASE_LETTERS, SymbolConstants.LOWCASE_LETTERS))
                tbGeneratedPassword.BackColor = Color.Red;
            else
                tbGeneratedPassword.BackColor = Color.Red;
        }
    }
}
