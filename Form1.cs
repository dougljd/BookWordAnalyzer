namespace BookWordAnalyzer
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }


            // Jonathan Douglas
            // Allows the user to select the first book.
            private void btnBrowse1_Click(object sender, EventArgs e)
            {
                using OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text Files (*.txt)|*.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtBook1.Text = dialog.FileName;
                }
            }

            // Jonathan Douglas
            // Allows the user to select the second book.
            private void btnBrowse2_Click(object sender, EventArgs e)
            {
                using OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text Files (*.txt)|*.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtBook2.Text = dialog.FileName;
                }
            }

            // Jonathan Douglas
            // Reads a book asynchronously and finds its top 10 words.
            private async Task<List<string>> AnalyzeBookAsync(string filePath)
            {
                string content = await File.ReadAllTextAsync(filePath);

                string[] words = System.Text.RegularExpressions.Regex.Split(
                    content.ToLowerInvariant(), @"[^\p{L}]+");

                var topWords = words
                    .Where(word => !string.IsNullOrWhiteSpace(word))
                    .GroupBy(word => word)
                    .OrderByDescending(group => group.Count())
                    .ThenBy(group => group.Key)
                    .Take(10)
                    .Select(group => $"{group.Key} - {group.Count()}")
                    .ToList();

                return topWords;
            }

            // Jonathan Douglas
            // Processes each selected book asynchronously.
            private async void btnAnalyze_Click(object sender, EventArgs e)
            {
                if (!File.Exists(txtBook1.Text) ||
                    !File.Exists(txtBook2.Text))
                {
                    MessageBox.Show("Please select two valid text files.");
                    return;
                }

                btnAnalyze.Enabled = false;
                lstBook1.Items.Clear();
                lstBook2.Items.Clear();

                try
                {
                    Task<List<string>> book1Task =
                        AnalyzeBookAsync(txtBook1.Text);

                    Task<List<string>> book2Task =
                        AnalyzeBookAsync(txtBook2.Text);

                    await Task.WhenAll(book1Task, book2Task);

                    lstBook1.Items.AddRange(book1Task.Result.ToArray());
                    lstBook2.Items.AddRange(book2Task.Result.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    btnAnalyze.Enabled = true;
                }
            }

            // Jonathan Douglas
            private void btnExit_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }
