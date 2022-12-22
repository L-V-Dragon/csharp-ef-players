using csharp_ef_players;

using (PlayerContext db = new PlayerContext())
{
    Random random = new Random();
    double voto = random.Next(1, 10 + 1);
    int numeroPartiteGiocate = random.Next(1, 101);
    int numeroPartiteVinte = random.Next(1, numeroPartiteGiocate + 1);


    Player newPlayer = new Player { Name = "Kylian", Surname = "Mbappe", score = voto, GamePlayed = numeroPartiteGiocate, GameWon = numeroPartiteVinte};
    /*db.Add(newPlayer);
    db.SaveChanges();*/

    /*List<Player> Players = db.Players.OrderBy(Player => Player.Name).ToList<Player>();*/

    /*newPlayer.Name = "Lionel";
    newPlayer.Surname = "Messi";
    db.SaveChanges();*/

    /*db.Remove(newPlayer);
    db.SaveChanges();*/
}


Console.WriteLine("Hello, World!");