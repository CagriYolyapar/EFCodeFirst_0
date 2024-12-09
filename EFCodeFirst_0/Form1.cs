using EFCodeFirst_0.DesignPatterns.SingletonPattern;
using EFCodeFirst_0.Models.ContextClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirst_0
{
    public partial class Form1 : Form
    {
        MyContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Categories.ToList();
        }
    }
}
