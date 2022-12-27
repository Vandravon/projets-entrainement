// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("***Bienvenue dans le Quizz!!***");

var random = new Random();
int randQuestion = 0;
bool rightAnswer = false;
int countRightAnswer = 0;

string[] question = { " ", "Quelle est la capitale de la France?", "Quelles sont les couleurs primaires?", "De quelle ville les quenelles sont-elles la spécialité?", "Quelle entreprise est derrière .Net?", "Sur quelle console est sorti initialement le jeu Chrono Trigger?", "Trouvez l'intru:" };
int[] alreadyAskedQuestions = new int[(question.Length / 2)];


for (int i = 1; i <= ((question.Length - 1) / 2); i++)
{

 do
 {
  randQuestion = random.Next(1, question.Length);

 } while (alreadyAskedQuestions.Contains(randQuestion));


 alreadyAskedQuestions[(i - 1)] = randQuestion;

 Console.WriteLine(question[randQuestion]);

 if (randQuestion == 1)
 {
  Console.WriteLine("a- Berlin \nb- Paris \nc- Lyon");
 }
 else if (randQuestion == 2)
 {
  Console.WriteLine("a- Rouge Vert Bleu \nb- Rouge Vert Jaune \nc- Rouge Jaune Bleu");
 }
 else if (randQuestion == 3)
 {
  Console.WriteLine("a- Lyon \nb- Saint-Etienne \nc- Barcelone");
 }
 else if (randQuestion == 4)
 {
  Console.WriteLine("a- Microsoft \nb- Google \nc- Facebook");
 }
 else if (randQuestion == 5)
 {
  Console.WriteLine("a- Nintendo NES \nb- Nintendo 64 \nc- Super Nintendo");
 }
 else if (randQuestion == 6)
 {
  Console.WriteLine("a- Linux \nb- Apple \nc- Windows");
 }

 Console.WriteLine("Votre réponse: ");
 string? answer = Console.ReadLine().ToLower();

 // Question 1
 if (randQuestion == 0 && answer == "b")
 {
  rightAnswer = true;
  countRightAnswer++;
 }

 // Question 2
 if (randQuestion == 1 && answer == "c")
 {
  rightAnswer = true;
  countRightAnswer++;
 }

 // Question 3
 if (randQuestion == 2 && answer == "a")
 {
  rightAnswer = true;
  countRightAnswer++;
 }

 // Question 4
 if (randQuestion == 3 && answer == "a")
 {
  rightAnswer = true;
  countRightAnswer++;
 }

 // Question 5
 if (randQuestion == 4 && answer == "c")
 {
  rightAnswer = true;
  countRightAnswer++;
 }

 // Question 6
 if (randQuestion == 5 && answer == "b")
 {
  rightAnswer = true;
  countRightAnswer++;
 }

 // Affichage du résultat
 switch (rightAnswer)
 {
  case true:
   Console.WriteLine("Bonne réponse!");
   break;
  case false:
   Console.WriteLine("Mauvaise réponse!");
   break;
 }

 if (answer != "a" && answer != "b" && answer != "c")
 {
  Console.WriteLine("Et vous avez mis une réponse hors-propos!");
 }

 rightAnswer = false;

//  for (int j = 0; j < alreadyAskedQuestions.Length; j++)
//  {
//   Console.WriteLine(alreadyAskedQuestions[j]);
//  }

}

Console.WriteLine($"\nBonnes réponses totales: {countRightAnswer} sur {question.Length / 2}");
