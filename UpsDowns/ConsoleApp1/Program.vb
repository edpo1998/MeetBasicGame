Imports System

Module Program
    Sub Main(args As String())

        Dim cki As ConsoleKeyInfo
        Dim val As Integer = 0
        Dim config As New Configuration()
        ' Menu de Configuracion
        While True
            Console.WriteLine("#############################")
            Console.WriteLine("#    1. Game difficulty     #")
            Console.WriteLine("#    2. Initial Parameters  #")
            Console.WriteLine("#    3. Start Game          #")
            Console.WriteLine("#    4. Exit                #")
            Console.WriteLine("#############################")
            Console.WriteLine()
            Console.Write("Ingrese el Parametro a Seleccionar: ")
            val = Integer.Parse(Console.ReadLine())
            Console.WriteLine()
            Select Case (val)
                Case 1
                    Console.WriteLine("Caso 1")
                Case 2
                    Console.WriteLine("Caso 2")
                Case 3
                    If config.Verify() Then
                        Do While (cki.Key <> ConsoleKey.Escape)
                            Dim Dado As New Dice(6)
                            Dado.ThrowDice()
                            cki = Console.ReadKey()
                            If (cki.Key = ConsoleKey.Enter) Then
                                Console.WriteLine("Se presiono Enter")
                            End If
                        Loop
                    End If
                Case 4
                    Exit While
            End Select

        End While
    End Sub
End Module
