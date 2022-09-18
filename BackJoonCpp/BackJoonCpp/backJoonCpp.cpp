#include <iostream>


int main()
{
	int a, num = 0;
	std::cin >> a;

	for (int i = 0; i <= a; i++)
	{
		num += i;
	}
		
	std::cout << num << std::endl;

	return 0;
}