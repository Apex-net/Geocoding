Module Module1

    Sub Main()

        Dim lat As Double
        Dim lon As Double
        Dim RetValue As Boolean

        Dim clArgs() As String = Environment.GetCommandLineArgs()

        If clArgs.Count() <> 2 Then

            Console.WriteLine("Usage: Geocoding: <Address>")
        Else
            RetValue = Geocoding.GetCoordinate(clArgs(1), lat, lon)
            If Not RetValue Then
                Console.WriteLine("KO: Error: There was an error for [" + clArgs(1) + "]")
            Else
                Console.WriteLine("OK: Lat: " + lat.ToString() + ", Lon:" + lon.ToString())
            End If
        End If




    End Sub

End Module
