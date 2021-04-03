using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clusterization_algorithms
{
    public partial class Form1 : Form
    {
        Forel forel;
        Graphic graphic;

        public Form1()
        {
            InitializeComponent();
            Graphics graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);
            forel = new Forel(graphic);
        }

        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);

            List<Point> points = new List<Point> {
                new Point(410, 186),
                new Point(89, 367),
                new Point(71, 417),
                new Point(146, 267),
                new Point(58, 333),
                new Point(28, 400),
                new Point(310, 220),
                new Point(180, 290),
                new Point(222, 165),
                new Point(450, 303),//10
                new Point(81, 36),
                new Point(43, 99),
                new Point(146, 120),
                new Point(150, 144),
                new Point(291, 410),
                new Point(299, 333),
                new Point(264, 175),
                new Point(421, 55),
                new Point(39, 188),
                new Point(74, 110),//20
                new Point(344, 257),
                new Point(233, 335),
                new Point(261, 255),
                new Point(321, 432),
                new Point(63, 367),
                new Point(43, 231),
                new Point(85, 450),
                new Point(276, 329),
                new Point(310, 201),
                new Point(66, 290),//30
                new Point(311, 22),
                new Point(146, 211),
                new Point(22, 312),
                new Point(31, 42),
                new Point(49, 444),
                new Point(89, 322),
                new Point(255, 133),
                new Point(344, 421),
                new Point(533, 550),
                new Point(499, 399),//40
                new Point(477, 354),
                new Point(581, 600),
                new Point(421, 550),
                new Point(510, 571),
                new Point(436, 77),
                new Point(491, 566),
                new Point(512, 555),
                new Point(449, 490),
                new Point(34, 521),
                new Point(99, 599),//50
                new Point(121, 341),
                new Point(41, 233),
                new Point(46, 571),
                new Point(571, 46),
                new Point(584, 145),
                new Point(141, 587),
                new Point(425, 441),
                new Point(362, 577),
                new Point(271, 361),
                new Point(583, 142),//60
                new Point(588, 11),
                new Point(11, 587),
                new Point(32, 267),
                new Point(511, 41),
                new Point(566, 56),
                new Point(522, 487),
                new Point(342, 594),
                new Point(12, 260),
                new Point(326, 85),
                new Point(581, 233),//70
                new Point(89, 449),
                new Point(99, 199),
                new Point(501, 465),
                new Point(331, 580),
                new Point(234, 432),
                new Point(543, 345),
                new Point(321, 123),
                new Point(431, 231),
                new Point(343, 546),
                new Point(22, 385),//80
                new Point(334, 32),
                new Point(21, 455),
                new Point(533, 591),
                new Point(244, 43),
                new Point(321, 64),
                new Point(211, 73),
                new Point(331, 99),
                new Point(120, 102),
                new Point(132, 154),
                new Point(241, 191),//90
                new Point(122, 211),
                new Point(144, 312),
                new Point(133, 231),
                new Point(171, 271),
                new Point(166, 299),
                new Point(170, 270),
                new Point(153, 123),
                new Point(139, 349),
                new Point(111, 531),
                new Point(145, 175)//100
            };

            int pointsCount = 10;
            Int32.TryParse(textBoxSetPointsCount.Text, out pointsCount);

            //calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);
            forel.setPoints(points);
            textBoxInfo.Text = Calculator.printPoints(forel.getPoints());
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            forel.Radius = 150;

            if (Int32.TryParse(textBoxSetRadius.Text, out int radius))
                forel.Radius = radius;

            forel.startForel();
            textBoxInfo.Text = forel.printPoints();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            pictBoxArea.Image = null;
            textBoxInfo.Clear();

            forel.clearFields();
        }

        private void btnKMeans_Click(object sender, EventArgs e)
        {

        }
    }
}
