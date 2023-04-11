using Blockcraft;

DiamondPick diamondPick = new DiamondPick(1);

Enemy goblin = new Enemy();

Player paula = new Player(diamondPick);

DealDamage dealDamage = new DealDamage(goblin, paula);

dealDamage.Attack();
dealDamage.Attack();

Console.WriteLine(goblin.getHealth());



