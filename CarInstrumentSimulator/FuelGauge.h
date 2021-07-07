#ifndef FUEL_GAUGE_H_
#define FUEL_GAUGE_H_

class FuelGauge
{
	private:
		const  int MAX_CAPACITY = 15;		// The max fuel capacity
		static int fuelCapacity;			// Holds the fuel capacity

	public:
		FuelGauge()
		{ }

		int getFuelCapacity() const
		{ return fuelCapacity; }

		// Overloaded operator functions
		int operator ++(int);				// Postfix ++
		int operator --(int);				// Postfix --
};

#endif