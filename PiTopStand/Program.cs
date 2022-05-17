using PiTop;
using PiTopMakerArchitecture.Foundation;

var board = PiTop4Board.Instance;
var plate = new FoundationPlate(board);

var greenLed = plate.GetOrCreateLed(DigitalPort.D0);
var yellowLed = plate.GetOrCreateLed(DigitalPort.D1);
var redLed = plate.GetOrCreateLed(DigitalPort.D2);

greenLed.On();
yellowLed.On();
redLed.On();

Console.WriteLine("Pausing");

await Task.Delay(5000);

Console.WriteLine("Exiting");

for (int i = 0; i < 7; i++)
{
    greenLed.Toggle();
    yellowLed.Toggle();
    redLed.Toggle();

    await Task.Delay(500);
}

var leftToRight = async (int duration) =>
{
    greenLed.Toggle();
    await Task.Delay(duration);

    greenLed.Toggle();
    yellowLed.Toggle();
    await Task.Delay(duration);

    yellowLed.Toggle();
    redLed.Toggle();
    await Task.Delay(duration);
    redLed.Toggle();
    await Task.Delay(duration);
};

var rightToLeft = async (int duration) =>
{
    redLed.Toggle();
    await Task.Delay(duration);

    redLed.Toggle();
    yellowLed.Toggle();
    await Task.Delay(duration);

    yellowLed.Toggle();
    greenLed.Toggle();
    await Task.Delay(duration);
    greenLed.Toggle();
    await Task.Delay(duration);
};

while(true)
{
    await leftToRight(100);
    await rightToLeft(100);
}

Console.WriteLine("Continuing");

greenLed.Off();
yellowLed.Off();
redLed.Off();