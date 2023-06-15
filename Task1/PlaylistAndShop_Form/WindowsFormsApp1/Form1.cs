using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 :Form
    {
        private Shop store;
        private Playlist playlist;

        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            store = new Shop();
            playlist = new Playlist();
        }

        private void добавитьНовыйТоварToolStripMenuItem_Click (object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Чтобы довавить новый товар, необходимо ввести его имя.", "Внимание!");
                return;
            }

            decimal price = numericUpDownPrice.Value;
            int count = (int) numericUpDownCount.Value;

            Product product = new Product(name, price);
            store.AddProduct(product, count);
            store.WriteAllProducts(listBoxOfProducts);

            textBoxProductName.Clear();
        }

        private void продатьТоварToolStripMenuItem1_Click (object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Чтобы довавить новый товар, необходимо ввести его имя.", "Внимание!");
                return;
            }

            Product product = store.FindByName(name);
            if (product != null)
            {
                store.Sell(product);
                store.WriteAllProducts(listBoxOfProducts);
                MessageBox.Show("Товар продан!", "Отлично!");
            } else
                MessageBox.Show("Товар не найден!", "Внимание!");

            textBoxProductName.Clear();
        }

        private void AddSongButton_Click (object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string filename = filenameTextBox.Text;

            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Для добавления песни, заполните все поля!", "Внимание!");
                return;
            }

            playlist.AddSong(author, title, filename);

            authorTextBox.Clear();
            titleTextBox.Clear();
            filenameTextBox.Clear();

            MessageBox.Show("Композиция была добавлена!", "Отлично!");
        }

        private void NextSongButton_Click (object sender, EventArgs e)
        {
            playlist.NextSong();
            UpdateCurrentSong();
        }

        private void PreviousButton_Click (object sender, EventArgs e)
        {
            playlist.PreviousSong();
            UpdateCurrentSong();
        }

        private void GoToSongButton_Click (object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int index))
            {
                try
                {
                    playlist.GoToSong(index);
                    UpdateCurrentSong();
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            } else
                MessageBox.Show("Введите корректный индекс.", "Ошибка!");
        }

        private void GoToStartButton_Click (object sender, EventArgs e)
        {
            playlist.GoToStart();
            UpdateCurrentSong();
        }

        private void RemoveSongButton_Click (object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int index))
            {
                try
                {
                    playlist.RemoveSong(index);
                    UpdateCurrentSong();
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            } else
                MessageBox.Show("Введите корректный индекс.", "Ошибка!");
        }

        private void ClearPlaylistButton_Click (object sender, EventArgs e)
        {
            playlist.ClearPlaylist();
            UpdateCurrentSong();
        }

        private void UpdateCurrentSong ()
        {
            try
            {
                Song currentSong = playlist.CurrentSong();
                authorLabel.Text = currentSong.Author;
                titleLabel.Text = currentSong.Title;
                filenameLabel.Text = currentSong.Filename;
            } catch (IndexOutOfRangeException)
            {
                authorLabel.Text = string.Empty;
                titleLabel.Text = string.Empty;
                filenameLabel.Text = string.Empty;
            }
        }
    }
}
