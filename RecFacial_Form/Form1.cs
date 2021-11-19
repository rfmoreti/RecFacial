using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace RecFacial_Form
{
    public partial class form_RecFacial : Form
    {
        public form_RecFacial()
        {
            InitializeComponent();
        }
        FaceRec recFacial = new FaceRec();
        private void btn_AbrirCam_Click(object sender, EventArgs e)
        {
            recFacial.openCamera(pic_Camera, pic_Captura);
        }
    }
}
