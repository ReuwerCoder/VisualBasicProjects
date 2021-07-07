#ifndef ODOMETER_H_
#define ODOMETER_H_

#include "FuelGauge.h"

class Odometer
{
	private:
		const int MAX_MILEAGE = 999999;	// The maximum mileage an odometer can display

		static int mileage;					// Holding the mileage of a car
		static int milesDriven;				// Counter variable

		// Class object
		FuelGauge gaugeCapacity;

	public:
		Odometer()
		{ }

		Odometer(int);

		int getMilesDriven() const
		{ return milesDriven; }

		int getCurrentMileage() const
		{ return mileage; }

		// Overloaded operator function
		int operator ++(int);				// Postfix ++
};

#endif