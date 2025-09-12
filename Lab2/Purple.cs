using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            
            for (int i = 0; i < n; i++)
            {
                int el = p + i * h;
                answer += el * el;
            }

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            quotient = a / b;
            remainder = a - quotient * b;

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            double ch1 = 2;
            double zn1 = 1;
            double ch2 = 3;
            double zn2 = 2;

            while (true)
            {
                double cha = ch1 + ch2;
                double zna = zn1 + zn2;
                
                answer = cha / zna;

                double dif = Math.Abs(answer - (ch2 / zn2));

                if (dif < E)
                {
                    return answer;
                }

                ch1 = ch2;
                zn1 = zn2;
                ch2 = cha;
                zn2 = zna;
            }
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double s = b;

            while (Math.Abs(s) >= E)
            {
                answer++;
                s = (b * Math.Pow(q, answer));
            }

            return answer += 1;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;

            while (b > 0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }

            return answer;
        }
        public ulong Task6()
        {
            ulong answer = 0;
            ulong s = 0;
            ulong k = 1;

            for (int i = 1; i <= 64; i++)
            {
                s += k;
                k *= 2;
            }
            
            answer = s / 15000000;

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double S2 = S * 2;
            double startYear = S;
            double pr = startYear * d / 12.0 / 100.0;
            int mounthKol = 0; 
            
            while (S < S2)
            {
                S += pr;
                answer++;
                mounthKol++;
                
                if (mounthKol == 12)
                {
                    startYear = S;
                    pr = startYear * (d / 12.0 / 100.0);
                    mounthKol = 0;
                }
            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
