using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividades_OB;

interface IFigura
{
    double calcularArea();
}

class Figura : IFigura
{
    public virtual double calcularArea()
    {
        return 0;
    }
}

class Triangulo : Figura
{
    private double baseTriangulo;
    private double altura;

    public Triangulo(double baseTriangulo, double altura)
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }

    public override double calcularArea()
    {
        return (baseTriangulo * altura) / 2;
    }
}

class Circulo : Figura
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public override double calcularArea()
    {
        return Math.PI * Math.Pow(raio, 2);
    }
}

class Retangulo : Figura
{
    private double baseRetangulo;
    private double altura;

    public Retangulo(double baseRetangulo, double altura)
    {
        this.baseRetangulo = baseRetangulo;
        this.altura = altura;
    }

    public override double calcularArea()
    {
        return baseRetangulo * altura;
    }
}

    class Program
{
    static void Main(string[] args)
    {
        Form1 form = new Form1();
        form.ShowDialog();
    }
}
