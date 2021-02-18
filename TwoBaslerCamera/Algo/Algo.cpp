// This is the main DLL file.
#include "stdafx.h"
#include "Algo.h"
#include "ConvertImage.h"
#include "ExecutionTime.h"
#include "opencv2/opencv.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include <list>
#include <time.h>
#include <string>
#include <vector>
#include <iostream>
#include <iostream>
#include <cstdio>
#include <cstdio>
#include <nlohmann/json.hpp>
#include "Utils.h"
using json = nlohmann::json;
using namespace std;
#if DEBUG
#define log(...) {\
    char str[100];\
    sprintf(str, __VA_ARGS__);\
    std::cout << "[" << __FILE__ << "][" << __FUNCTION__ << "][Line " << __LINE__ << "] " << str << std::endl;\
    }
#else
#define log(...)
#endif
using namespace System;
using namespace cv;
namespace cv {
	namespace cuda {
		class Stream::Impl {};
	}
}
Utils  _Utils_obj;
//this  function return string base 64   image 
System::String^ __clrcall Algo::Class1::ProcessImage(System::Drawing::Bitmap^ sourceImage)
{
	try
	{



		return "ok ";
	}//try 
	catch (const std::exception & e)
	{
		const char* err_msg = e.what();
		std::string s = err_msg;
	}//catch 
}//ProcessImage
System::String^ __clrcall Algo::Class1::ProcessImage_on_inputimage_one(System::Drawing::Bitmap^ sourceImage)
{
	try
	{
		cv::Mat source_image = _Utils_obj.BitmapToMat(sourceImage);
		source_image = _Utils_obj.write_counter_on_image(source_image);

		

		cv::putText(source_image, //target image
			_Utils_obj.get_cuurent_time(), //text
			cv::Point(100, 100), //top-left position
			cv::FONT_HERSHEY_DUPLEX,
			2.0,
			CV_RGB(255, 0, 0), //font color
			1);
		//std::cout << std::endl;



		return gcnew System::String("Hello  ");
	}//try 
	catch (const std::exception & e)
	{

		const char* err_msg = e.what();
		std::string s = err_msg;
		return gcnew System::String("from catch block   ");
	}//catch 
}//ProcessImage_on_inputimage_one
System::String^ __clrcall Algo::Class1::ProcessImage_on_inputimage_two(System::Drawing::Bitmap^ sourceImage)
{
	try
	{
		cv::Mat source_image = _Utils_obj.BitmapToMat(sourceImage);
		source_image = _Utils_obj.write_counter_on_image(source_image);

		cv::putText(source_image, //target image
			_Utils_obj.get_cuurent_time(), //text
			cv::Point(100, 100), //top-left position
			cv::FONT_HERSHEY_DUPLEX,
			2.0,
			CV_RGB(255, 0, 0), //font color
			1);
		//std::cout << std::endl;

	




		return gcnew System::String("Hello  ");
	}//try 
	catch (const std::exception & e)
	{
		const char* err_msg = e.what();
		std::string s = err_msg;
		return gcnew System::String("from catch block   ");
	}//catch 
}//ProcessImage_on_inputimage_two