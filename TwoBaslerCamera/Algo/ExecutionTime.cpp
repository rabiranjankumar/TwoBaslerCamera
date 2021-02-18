#include "stdafx.h"
#include "ExecutionTime.h"


#include <list>
#include <time.h>
#include <string>
#include <vector>
#include <iostream>

#include <iostream>
#include <cstdio>
#include <cstdio>
#include <nlohmann/json.hpp>
using json = nlohmann::json;
using namespace System;
using namespace std;
using namespace cv;


Mytime::Mytime() {}


long long  Mytime::start_time()
{

	using namespace std::chrono;
	long long   milli= duration_cast<milliseconds>(system_clock::now().time_since_epoch()).count();
	////3600000 milliseconds in an hour
	//long hr = milli / 3600000;
	//milli = milli - 3600000 * hr;
	////60000 milliseconds in a minute
	//long min = milli / 60000;
	//milli = milli - 60000 * min;

	////1000 milliseconds in a second
	//long sec = milli / 1000;
	//milli = milli - 1000 * sec;

	//Console::WriteLine(" hr   {0} ", hr);
	//Console::WriteLine(" minute   {0} ", min);
	//Console::WriteLine(" second   {0} ", sec);
	//Console::WriteLine(" milli   {0} ", milli);

	return milli;
}

long long Mytime::end_time(long long time)
{
	using namespace std::chrono;
	long long   milli = duration_cast<milliseconds>(system_clock::now().time_since_epoch()).count();

	//Console::WriteLine(" total time in millisecond    {0} ", milli-time);

	return milli;
}

Mytime::~Mytime()
{
}
