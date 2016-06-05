#include "complex.h"

Complex::Complex(){
	i=r=0;
}

Complex::Complex(const Complex& from){
	i=from.i;
	r=from.r;
}

Complex::Complex(double r,double i){
	this->r = r;
	this->i = i;
}

Complex Complex::operator+(Complex with){
	return Complex(r+with.r,i+with.i);
}

Complex Complex::operator-(Complex with){
	return Complex(r-with.r,i-with.i);
}

Complex Complex::operator*(Complex with){
	return Complex(r*with.r-i*with.i,r*with.i+i*with.r);
}

Complex Complex::operator/(Complex with){
	double d = with.i*with.i + with.r*with.r;
	return Complex((r*with.r-i*with.i)/d,(i*with.r-r*with.i)/d);
}

void Complex::operator=(const Complex& with){
	i=with.i;
	r=with.r;
}

void Complex::operator=(double r){
	i=0;
	this->r=r;
}

bool Complex::operator==(Complex w){
	return w.r==r && w.i==i;
}

bool Complex::operator!=(Complex w){
	return w.r!=r || w.i!=i;
}

std::ostream& operator<<(std::ostream& os, Complex& r){
	os<<r.r;
	if(r.i!=0)
		os<<"+i*"<<r.i;
	
	return os;
}
std::istream& operator>>(std::istream& is, Complex& r){
	is>>r.r;
	if(is.peek() == '+'){
		is.get();
		is.get();
		is.get();
		is>>r.i;
	}
	
	return is;
}