using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TwoBaslerCamera.Statics
{
    class GlobalItems
    {
        public static string icon { get; set; } = get_data_base_folder_location() + @"\iconNew.ico";
        public static DirectoryInfo database = new DirectoryInfo(get_data_base_folder_location());
        public static string get_data_base_folder_location()
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = Path.GetFullPath(Path.Combine(path, @"..\..\database"));
            Console.WriteLine("data base path is " + path);
            return path;

        }//get_exe_location()

        public static string default_image_path { get; set; } = get_data_base_folder_location() + @"\model_image.bmp";
        public static int ExposureTimeAbs { get; internal set; }
        public static int ExposureTimeRaw { get; internal set; }

        static public string report_data = Path.GetFullPath(Path.Combine(get_data_base_folder_location(), @"..\"));

        public static int inner_crop_counter = 0;

    }
}
