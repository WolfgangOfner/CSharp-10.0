// GlobalUsing
// using is defined in GlobalUsings.cs
var nullParameterChecking = new NullParameterChecking();

// RecordStruct
var coordinate = new Coordinate(1, 2, 3);
Console.WriteLine($"x: {coordinate.X}, y: {coordinate.Y}, z: {coordinate.Z}");

// NullParameterChecking
nullParameterChecking.SomeMethod("my string");