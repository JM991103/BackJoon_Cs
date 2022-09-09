#include <iostream>
using namespace std;

int main()
{
	int H, M, m;
	cin >> H >> M;
	cin >> m;

	int Max = (H * 60) + M + m;

	H = (Max / 60) % 24;
	M = Max % 60;

	cout << H << " " << M << endl;
}