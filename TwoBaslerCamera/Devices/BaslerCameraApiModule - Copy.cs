using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basler.Pylon;
using System.Drawing.Imaging;
using System.Drawing;
using System.Diagnostics;
using TwoBaslerCamera.Controllers;
using TwoBaslerCamera.Service;

namespace TwoBaslerCamera.Devices
{
    class BaslerCameraApiModule
    {
        const int c_maxCamerasToUse = 5;
        //  static Persistance persistance = new Persistance();
        static List<Camera> cameras = new List<Camera>();
        static PixelDataConverter pxConvert = new PixelDataConverter();
        static bool camera_flag = false;
        static int camera_event_counter = 0;
        static Algo.Class1 cpp = new Algo.Class1();
        static LogWriter _LogWriter = new LogWriter();
        public static bool initialize_camera()
        {
            try
            {
                List<ICameraInfo> allDeviceInfos = CameraFinder.Enumerate(DeviceType.GigE);
                if (allDeviceInfos.Count == 0)
                {
                    throw new ApplicationException("No GigE cameras present.");
                }
                Console.WriteLine("Total no of camera found is " + allDeviceInfos.Count());
                // Open all cameras to fulfill preconditions for Configure(ICamera()) 
                // allDeviceInfos.ForEach(cameraInfo => cameras.Add(new Camera(cameraInfo)));


                try
                {
                    cameras.Add(new Camera(Constants.disk_camera_one));
                    cameras.Add(new Camera(Constants.disk_camera_two));
                    ServiceUtils.Log("    ");
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    ServiceUtils.Log("    ");
              
                }

       
                // cameras.Add(new Camera(Constants.camera_two_sl_no));
                try
                {
                    cameras.ForEach(camera => camera.Open());
                    camera_flag = true;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    ServiceUtils.Log("    ");
                    Program.statring_page.updateLbl("Uanble to open camera ", Color.Red);
                    _LogWriter.LogWrite("Uanble to open camera ");
                    _LogWriter.LogWrite(exp.Message);
                    return false;
                }
                foreach (Camera camera in cameras)
                {
                    Console.WriteLine("Camera Device Information");
                    Console.WriteLine("=========================");
                    Console.WriteLine("Vendor           : {0}", camera.Parameters[PLCamera.DeviceVendorName].GetValue());
                    Console.WriteLine("Model            : {0}", camera.Parameters[PLCamera.DeviceModelName].GetValue());
                    Console.WriteLine("DeviceUserID     : {0}", camera.Parameters[PLCamera.DeviceUserID].GetValue()); //rw
                    Console.WriteLine("Firmware version : {0}", camera.Parameters[PLCamera.DeviceFirmwareVersion].GetValue());
                    String deviceType = camera.CameraInfo[CameraInfoKey.DeviceType];
                    Console.WriteLine("Camera Type      : {0}", deviceType);
                    Console.WriteLine("Serail Number    : {0}.", camera.CameraInfo[CameraInfoKey.SerialNumber]);
                    Console.WriteLine("DeviceIpAddress  : {0}", camera.CameraInfo[CameraInfoKey.DeviceIpAddress]);
                    Console.WriteLine("DeviceMacAddress : {0}.", camera.CameraInfo[CameraInfoKey.DeviceMacAddress]);
                    Console.WriteLine("Height           : {0}", camera.Parameters[PLCamera.SensorHeight].GetValue());
                    Console.WriteLine("Width            : {0}", camera.Parameters[PLCamera.SensorWidth].GetValue());
                    Console.WriteLine();
                    ServiceUtils.Log("    ");
                }//
                foreach (Camera camera in cameras)
                {
                    // set software trigger 
                   // camera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                    camera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Line1);
                    camera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.On);
                    ServiceUtils.Log("    ");
                }
                camera_flag = true;
            }//try block
            catch (Exception e)
            {

                _LogWriter.LogWrite("No GigE cameras present. ");
                _LogWriter.LogWrite(e.Message);
                ServiceUtils.Log("    ");
                Console.Error.WriteLine("Exception: {0}", e.Message);
                if (e.Message.Equals("No GigE cameras present."))
                    Program.statring_page.updateLbl("No GigE cameras present.", Color.Red);
                camera_flag = false; ;
                return false;
            }//catch block 
            // load setting files
            foreach (Camera camera in cameras)
            {
                //camera.Parameters.Load(Global_Items.data_base + "camerasetting.pfs", ParameterPath.CameraDevice);
                Console.WriteLine("minimum packet size " + camera.Parameters[PLCamera.GevSCPSPacketSize].GetMinimum());//220
                Console.WriteLine("maximum packet size " + camera.Parameters[PLCamera.GevSCPSPacketSize].GetMaximum());//16404
                camera.Parameters[PLCamera.GevSCPSPacketSize].SetValue(9000);
                Console.WriteLine("GevSCPSPacketSize  " + camera.Parameters[PLCamera.GevSCPSPacketSize].GetValue());//220
                ServiceUtils.Log("    ");
            }
            foreach (Camera camera in cameras)
            {
                ServiceUtils.Log("    ");
                camera_event_counter += 1;
                if (camera.CanWaitForFrameTriggerReady)
                {
                    // Set a handler for processing the images.
                    if (camera_event_counter == 1)
                        camera.StreamGrabber.ImageGrabbed += OnImageGrabbed_one;
                    if (camera_event_counter == 2)
                        camera.StreamGrabber.ImageGrabbed += OnImageGrabbed_two;
                    if (camera_event_counter == 3)
                        camera.StreamGrabber.ImageGrabbed += OnImageGrabbed_three;
                    if (camera_event_counter == 4)
                        camera.StreamGrabber.ImageGrabbed += OnImageGrabbed_four;
                    // Start grabbing using the grab loop thread. This is done by setting the grabLoopType parameter
                    // to GrabLoop.ProvidedByStreamGrabber. The grab results are delivered to the image event handler OnImageGrabbed.
                    // The default grab strategy (GrabStrategy_OneByOne) is used.
                    camera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                }
                camera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                // Switch on image acquisition
                camera.Parameters[PLCamera.AcquisitionStart].Execute();
                // The camera waits for a trigger signal.
                // When a Frame Start trigger signal has been received,
                // the camera executes an Acquisition Stop command internally.
                // Configure continuous image acquisition on the camera
                camera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
                // Switch on image acquisition
                camera.Parameters[PLCamera.AcquisitionStart].Execute();
            }//for each 
            return true;
        }//initialize_camera
        private static Bitmap GrabResult2Bmp(IGrabResult grabResult)
        {
            //Bitmap b = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
            Bitmap b = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format24bppRgb);
            BitmapData bmpData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);
            // pxConvert.OutputPixelFormat = PixelType.BGRA8packed;
            pxConvert.OutputPixelFormat = PixelType.BGR8packed;
            IntPtr bmpIntpr = bmpData.Scan0;
            pxConvert.Convert(bmpIntpr, bmpData.Stride * b.Height, grabResult);
            b.UnlockBits(bmpData);
            //b.Save("testbmp.bmp");
            return b;
        }
        // Example of an image event handler.
        static Stopwatch sw = new Stopwatch();
        static int counter_img = 0;
        private static void OnImageGrabbed_one(Object sender, ImageGrabbedEventArgs e)
        {
            ServiceUtils.Log("    ");
            //System.Console.Write("\n     1 ");
            //sw.Stop();
            //long time = sw.ElapsedMilliseconds;
            //System.Console.Write("\nElapsed millisecond : " + time);
            //sw = System.Diagnostics.Stopwatch.StartNew();
            IGrabResult grabResult = e.GrabResult;
            // Image grabbed successfully?
            if (grabResult.GrabSucceeded)
            {
                // Global_Items.trigger_counter += 1;
                byte[] buffer = grabResult.PixelData as byte[];
                Bitmap op = (Bitmap)GrabResult2Bmp(grabResult).Clone();
                string result = cpp.ProcessImage_on_inputimage_one(op);


                #region   ------plc code
                //true means part is ok 
                if (TwoBaslerCamera.Service.GlobalItems.ok_ng_piece==false)
                {
                    setCameraonNg();
                }
                #endregion


                Program.statring_page.updatePicBox(op, 1);
            }
            else
            {
                Console.WriteLine("Error: {0} {1}", grabResult.ErrorCode, grabResult.ErrorDescription);
            }
            //cameras[0].Parameters[PLCamera.TriggerSoftware].Execute();
        }//OnImageGrabbed
        private static void OnImageGrabbed_two(object sender, ImageGrabbedEventArgs e)
        {
            ServiceUtils.Log("    ");
            //System.Console.Write("\n     2 ");
            IGrabResult grabResult = e.GrabResult;
            // Image grabbed successfully?
            if (grabResult.GrabSucceeded)
            {
                //  Global_Items.trigger_counter += 1;
                byte[] buffer = grabResult.PixelData as byte[];
                Bitmap op = (Bitmap)GrabResult2Bmp(grabResult).Clone();
                string result = cpp.ProcessImage_on_inputimage_two(op);


                #region   ------plc code
                //true means part is ok 
                if (TwoBaslerCamera.Service.GlobalItems.ok_ng_piece == false)
                {
                    setCameraonNg();
                }
                #endregion

                Program.statring_page.updatePicBox(op, 2);
            }
            else
            {
                Console.WriteLine("Error: {0} {1}", grabResult.ErrorCode, grabResult.ErrorDescription);
                ServiceUtils.Log("    ");
            }
            // cameras[1].Parameters[PLCamera.TriggerSoftware].Execute();
        }
        private static void OnImageGrabbed_three(object sender, ImageGrabbedEventArgs e)
        {
            System.Console.Write("\n     3 ");
            IGrabResult grabResult = e.GrabResult;
            // Image grabbed successfully?
            if (grabResult.GrabSucceeded)
            {
                //Global_Items.trigger_counter += 1;
                //byte[] buffer = grabResult.PixelData as byte[];
                //Bitmap capture_img = GrabResult2Bmp(grabResult);
                //Bitmap op = (Bitmap)GrabResult2Bmp(grabResult).Clone();
                //string result = cpp.ProcessImage_on_inputimage_three(op);
                ////Program.statring_page.updatePicBox(GrabResult2Bmp(grabResult), 3);
                //Program.statring_page.updatePicBox(op, 3);
            }
            else
            {
                Console.WriteLine("Error: {0} {1}", grabResult.ErrorCode, grabResult.ErrorDescription);
            }
            //cameras[2].Parameters[PLCamera.TriggerSoftware].Execute();
        }//OnImageGrabbed_three
        private static void OnImageGrabbed_four(object sender, ImageGrabbedEventArgs e)
        {
            System.Console.Write("\n     4 ");
            IGrabResult grabResult = e.GrabResult;
            // Image grabbed successfully?
            if (grabResult.GrabSucceeded)
            {
                //Global_Items.trigger_counter += 1;
                //byte[] buffer = grabResult.PixelData as byte[];
                //Bitmap capture_img = GrabResult2Bmp(grabResult);
                //Bitmap op = (Bitmap)GrabResult2Bmp(grabResult).Clone();
                //string result = cpp.ProcessImage_on_inputimage_four(op);
                //Program.statring_page.updatePicBox(op, 4);
            }
            else
            {
                Console.WriteLine("Error: {0} {1}", grabResult.ErrorCode, grabResult.ErrorDescription);
            }
            //cameras[3].Parameters[PLCamera.TriggerSoftware].Execute();
        }//OnImageGrabbed_four
        public static void do_software_trigger()
        {
            foreach (Camera camera in cameras)
            {
                camera.Parameters[PLCamera.TriggerSoftware].Execute();
            }
        }//do_software_trigger
        internal static void set_hardware_trigger()
        {
            foreach (Camera camera in cameras)
            {
                camera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Line1);
            }// for loop 
        }//set_hardware_trigger
        internal static void set_software_trigger()
        {
            foreach (Camera camera in cameras)
            {
                camera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
            }// for loop 
        }//set_hardware_trigger
        public static void stop_camera()
        {
            // Stop stream grabber and close all cameras. 
            try
            {
                foreach (Camera camera in cameras)
                {
                    camera.StreamGrabber.Stop();
                    Console.WriteLine("camera.StreamGrabber.Stop()");
                    camera.Close();
                    Console.WriteLine("camera.Close");
                }
                for (int i = 0; i < cameras.Count(); i++)
                {
                    cameras[i] = null;
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Exception: {0}", e.Message);
            }
        }//stop_camera
        public static void change_exposer(double ExposureTimeAbs, long ExposureTimeRaw)
        {
            foreach (Camera camera in cameras)
            {
                camera.Parameters[PLCamera.ExposureTimeAbs].SetValue(ExposureTimeAbs);
                camera.Parameters[PLCamera.ExposureTimeRaw].SetValue(ExposureTimeRaw);
                //Console.WriteLine(" abs  " + camera.Parameters[PLCamera.ExposureTimeAbs].ToString());
                //Console.WriteLine(" raw  " + camera.Parameters[PLCamera.ExposureTimeRaw].ToString());
            }
        }//stop_camera



        public static void setCameraonNg()
        {

            foreach (Camera camera in cameras)
            {
                
                camera.Parameters[PLCamera.LineSelector].SetValue(PLCamera.LineSelector.Line2);
              //  camera.Parameters[PLCamera.LineSource].SetValue(PLCamera.LineSource.FlashWindow);
                camera.Parameters[PLCamera.UserOutputSelector].SetValue(PLCamera.UserOutputSelector.UserOutput1);
                camera.Parameters[PLCamera.UserOutputValue].SetValue(true);
                camera.Parameters[PLCamera.UserOutputSelector].SetValue(PLCamera.UserOutputSelector.UserOutput1);
                camera.Parameters[PLCamera.UserOutputValue].SetValue(false);
            }


        }




    }
}