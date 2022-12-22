using csharp_ef_players;

using (PlayerContext db = new PlayerContext())
{
    Random random = new Random();
    double voto = random.Next(1, 10 + 1);
    int numeroPartiteGiocate = random.Next(1, 101);
    int numeroPartiteVinte = random.Next(1, numeroPartiteGiocate + 1);

    Team team = new Team { NameTeam = "Manchester City", City = "Manchester", Coach = "Guardiola", Colors = "Light Blue and White"};

    Player newPlayer1 = new Player { Name = "Erling", Surname = "Haaland", score = voto, GamePlayed = numeroPartiteGiocate, GameWon = numeroPartiteVinte, Team = team };
    
    Player newPlayer2 = new Player { Name = "Philip", Surname = "Foden", score = voto, GamePlayed = numeroPartiteGiocate, GameWon = numeroPartiteVinte, Team = team };
    
    Player newPlayer3 = new Player { Name = "Kevin", Surname = "De Bruyne", score = voto, GamePlayed = numeroPartiteGiocate, GameWon = numeroPartiteVinte, Team = team };

    db.Add(newPlayer1);
    db.Add(newPlayer2);
    db.Add(newPlayer3);
    db.Add(team);

    db.SaveChanges();

    /*Player newPlayer = new Player { Name = "Kylian", Surname = "Mbappe", score = voto, GamePlayed = numeroPartiteGiocate, GameWon = numeroPartiteVinte , Team = team};
    db.Add(newPlayer);
    db.SaveChanges();*/

    /*List<Player> Players = db.Players.OrderBy(Player => Player.Name).ToList<Player>();*/

    /*newPlayer.Name = "Lionel";
    newPlayer.Surname = "Messi";
    db.SaveChanges();*/

    /*db.Remove(newPlayer);
    db.SaveChanges();*/
}


Console.WriteLine("Hello, World!");