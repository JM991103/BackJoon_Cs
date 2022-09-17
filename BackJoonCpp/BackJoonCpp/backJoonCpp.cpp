#include <iostream>


int main()
{
	int a, num;
	std::cin >> a;

	for (int i = 1; i <= a; i++)
	{
		int b, c;
		std::cin >> b >> c;
		num = b + c;
		std::cout << num << std::endl;
	}
		
	return 0;
}