#include <iostream>

using namespace std;

void f(int b){
    b++;
    cout << "b:" << b << endl;
}

void g(int b){
    b++;
    cout << "b:" << b << endl;
}



int main(){
            int n = 6;
    int& Rn = n;
    
    Rn++;
    cout << "Rn : " << Rn << ", n : " << n << endl;

    f(n);

    cout << "Rn : " << Rn << ", n : " << n << endl;

    g(n);

    cout << "Rn : " << Rn << ", n : " << n << endl;

    return 0;
}