
/**
 **@author selim
*/

namespace CSharpprogram {
  
  class Complex {
    
    public int A { get; set; }
    public int B { get; set; }
    
    public int GetA() {
      return this.A;
    }
    
    // GETTERS &&&&& SETTERS old way ;)
    
    /*
    public void SetA(int A) {
      this.A = A;
    }
    
    public int GetB() {
      return this.B;
    }
    
    public void SetB(int B) {
      this.B = B;
    }
    */
    
    public Complex(int A, int B) {
      this.A = A;
      this.B = B;
    }
    
    public override string ToString() {
      return " (" + this.A + ", " + this.B + ") ";
    }
    
    public double GetMagnitude() {
      return Math.Sqrt(this.A + this.B);
    }
    
    public int Sum(Complex c1, Complex c2) {
      this.A =  c1.GetA() + c2.GetB();
      this.B = c1.B + c2.B;
      return this.A + this.B;
    }
    
    
    
  }
  
}



