using Kursach_15Variant.Utility;
using Model.FileCabinet;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach_15Variant
{
    public partial class Form1 : Form
    {
        private int Book_ID = 0;
        private readonly LibraryFileCabinet _libraryFileCabinet;
        public Form1()
        {
            InitializeComponent();
            _libraryFileCabinet = new LibraryFileCabinet();
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            string errorField = null;
            decimal adjustmentPrice = 0.0M;
            if (string.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(authorTextBox.Text)
                || string.IsNullOrEmpty(publishingTextBox.Text) || publicationsDatePicker.Value == DateTime.MinValue
                || string.IsNullOrEmpty(priceTextBox.Text) || diliveryDatePicker.Value == DateTime.MinValue)
            {
                MessageBox.Show("Not all text boxes were filled");
            }
            else if (Filters.FilterTitle(titleTextBox.Text, out errorField) || Filters.FilterAuthor_Publishing(authorTextBox.Text, out errorField)
                || Filters.FilterAuthor_Publishing(publishingTextBox.Text, out errorField) || Decimal.TryParse(priceTextBox.Text, out adjustmentPrice))
            {
                MessageBox.Show($"Not correct {errorField}", "Validation Error");
            }
            else
            {
                Book_ID++;
                registrationsBookDataGrid.Rows.Add(Book_ID, titleTextBox.Text, authorTextBox.Text, publicationsDatePicker.Value.ToShortDateString(),
                    publishingTextBox.Text, priceTextBox.Text, bookExsist.TrueValue = true, diliveryDatePicker.Value.ToShortDateString());

                editBookDataGrid.Rows.Add(Book_ID, titleTextBox.Text, authorTextBox.Text, publicationsDatePicker.Value.ToShortDateString(),
                    publishingTextBox.Text, priceTextBox.Text, bookExsistEdit.TrueValue = true, diliveryDatePicker.Value.ToShortDateString());

                _libraryFileCabinet.Books.Add(new Book
                {
                    BookID = Book_ID,
                    BookTitle = titleTextBox.Text,
                    BookAuthor = authorTextBox.Text,
                    BookDiliveryDate = diliveryDatePicker.Value,
                    BookPublicationDate = publicationsDatePicker.Value,
                    BookPrice = adjustmentPrice,
                    BookPublishing = publishingTextBox.Text,
                    IsExsist = true
                });
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kursach Variant 15", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeButtonEdit_Click(object sender, EventArgs e)
        {
            string editString = null;
            for (int i = 0; i < Book_ID; i++)
            {
                bool result = true;
                string[] str = new string[8];
                for (int j = 1; j < registrationsBookDataGrid.ColumnCount; j++)
                {
                    if ((j == 1) && Filters.FilterTitle(editBookDataGrid.Rows[i].Cells[j].Value.ToString(), out editString))
                    {
                        result = false;
                        MessageBox.Show($"Invalid {editString}", "Edit Info");
                    }
                    if ((j == 2 || j == 4) && Filters.FilterAuthor_Publishing(editBookDataGrid.Rows[i].Cells[j].Value.ToString(), out editString))
                    {
                        result = false;
                        MessageBox.Show($"Invalid {editString}", "Edit Info");
                    }

                    if (j == 3 && editBookDataGrid.Rows[i].Cells[j].Value.ToString() == DateTime.MinValue.ToString())
                    {
                        result = false;
                        MessageBox.Show($"Invalid publications time", "Edit Info");
                    }

                    if (j == 5 && Decimal.Parse(editBookDataGrid.Rows[i].Cells[j].Value.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat) < 0)
                    {
                        result = false;
                        MessageBox.Show($"Invalid price", "Edit Info");
                    }

                    if (j == 7 && editBookDataGrid.Rows[i].Cells[j].Value.ToString() == DateTime.MinValue.ToString())
                    {
                        result = false;
                        MessageBox.Show($"Invalid dilivery time", "Edit Info");
                    }
                    str[j] = editBookDataGrid.Rows[i].Cells[j].Value.ToString();

                    if (result)
                    {
                        for (int k = 1; k < 8; k++)
                        {
                            registrationsBookDataGrid.Rows[i].Cells[k].Value = str[k];
                        }
                        var adjustmentPrice = Decimal.Parse(editBookDataGrid.Rows[i].Cells[5].Value.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat);
                        _libraryFileCabinet.Books.ElementAt(i).BookTitle = editBookDataGrid.Rows[i].Cells[1].Value.ToString();
                        _libraryFileCabinet.Books.ElementAt(i).BookAuthor = editBookDataGrid.Rows[i].Cells[2].Value.ToString();
                        _libraryFileCabinet.Books.ElementAt(i).BookPublicationDate = DateTime.Parse(editBookDataGrid.Rows[i].Cells[3].Value.ToString());
                        _libraryFileCabinet.Books.ElementAt(i).BookPublishing = editBookDataGrid.Rows[i].Cells[4].Value.ToString();
                        _libraryFileCabinet.Books.ElementAt(i).BookPrice = adjustmentPrice;
                        _libraryFileCabinet.Books.ElementAt(i).IsExsist = Boolean.Parse(editBookDataGrid.Rows[i].Cells[6].Value.ToString());
                        _libraryFileCabinet.Books.ElementAt(i).BookDiliveryDate = DateTime.Parse(editBookDataGrid.Rows[i].Cells[7].Value.ToString());
                    }
                }
            }
        }

        private void changeExistToFalse_Click(object sender, EventArgs e)
        {
            var maxyear = _libraryFileCabinet.Books.Max(bookYear => bookYear.BookPublicationDate.Value.Year);
            for (int i = 0; i < Book_ID; i++)
            {
                if ((_libraryFileCabinet.Books.ElementAt(i).BookPublicationDate.Value.Year + int.Parse(yearNumericPanel.Value.ToString())) > maxyear
                    && _libraryFileCabinet.Books.ElementAt(i).BookPublicationDate.Value.Year != maxyear)
                {
                    _libraryFileCabinet.Books.ElementAt(i).IsExsist = false;
                    editBookDataGrid.Rows[i].Cells[6].Value = false;
                }

            }
        }

        private void searchPriceGreaterThan_Click(object sender, EventArgs e)
        {
            searchDataGrid.Rows.Clear();
            int count = 0;
            for (int i = 0; i < Book_ID; i++)
            {
                if (_libraryFileCabinet.Books.ElementAt(i).BookPrice > 100.0M)
                {
                    count++;
                    searchDataGrid.Rows.Add(count, _libraryFileCabinet.Books.ElementAt(i).BookTitle,
                        _libraryFileCabinet.Books.ElementAt(i).BookAuthor,
                        _libraryFileCabinet.Books.ElementAt(i).BookPublicationDate,
                        _libraryFileCabinet.Books.ElementAt(i).BookPublishing,
                        _libraryFileCabinet.Books.ElementAt(i).BookPrice,
                        _libraryFileCabinet.Books.ElementAt(i).IsExsist,
                        _libraryFileCabinet.Books.ElementAt(i).BookDiliveryDate);
                }
            }
        }

        private void searchAuthorBooksButton_Click(object sender, EventArgs e)
        {
            searchDataGrid.Rows.Clear();
            string errorString = null;
            if (string.IsNullOrEmpty(searchAuthorTextBox.Text))
            {
                MessageBox.Show("Text box empty");
            }
            else if (Filters.FilterAuthor_Publishing(searchAuthorTextBox.Text, out errorString))
            {
                MessageBox.Show($"Invalid Author: {searchAuthorTextBox.Text}", $"{errorString}");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < Book_ID; i++)
                {
                    if (_libraryFileCabinet.Books.ElementAt(i).BookAuthor == searchAuthorTextBox.Text)
                    {
                        count++;
                        searchDataGrid.Rows.Add(count, _libraryFileCabinet.Books.ElementAt(i).BookTitle,
                            _libraryFileCabinet.Books.ElementAt(i).BookAuthor,
                            _libraryFileCabinet.Books.ElementAt(i).BookPublicationDate,
                            _libraryFileCabinet.Books.ElementAt(i).BookPublishing,
                            _libraryFileCabinet.Books.ElementAt(i).BookPrice,
                            _libraryFileCabinet.Books.ElementAt(i).IsExsist,
                            _libraryFileCabinet.Books.ElementAt(i).BookDiliveryDate);
                    }
                }
            }
        }

        private void searchDilivery_Click(object sender, EventArgs e)
        {
            DateTime generalDiliveryDate = new DateTime(2020, 1, 1);
            int count = 0;
            for (int i = 0; i < Book_ID; i++)
            {
                if (_libraryFileCabinet.Books.ElementAt(i).BookDiliveryDate.Date.Month + 3 > generalDiliveryDate.Date.Month)
                {
                    count++;
                    searchDataGrid.Rows.Add(count, _libraryFileCabinet.Books.ElementAt(i).BookTitle,
                        _libraryFileCabinet.Books.ElementAt(i).BookAuthor,
                        _libraryFileCabinet.Books.ElementAt(i).BookPublicationDate,
                        _libraryFileCabinet.Books.ElementAt(i).BookPublishing,
                        _libraryFileCabinet.Books.ElementAt(i).BookPrice,
                        _libraryFileCabinet.Books.ElementAt(i).IsExsist,
                        _libraryFileCabinet.Books.ElementAt(i).BookDiliveryDate);
                }
            }
        }

        private void readFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextReader text = new StreamReader(File.OpenRead($@"C:\Users\{SystemInformation.UserName}\Desktop\info.txt"), Encoding.Default))
            {
                try
                {
                    var str = text.ReadLine();
                    if (str.Length != 0)
                    {
                        foreach (var item in str.Replace('\t', '\n'))
                        {
                            cachedRichTextBox.Text += item.ToString();
                        }
                        MessageBox.Show("Information has been added");
                    }
                    else
                    {
                        MessageBox.Show("Empty file");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }
            }
        }

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextWriter writer = new StreamWriter(File.Create($@"C:\Users\{SystemInformation.UserName}\Desktop\info.txt"), Encoding.Default))
            {
                try
                {
                    if (registrationsBookDataGrid.Rows.Count - 1 != 0)
                    {
                        for (int i = 0; i < registrationsBookDataGrid.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < registrationsBookDataGrid.Columns.Count; j++)
                            {
                                if (j == 8)
                                    writer.Write(registrationsBookDataGrid.Rows[i].Cells[j].Value.ToString() + '\n');
                                else
                                    writer.Write(registrationsBookDataGrid.Rows[i].Cells[j].Value.ToString() + '\t');
                            }
                        }
                        MessageBox.Show("Info cashed");
                    }
                    else
                    {
                        MessageBox.Show("Need more info");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    writer.Close();
                }
            }
        }
    }
}