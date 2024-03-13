namespace MusicApp
{

    public partial class Form1 : Form
    {
        BindingSource albumbindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();

            //connect the list to the grid view

            albumbindingSource.DataSource = albumDAO.getAllAlbums();

            dataGridView1.DataSource = albumbindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();

            //connect the list to the grid view

            albumbindingSource.DataSource = albumDAO.searchTitles
                (textBox1.Text);

            dataGridView1.DataSource = albumbindingSource;
        }
    }
}
