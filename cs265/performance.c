#include <stdio.h>
#include <time.h>

/*
 * This program is based on the C99 standard. To compile
 * with GCC, use the following command:
 *		gcc -std=c99 performance.c
 *
 * Author: Jake Petroules
 * Date: 2010-10-27
 */

void runAddition(long long iterations)
{
	volatile long long temp;
	for (long long i = 1; i <= iterations; i++)
	{
		temp = temp + i;
	}
}

void runDivision(long long iterations)
{
	volatile long long temp;
	
	// Start at 1 to avoid division by 0!
	for (long long i = 1; i <= iterations; i++)
	{
		temp = temp / i;
	}
}

int main()
{
	long long iterations = 1000000000;
	time_t startTime;
	
	printf("This program measures the performance of addition and division operations, executing each a specified number of times and comparing the total time spent. On my tests, division takes approximately 3-4 times as long as addition.\n");
	printf("How many iterations would you like to run of each operation? ");
	scanf("%d", &iterations);
	
	printf("Running %d additions...\n", iterations);
	startTime = time(NULL);
	runAddition(iterations);
	printf("%lld additions took %g seconds\n", iterations, difftime(time(NULL), startTime));
	
	printf("Running %d divisions...\n", iterations);
	startTime = time(NULL);
	runDivision(iterations);
	printf("%lld divisions took %g seconds\n", iterations, difftime(time(NULL), startTime));
}