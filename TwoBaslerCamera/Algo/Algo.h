// Algo.h

#pragma once

using namespace System;

namespace Algo {

	public ref class Class1
	{
	public:
	
		System::String ^ __clrcall Algo::Class1::ProcessImage(System::Drawing::Bitmap ^ sourceImage);	 
		System::String^ __clrcall Algo::Class1::ProcessImage_on_inputimage_one(System::Drawing::Bitmap^ sourceImage);
		System::String^ __clrcall Algo::Class1::ProcessImage_on_inputimage_two(System::Drawing::Bitmap^ sourceImage);

		static int result = 0;
		property int result_get_set //result 
		{
			int get()
			{
				return result;
			}
			void set(int  value)
			{
				result = value;
			};
		};//result_get_set


		static int threshold = 0;
		property int threshold_get_set //threshold_get_set 
		{
			int get()
			{
				return threshold;
			}
			void set(int  value)
			{
				threshold = value;
			};
		};//threshold_get_set



	
	};
}
