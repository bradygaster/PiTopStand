using PiTop;
using PiTopMakerArchitecture.Foundation;

var board = PiTop4Board.Instance;
var plate = new FoundationPlate(board);

var greenLed = plate.GetOrCreateLed(DigitalPort.D0);
var blueLed = plate.GetOrCreateLed(DigitalPort.D1);
var redLed = plate.GetOrCreateLed(DigitalPort.D2);

greenLed.On();
blueLed.On();
redLed.On();

Console.WriteLine("Hit enter to exit");
Console.ReadLine();
Console.WriteLine("Exiting");