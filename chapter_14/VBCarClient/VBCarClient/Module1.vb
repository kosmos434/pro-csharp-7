Imports CarLibrary
Module Module1

    Sub Main()
        Console.WriteLine("fun with visual basic 🙄")
        ' this is how you comment in vb
        ' variables are declared below
        Dim myMiniVan As New MiniVan()
        myMiniVan.TurboBoost()

        Dim mySportyCa As New SportsCar()
        mySportyCa.TurboBoost()

        Dim perfCar As New PerformanceCar()
        ' Use inherited prperty
        perfCar.PetName = "Car-o"
        perfCar.TurboBoost()
        Console.ReadLine()

    End Sub

End Module
