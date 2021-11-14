using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WinFormRacing
{
    public partial class Race : Form
    {
        bool car_1 = false;
        bool car_2 = false;
        bool car_3 = false;
        Random random = new Random();
        public Race()
        {
            InitializeComponent();
        }
        private void StartClick(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(() => MoveCar1(car1));
            Thread thread2 = new Thread(() => MoveCar2(car2));
            Thread thread3 = new Thread(() => MoveCar3(car3));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        public void MoveCar1(Button car)
        {
            While(car);
            car_1 = true;

            if (car_2 == false && car_3 == false)
                MessageBox.Show($"{car1.Name} is win");
        }

        public void MoveCar2(Button car)
        {
            While(car);
            car_2 = true;
            if (car_1 == false && car_3 == false)
                MessageBox.Show($"{car2.Name} is win");
        }

        public void MoveCar3(Button car)
        {
            While(car);
            car_3 = true;
            if (car_1 == false && car_2 == false)
                MessageBox.Show($"{car3.Name} is win");
        }

        public void While(Button car)
        {
            while (car.Location.X <= finish.Location.X - car.Width)
            {
                car.Location = new Point(car.Location.X + random.Next(1, 10), car.Location.Y);
                Thread.Sleep(random.Next(5, 50));
            }
        }
    }
}


