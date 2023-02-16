string inputPlayer,inputCPU;
int randomInt;

bool Playagain =true;
while(Playagain)
{
    int CpuScore =0;
    int PlayerScore =0;
while(PlayerScore<3 && CpuScore<3)
{
Console.WriteLine("Choose between ROCK,PAPER and SCISSORS: ");
inputPlayer =Console.ReadLine();
Random rnd =new Random();
randomInt=rnd.Next(1,4);

switch(randomInt)
{
    case 1:
           inputCPU ="ROCK";
           Console.WriteLine("Computer choose ROCK");
           if(inputPlayer == "ROCK")
           {
            Console.WriteLine("Draw! \n\n");
           }
           else if(inputPlayer == "PAPER"){
                Console.WriteLine("PLAYER WINS \n\n");
                PlayerScore++;
           }
           else if(inputPlayer == "SCISSORS"){
                Console.WriteLine("CPU WINS \n\n");
                CpuScore++;
           }

           break;
    case 2:
           inputCPU ="PAPER";
           Console.WriteLine("Computer choose PAPER");
           if(inputPlayer == "PAPER")
           {
            Console.WriteLine("Draw! \n\n");
           }
           else if(inputPlayer == "SCISSORS"){
                Console.WriteLine("PLAYER WINS \n\n");
                PlayerScore++;
           }
           else if(inputPlayer == "ROCK"){
                Console.WriteLine("CPU WINS \n\n");
                CpuScore++;
           }
           break;
    case 3:
           inputCPU ="SCISSORS";
           Console.WriteLine("Computer choose SCISSORS");
           if(inputPlayer == "SCISSORS")
           {
            Console.WriteLine("Draw! \n\n");
           }
           else if(inputPlayer == "ROCK"){
                Console.WriteLine("PLAYER WINS \n\n");
                PlayerScore++;
           }
           else if(inputPlayer == "PAPER"){
                Console.WriteLine("CPU WINS \n\n");
                CpuScore++;
           }
           break;
    default:
           Console.WriteLine("Invalid entry!");
           break;
           
}//switch loop
  Console.WriteLine("\n\n SCORES: \tPLAYER:{0}\t CPU:\t{1}",PlayerScore,CpuScore);
}// while guess win
if(PlayerScore == 3)
{
    Console.WriteLine("Player win!");
}
else if(CpuScore == 3)
{
    Console.WriteLine("CPU WINS!");
}

Console.WriteLine("DO you want to play again: yes/no");
string loop = Console.ReadLine();
if(loop == "YES")
{
    Playagain =true;
    Console.Clear();
}
else if(loop =="NO"){
    Playagain=false;
}
else{

}
} //play again loop


