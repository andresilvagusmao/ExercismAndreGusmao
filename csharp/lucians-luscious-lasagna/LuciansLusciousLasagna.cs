class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
    }
    public int RemainingMinutesInOven(int minPassed){
        return 40-minPassed;
    }
    public int PreparationTimeInMinutes(int layers){
        return layers*2;
    }
    public int ElapsedTimeInMinutes(int layers, int minPassed){
        return minPassed + PreparationTimeInMinutes(layers);
    }
}
