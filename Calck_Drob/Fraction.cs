using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calck_Drob
{
    class Fraction
    {
        public int denominator, numenator;

        public Fraction(int numenator_1, int denominator_1)
        {
            this.denominator = denominator_1;
            this.numenator = numenator_1;
        }
        //Сокращение nod
        public Fraction Reduced(Fraction fraction)
        {
            int x, y, nod;
            int redused_numerator, redused_denumerator;
            x = Math.Abs(fraction.numenator);
            y = Math.Abs(fraction.denominator);
            if ((x == 0) || (y == 0))
            {
                redused_numerator = 0;
                redused_denumerator = 1;
            }
            else
            {
                while (x != y)
                {
                    if (x > y)
                        x = x - y;
                    else y = y - x;
                }
                nod = x;
                redused_numerator = fraction.numenator / nod;
                redused_denumerator = fraction.denominator / nod;
                if ((redused_numerator < 0) && (redused_denumerator < 0))
                {
                    redused_numerator = Math.Abs(redused_numerator);
                    redused_denumerator = Math.Abs(redused_denumerator);
                }
            }
            
            Fraction result = new Fraction(redused_numerator, redused_denumerator);
            return result;
        }

        //Сумма
        public Fraction Summ(Fraction other)
        {
            int ans_numenator = this.numenator * other.denominator + other.numenator * this.denominator;
            int ans_denomenator = this.denominator * other.denominator;
            Fraction result = new Fraction(ans_numenator, ans_denomenator);
            result = result.Reduced(result);
            return (result);
        }
        public static Fraction operator+(Fraction r1, Fraction r2)
        {
            return r1.Summ(r2);
        }
        //Разница
        public Fraction Subtr(Fraction other)
        {
            int ans_numenator = this.numenator * other.denominator - other.numenator* this.denominator;
            int ans_denomenator = this.denominator * other.denominator;
            Fraction result = new Fraction(ans_numenator, ans_denomenator);
            result = result.Reduced(result);
            return (result);
        }
        public static Fraction operator-(Fraction r1, Fraction r2)
        {
            return r1.Subtr(r2);
        }
        //Умножение
        public Fraction Mult(Fraction other)
        {
            int ans_numenator = this.numenator * other.numenator;
            int ans_denomenator = this.denominator * other.denominator;
            Fraction result = new Fraction(ans_numenator, ans_denomenator);
            result = result.Reduced(result);
            return (result);
        }
        public static Fraction operator*(Fraction r1, Fraction r2)
        {
            return r1.Mult(r2);
        }
        //Деление
        public Fraction Div(Fraction other)
        {
            int ans_numenator = this.numenator * other.denominator;
            int ans_denomenator = this.denominator * other.numenator;
            Fraction result = new Fraction(ans_numenator, ans_denomenator);
            result = result.Reduced(result);
            return (result);
        }
        public static Fraction operator/(Fraction r1, Fraction r2)
        {
            return r1.Div(r2);
        }
        public string ToString()
        {
            string result = Convert.ToString(this.numenator) + "/" + Convert.ToString(this.denominator);
            return result;
        }
        
    }
}
