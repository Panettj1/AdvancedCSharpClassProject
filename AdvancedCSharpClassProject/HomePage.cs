using AdvancedCSharpClassProject.Classes;
using AdvancedCSharpClassProject.Interfaces;

namespace AdvancedCSharpClassProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds anything that needs to be done on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Reads the data from the SampleWriting.txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readFileBtn_Click(object sender, EventArgs e)
        {
            string path = "SampleWriting.txt";


            StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            //check if the file exist first before reading
            if (!File.Exists(path)) Console.WriteLine("File does not exist");
            else
            {
                string line;

                while (reader.Peek() != -1)
                {
                    //read from the file
                    line = reader.ReadLine();

                    //type to the console screen
                    Console.WriteLine(line);
                }
                reader.Close();
            }

        }

        /// <summary>
        /// Adds data to write to SampleWriting.txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteToFileBtn_Click(object sender, EventArgs e)
        {
            IAnimal[] myAnimal = { new LandAnimals { Name = "Dog", Age =  5, Color = "Blue", NotesToSitter = "None", OwnerId = 1, Food = "all of it" }, new
                      AquaticAnimal{ Name = "Fish", Age = 1, Color = "Blue", NotesToSitter = "None", OwnerId = 1, Food = "all of it"  } };

            string path = "SampleWriting.txt";

            using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
            {
                foreach (IAnimal a in myAnimal)
                {
                    try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor

                        writer.WriteLine(a.DisplayAnimalInfo());
                        //Spacing to seperate each animal
                        writer.WriteLine("\n");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("Exception: " + error.Message);
                    }
                }
            };
        }

        /// <summary>
        /// Opens an instance of the page for interacting with the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDbQueryPageButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            DatabaseQueryPage queryPage = new DatabaseQueryPage();
            queryPage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}