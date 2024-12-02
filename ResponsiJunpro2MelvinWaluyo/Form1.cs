using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace ResponsiJunpro2MelvinWaluyo
{
    // Inheritance Form1 dari Form
    // Encapsulation ditandai dengan adanya access modifier seperti Private dan Public pada Code dibawah
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=postgres; Password=05071006; Database=ResponsiJunpro";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        // Polymorphism
        // Kedua Method memiliki nama yang sama tetapi memiliki parameter yang berbeda
        // Satu method tidak memiliki parameter
        // Satu method memiliki parameter String connstring untuk melakukan inisiasi koneksi ke Postgre
        private void EstablishConnection(string connstring)
        {
            this.connstring = connstring;
            conn = new NpgsqlConnection(connstring);
        }

        private void EstablishConnection()
        {
            MessageBox.Show("Connection to PostGre is underway", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EstablishConnection(connstring);
            EstablishConnection();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                dataGridView1.DataSource = null;
                sql = "SELECT * from kr_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM kr_insert(:_nama, :_id_dep, :_id_jabatan, :_salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", comboDepartemen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_id_jabatan", int.Parse(comboJabatan.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("_salary", numSalary.Value);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    tbNama.Text = comboDepartemen.Text = comboJabatan.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"SELECT * FROM kr_update(:_id_karyawan, :_nama, :_id_dep, :_id_jabatan, :_salary)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", comboDepartemen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("_id_jabatan", int.Parse(comboJabatan.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("_salary", numSalary.Value);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    tbNama.Text = comboDepartemen.Text = comboJabatan.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data karyawan " + r.Cells["_nama"].Value.ToString() + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM kr_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadData();
                        tbNama.Text = comboDepartemen.Text = comboJabatan.Text =  null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                comboDepartemen.Text = r.Cells["_id_dep"].Value.ToString();
                comboJabatan.Text = r.Cells["_nama_jabatan"].Value.ToString();
                numSalary.Value = decimal.Parse(r.Cells["_salary"].Value.ToString());
            }
        }
    }
}
