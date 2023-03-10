using MySql.Data.MySqlClient;
using System.Data;
namespace db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = koneksi.getConnection();
        DataTable dataTable = new DataTable();

        public DataTable getDataSiswa()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM gunpla", conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void filldataTable()
        {
            data_gunpla.DataSource = getDataSiswa();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            data_gunpla.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            data_gunpla.Columns.Add(colDelete);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO gunpla(nama_model,series,harga_saat_ini) value (@Nama,@Series,@harga)";
                cmd.Parameters.AddWithValue("@Nama", inputNama.Text);
                cmd.Parameters.AddWithValue("@Series", inputSeries.Text);
                cmd.Parameters.AddWithValue("@harga", inputHarga.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("item succesfully added to catalog" + MessageBoxButtons.OK);

                data_gunpla.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void data_gunpla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(data_gunpla.CurrentCell.RowIndex.ToString());
                inputId.Text = data_gunpla.Rows[id].Cells[0].Value.ToString();
                inputNama.Text = data_gunpla.Rows[id].Cells[1].Value.ToString();
                inputSeries.Text = data_gunpla.Rows[id].Cells[2].Value.ToString();
                inputHarga.Text = data_gunpla.Rows[id].Cells[3].Value.ToString();

                inputHarga.Enabled = true;
                inputNama.Enabled = true;
                inputSeries.Enabled = true;
                bt_save.Enabled = true;
            }
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(data_gunpla.CurrentCell.RowIndex.ToString());
                MySqlCommand cmd;
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from gunpla WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", data_gunpla.Rows[id].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    resetIncrement();
                    conn.Close();
                    MessageBox.Show("item succesfully removed to catalog" + MessageBoxButtons.OK);
                    data_gunpla.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error occured:" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(conn, "SET @id := 0; UPDATE gunpla SET id = @id := (@id+1);" +
                "ALTER TABLE gunpla AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE gunpla SET nama_model=@nama, series=@series, harga_saat_ini=@harga WHERE id=@id";
                cmd.Parameters.AddWithValue("@nama", inputNama.Text);
                cmd.Parameters.AddWithValue("@series", inputSeries.Text);
                cmd.Parameters.AddWithValue("@harga", inputHarga.Text);
                cmd.Parameters.AddWithValue("@id", inputId.Text);
                cmd.ExecuteNonQuery();
                resetIncrement();
                conn.Close();
                MessageBox.Show("item succesfully updated from catalog" + MessageBoxButtons.OK);
                data_gunpla.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from gunpla WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", inputId.Text);
                cmd.ExecuteNonQuery();
                resetIncrement();
                conn.Close();

                data_gunpla.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}