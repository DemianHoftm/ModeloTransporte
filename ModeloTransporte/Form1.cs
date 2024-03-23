using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloTransporte
{
    public partial class Form1 : Form
    {
        List<PictureBox> nodos;
        Grafo GRafico_grafo;
        bool nodo_dibujo;
        public bool isDragging;
        public Form1()
        {
            InitializeComponent();
            nodos = new List<PictureBox>();
            GRafico_grafo = new Grafo();
            _de.Items.Add("Seleccione");
            _de.SelectedIndex = 0;
            _to.Items.Add("Seleccione");
            _to.SelectedIndex = 0;
            nodo_dibujo = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_de.SelectedIndex == _to.SelectedIndex) {
                MessageBox.Show("Seleccione una ruta valida", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (distancia.Text == "") {
                MessageBox.Show("Ingrese una distancia valida", "Error de distancia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GRafico_grafo.grafico[_de.SelectedIndex-1].Nodos_Sig.Add(GRafico_grafo.grafico[_to.SelectedIndex-1]);
            GRafico_grafo.grafico[_de.SelectedIndex-1].Peso_sig.Add(Convert.ToDecimal(distancia.Text));

            //crear la flecha
            PictureBox flecha = new PictureBox();
            flecha.Size = panel1.Size; // Asegurarse de que la flecha tenga el tamaño correcto
            flecha.Location = new Point(0, 0); // Asegurarse de que la flecha esté en la ubicación correcta
            panel1.Controls.Add(flecha);
            nodo_dibujo = false;
            flecha.Paint += Node_pic_Paint;
            flecha.Invalidate();
            flecha.Update();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            PictureBox node_pic = new PictureBox();
            panel1.Controls.Add(node_pic);
            nodo_dibujo = true;

            node_pic.Size = new Size(60, 60);
            node_pic.Paint += Node_pic_Paint;
            Point punto = new Point(Cursor.Position.X - 18, Cursor.Position.Y-45);
            node_pic.Location = punto;
            nodos.Add(node_pic );
            Rellenador();
            GRafico_grafo.grafico.Add(new nodo_class());
            node_pic.Invalidate();
        }

        private void Node_pic_Paint(object sender, PaintEventArgs e)
        {
            if (nodo_dibujo)
            {
                Graphics circle = e.Graphics;
                Pen lapiz = new Pen(Color.Black, 2);
                circle.DrawArc(lapiz, new Rectangle(0, 0, 50, 50), 0, 360);
                SolidBrush s = new SolidBrush(Color.Black);
                FontFamily ff = new FontFamily("Consolas");
                Font font = new Font(ff, 15);
                string nombre = (nodos.Count).ToString();
                circle.DrawString(nombre, font, s, 15, 15);
            }
            else {
                Graphics g = e.Graphics;
                Pen p = new Pen(Color.Black);
                AdjustableArrowCap arrow = new AdjustableArrowCap(5, 5);
                p.CustomEndCap = arrow;

                // Calcular el punto de inicio y el punto final
                Point inicio = new Point(nodos[_de.SelectedIndex - 1].Left + nodos[_de.SelectedIndex - 1].Width / 2,
                                         nodos[_de.SelectedIndex - 1].Top + nodos[_de.SelectedIndex - 1].Height / 2);
                Point final = new Point(nodos[_to.SelectedIndex - 1].Left + nodos[_to.SelectedIndex - 1].Width / 2,
                                        nodos[_to.SelectedIndex - 1].Top + nodos[_to.SelectedIndex - 1].Height / 2);

                // Dibujar la línea desde el centro del nodo de origen hasta el centro del nodo de destino
                g.DrawLine(p, inicio, final);
                _de.SelectedIndex = 0;
                _to.SelectedIndex = 0;
                distancia.Text = "";
            }
        }

        private void Rellenador() {
            _de.Items.Add(_de.Items.Count.ToString());
            _to.Items.Add(_to.Items.Count.ToString());
        }

    }
}
