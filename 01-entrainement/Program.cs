// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Le but était de m'entraîner sur différentes choses: array, boucle while, boucle for
// J'ai aussi voulu utiliser la même variable i à 2 endroits différents, pour me servir du concept du scope

int[] array = new int[3];

{
 int i = 0;
 int answer = 0;
 while (i < array.Length)
 {
  Console.WriteLine($"Choisissez un nombre entre 1 et 50 ({i}):");
  answer = Convert.ToInt32(Console.ReadLine());

  if (i <= 50 || i >= 1)
  {
   Console.WriteLine("Noté!");
   array[i] = answer;
   i++;
  }
  else
  {
   Console.WriteLine("Vous devez sélectionner un nombre entre 1 et 50!!");
  }
 }

}

Console.WriteLine("Vous avez sélectionné:");

{
 for (int i = 0; i < array.Length; i++)
 {
  Console.WriteLine(array[i]);
 }
}