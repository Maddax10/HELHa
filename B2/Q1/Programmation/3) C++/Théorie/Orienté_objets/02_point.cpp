#include <iostream>
#include <cmath>

using namespace std;

class Point
{

    double x, y;

    //Constructeur obligé d'être en public car il ne l'est pas de base
public:
    Point(double x, double y)
    {
        this->x = x;
        this->y = y;
    }

    //Inline permet de dire au compilateur d'appeler directement la fonction getX() et de renvoyer x directement (c'est le compilateur qui gère çà)
    //Ca permet de gagner du temps
    inline double getX()
    {
        return this->x;
    }

    inline double getY()
    {
        return this->y;
    }

    double dist(Point p)
    {
        return sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
    }
};

int main()
{
    Point p1(5.0, 10); //Point automatiquement créé
    cout << p1.getX() << " " << p1.getY() << endl;

    Point p2(9, 0); //Point automatiquement créé
    cout << p2.getX() << " " << p2.getY() << endl;

    Point *p3 = new Point(4.32, 5.7);
    cout << (*p3).getX() << " " << (*p3).getY() << endl;

    delete p3;

    return 0;
}