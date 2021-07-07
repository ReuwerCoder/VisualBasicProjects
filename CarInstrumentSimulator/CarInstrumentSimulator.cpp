#include "FuelGauge.h"
#include "Odometer.h"

#include <iomanip>
using std::left;
using std::right;
using std::setw;

#include <iostream>
using std::cin;
using std::cout;

void timer();
void refillTank(FuelGauge &);
void instrumentSimulator(Odometer &, const FuelGauge &);

int main()
{
	FuelGauge gauge;
	Odometer meter(999998);

	cout << "CAR INSTRUMENT SIMULATOR\n\n";

	refillTank(gauge);
	instrumentSimulator(meter, gauge);

	cin.get();
	cin.ignore();
	return 0;
}

/* **********************************************************
			refillTank() : obj &
	This function accepts a FuelGauge object passed to it by
	reference as argument. It simulates a refueling process.
   ********************************************************** */

void refillTank(FuelGauge &gauge)
{
	cout << "Fuel meter E |";

	for (int i = gauge.getFuelCapacity(); i < 15; i++)
	{
		gauge++;
		timer();

		cout << (i + 1) << "*|";
	}

	cout << " F\n\n";
}

/* **********************************************************
			instrumentSimulator() : obj &, const obj &
	This function simulates the main instrument panel of a
	car. It outputs the current mileage driven and current
	gauge capacity. 
   ********************************************************** */

void instrumentSimulator(Odometer &meter, const FuelGauge &gauge)
{
	while (gauge.getFuelCapacity() >= 1)
	{
			meter++;

			if (gauge.getFuelCapacity() >= 3)
			{
				cout << "Miles Driven: " << setw(25) << left << meter.getCurrentMileage();
				cout << "Gas Gauge: " << right << gauge.getFuelCapacity() << "\n";
			}
			else if (gauge.getFuelCapacity() > 0 && gauge.getFuelCapacity() <= 3)
			{
				cout << "Miles Driven: " << setw(25) << left << meter.getCurrentMileage();
				cout << "Gas Gauge: "    << right << gauge.getFuelCapacity() << " FUEL LOW!\n";
			}
			else if (gauge.getFuelCapacity() == 0)
			{
				cout << "\nOUT OF FUEL!\n";
			}

			timer();
	}
}

/* **********************************************************
			timer()
	A very simple timer function.
   ********************************************************** */

void timer()
{
	static int seconds = 5;
	static int timeLeft = 0;
	static int counter = 193559599;

	while (timeLeft > 0)
	{
		timeLeft--;
	}

	timeLeft = counter - seconds;
}