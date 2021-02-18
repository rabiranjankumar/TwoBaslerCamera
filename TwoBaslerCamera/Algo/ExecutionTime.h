#pragma once
#pragma once
#include <opencv2/opencv.hpp>
#include<opencv2/core.hpp>
#include <opencv2/imgcodecs.hpp>
#include <chrono>
#include <cstdint>
#include <vector>
#include <string>
using namespace std;
using namespace cv;
#ifndef Mytime_H_
#define Mytime_H_
class Mytime {


private:

public:

	Mytime();
    long long  start_time();
	long long  end_time(long long   time);
	virtual ~Mytime();

};

#endif 
