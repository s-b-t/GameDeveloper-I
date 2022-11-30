Enemy StormTrooper = new Enemy("Bobby");

Attack PlasmaRifle = new Attack("Plasma Rifle", 20);
Attack LightSaber = new Attack("Light Saber", 15);
Attack RoundhouseKick = new Attack("Roundhouse Kick", 10);

StormTrooper.AttackList.Add(PlasmaRifle);
StormTrooper.AttackList.Add(LightSaber);
StormTrooper.AttackList.Add(RoundhouseKick);

StormTrooper.RandomAttack();