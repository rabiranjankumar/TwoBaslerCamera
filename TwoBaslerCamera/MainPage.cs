using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TwoBaslerCamera.Devices;
using TwoBaslerCamera.Statics;
namespace TwoBaslerCamera
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        System.Timers.Timer aTimer;
        System.Threading.Thread camera_thread = null;
        // Algo.Class1 cpp = new Algo.Class1();
        public int exposureTime = 500;
        private void MainPage_Load(object sender, EventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CenterToScreen();
            this.Text = "Vision Inspection by Add innovations Pvt Ltd ";
           // this.Icon = new Icon(GlobalItems.icon);
            Console.WriteLine();
            Console.WriteLine("     **********  CAMERA API MAIN PAGE LOAD  ***************** ");
            Console.WriteLine("ExposureTimeAbs         : {0}", GlobalItems.ExposureTimeAbs);
            Console.WriteLine("ExposureTimeRaw         : {0}", GlobalItems.ExposureTimeRaw);
            camera_thread = new System.Threading.Thread(
            () =>
            {
                BaslerCameraApiModule.initialize_camera();
            }
            );
            camera_thread.Name = "Basler_Camera_Thread";
            camera_thread.Start();
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(Do_software_trigger);
            aTimer.Interval = 100;
            aTimer.Enabled = true;
            //numeric_exposure_time.Value = (decimal)exposureTime;
            //numeric_timer_speed.Value = decimal.Parse(aTimer.Interval.ToString());
            //numeric_timer_speed.Enabled = false;



            timer_camera_status.Interval = 500;
            timer_camera_status.Start();
        }
        private void Do_software_trigger(object sender, ElapsedEventArgs e)
        {
            BaslerCameraApiModule.do_software_trigger();
            //aTimer.Stop();
            //aTimer.Enabled = false;
            // throw new NotImplementedException();
        }
        internal void updateLbl(string v, Color color)
        {
            lbl_camera_status.Invoke(new Action(() => lbl_camera_status.Text = v));
            lbl_camera_status.Invoke(new Action(() => lbl_camera_status.ForeColor = color));
        }
        public void updatePicBox(Bitmap bitmap, int pic_box_no)
        {
            if (pic_box_no == 1)
            {
                if (picboxOne.InvokeRequired)
                {
                    picboxOne.Invoke(new Action(() => picboxOne.Image = bitmap));
                }
                else
                {
                    picboxOne.Image = new Bitmap(bitmap);
                }
            }//if(counter==0)
            if (pic_box_no == 2)
            {
                if (picBox2.InvokeRequired)
                {
                    picBox2.Invoke(new Action(() => picBox2.Image = bitmap));
                }
                else
                {
                    picBox2.Image = new Bitmap(bitmap);
                }
            }//if(counter==0)
        }//updatePicBox
        private void label1_Click(object sender, EventArgs e)
        {
        }

        bool exit_button = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            picboxOne.Dispose();
            picBox2.Dispose();
           // picBox3.Dispose();
            //picBox4.Dispose();
            exit_button = true;
            BaslerCameraApiModule.stop_camera();
            aTimer.Stop();
            aTimer.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            try
            {
                camera_thread.Abort();
            }
            catch (Exception ee)
            {
                Console.WriteLine("  exception in thread abort " + ee.Message);
            }
            //Application.Exit();
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit_button == false)
            {
                var window = MessageBox.Show(
                        "PLEASE USE EXIT BUTTON ?",
                        "alert message ?",
                        MessageBoxButtons.OK);

                e.Cancel = (window == DialogResult.OK);
            }
        }

        private void btn_setOk_Click(object sender, EventArgs e)
        {
            BaslerCameraApiModule.setCameraonNg();
        }

        private void cbsoftware_CheckedChanged(object sender, EventArgs e)
        {
            // if software trigger is checked 
            if (cbsoftware.Checked)
            {

                BaslerCameraApiModule.set_software_trigger();
                BaslerCameraApiModule.do_software_trigger();
                cbhardware.Checked = false;
            }

            if (cbsoftware.Checked == false)
            {
                cbhardware.Checked = true;


            }

        }

        private void cbhardware_CheckedChanged(object sender, EventArgs e)
        {
            // do hardware trigger 
            if (cbhardware.Checked)
            {

                BaslerCameraApiModule.set_hardware_trigger();
                cbsoftware.Checked = false;


            }
            if (cbhardware.Checked == false)
            {
                cbsoftware.Checked = true;


            }
        }

        private void cb_ok_ng_plc_CheckedChanged(object sender, EventArgs e)
        {

          

            if (cb_ok_ng_plc.Checked)
            {

                //true means part is ok 
                TwoBaslerCamera.Service.GlobalItems.ok_ng_piece = false;
                cb_ok_ng_plc.Text = "pulse going on ng ";



            }
            else
            {
                TwoBaslerCamera.Service.GlobalItems.ok_ng_piece = true;
                cb_ok_ng_plc.Text = "no pulse going  ";
            }
        

        }

        private void btn_set_Click(object sender, EventArgs e)
        {

            double ExposureTimeRaw = double.Parse(numeric_exposure_time.Value.ToString());
            long ExposureTimeAbs = 500;// double.Parse(numeric_exposure_time.Value.ToString());
            BaslerCameraApiModule.change_exposer(ExposureTimeRaw, ExposureTimeAbs);

        }

        private void numeric_timer_speed_ValueChanged(object sender, EventArgs e)
        {
            aTimer.Interval = int.Parse(numeric_timer_speed.Value.ToString());
        }

        private void numeric_exposure_time_ValueChanged(object sender, EventArgs e)
        {
            double ExposureTimeAbs = double.Parse(numeric_exposure_time.Value.ToString());
            long ExposureTimeRaw = 500;// double.Parse(numeric_exposure_time.Value.ToString());
            BaslerCameraApiModule.change_exposer(ExposureTimeAbs, ExposureTimeRaw);
        }

        private void timer_camera_status_Tick(object sender, EventArgs e)
        {
             lbl_camera_status.ForeColor = Color.Green;
             lbl_camera_status.Text = "Camera Running ....";
            if (lbl_camera_status.Visible == true)
                lbl_camera_status.Visible = false;
            else
                lbl_camera_status.Visible = true;

        }
    }
}