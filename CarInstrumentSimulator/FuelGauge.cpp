#include "FuelGauge.h"

// Definition of fuelCapacity
int FuelGauge::fuelCapacity = 0;

/* **********************************************************
			Overloaded ++ operator
	********************************************************** */

int FuelGauge::operator ++(int)
{
	if (fuelCapacity < MAX_CAPACITY)
	{
		fuelCapacity++;
	}
	else
	{
		fuelCapacity = MAX_CAPACITY;
	}

	return fuelCapacity;
}

/* **********************************************************
			Overloaded -- operator
   ********************************************************** */

int FuelGauge::operator --(int)
{
	if (fuelCapacity > 0)
	{
		fuelCapacity--;
	}
	else
	{
		fuelCapacity = 0;
	}
	
	return fuelCapacity;
}