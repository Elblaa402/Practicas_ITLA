
#include <iostream>

using namespace std;

class mensaje
{
public:
	void mostrar() 
	{ cout << "Hola, mundo!" << endl; }

};

int main()
{
	mensaje m;
	m.mostrar();
	return 0;
}

