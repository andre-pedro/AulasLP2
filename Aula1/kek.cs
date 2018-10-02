class FNPlayer {
	string equippedWeapon;
	double hitPoints;
	double shield;

	
	void Attack(FNPlayer enemy) {
		enemy.TakeDamage(10);
	}
	
	void TakeDamage(double damage) {
		if (shield > 0) {
			shield -= damage;
			if (shield < 0) {
				shield = 0;
			}				
		} else {
			hitPoints -= damage;
			if (hitPoints <= 0) {
				Die();
			}
		}
	}

}