Imports System

Module Program
    Sub Main(args As String())
        Dim xl As Double
        Dim xc As Double
        Dim radianes As Double
        Dim grados As Double
        Dim xt As Double
        Dim zt As Double
        Dim pi As Double = 3.1416
        Dim inductancia As Double
        Dim capacitancia As Double
        Dim resistencia As Double
        Dim resonancia As Double
        Dim frecuencia As Double

        Console.WriteLine("Escriba el valor de la frecuencia")
        frecuencia = Console.ReadLine()
        Console.WriteLine("Escriba el valor de la inductancia")
        inductancia = Console.ReadLine()
        Console.WriteLine("Escriba el valor de la capacitancia")
        capacitancia = Console.ReadLine()
        Console.WriteLine("Escriba el valor de la resistencia")
        resistencia = Console.ReadLine()

        xl = 2 * pi * frecuencia * inductancia
        xc = 1 / (2 * pi * frecuencia * capacitancia)
        xt = xl - xc
        radianes = Math.Atan(xt / resistencia)
        grados = radianes * 180 / pi
        zt = Math.Sqrt((resistencia) ^ 2 + (xt) ^ 2)
        resonancia = 1 / (2 * pi * Math.Sqrt(inductancia * capacitancia))

        Console.WriteLine("El valor de la reactancia inductiva es:" & xl)
        Console.WriteLine("El valor de la reactancia capacitiva es:" & xc)
        Console.WriteLine("El valor de la reactancia total:" & xt)
        Console.WriteLine("El valor total de la impedancia es:" & zt)
        Console.WriteLine("El valor total de grados es:" & grados)
        Console.WriteLine("el valor de resonancia es:" & resonancia)
        If (grados > 0) Then
            Console.WriteLine("El circuito es inductivo")
        ElseIf (grados < 0) Then
            Console.WriteLine("El circuito es capacitivo")
        End If
    End Sub
End Module
