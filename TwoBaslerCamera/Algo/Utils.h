#pragma once
#ifndef Utils_H
#define Utils_H 
#include<iostream>
#include "opencv2/opencv.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/highgui.hpp"
#include <list>
#include <time.h>
#include <string>
#include <vector>
#include <iostream>
#include <nlohmann/json.hpp>
using json = nlohmann::json;
public class Utils
{


private:
	int  image_counter;

public:
	std::string Utils::get_cuurent_time();

	void write_log(const std::string& msg);

	std::vector<std::string> get_directories(const std::string& s);
	void Utils::image_details(std::string string_name, cv::Mat img);
	void show_resize_image_auto(std::string string_name, cv::Mat img);
	cv::Mat write_counter_on_image(cv::Mat img);
	void Utils::show_resize_image(std::string string_name, cv::Mat img);

	cv::Mat Utils::BitmapToMat(System::Drawing::Bitmap^ bitmap);


};
#endif