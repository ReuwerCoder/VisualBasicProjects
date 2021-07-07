#include "Odometer.h"

// Definition of static variables mileage and milesDriven
int Odometer::mileage = 0;
int Odometer::milesDriven = -1;

/* **********************************************************
			Odometer::Odometer() - Constructor : int
   ********************************************************** */

Odometer::Odometer(int miles)
{
	if (mileage >= 0 && mileage <= MAX_MILEAGE)
	{
		mileage = miles;
	}
	else
	{
		miles = 0;
	}
}

/* **********************************************************
			Overloaded Postfix ++
	The postfix operator increments the mileage, and decreases
	the FuelGauge object's current amount of fuel by 1 gallon
	for every 24 miles traveled. If mileage reaches 999999, 
	the mileage counter is reset to 0.
   ********************************************************** */

int Odometer::operator ++(int)
{
	if (mileage < MAX_MILEAGE)
	{
		mileage++;

		if (++milesDriven == 24)
		{
			milesDriven = 0;
			gaugeCapacity--;
		}
	}
	else if (mileage >= MAX_MILEAGE)
	{
		mileage = 0;
	}

	return mileage;
}