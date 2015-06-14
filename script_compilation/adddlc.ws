import function additem( itemName : CName,  optional  count : Int32,  optional  equip : Bool);  // flags: 258 

exec function addtemdlc() {
	additem('DLC1 Temerian Armor');
	additem('DLC1 Temerian Boots');
	additem('DLC1 Temerian Gloves');
	additem('DLC1 Temerian Pants');
}

exec function addtemngp()
{
	additem('NGP DLC1 Temerian Armor');
	additem('NGP DLC1 Temerian Boots');
	additem('NGP DLC1 Temerian Gloves');
	additem('NGP DLC1 Temerian Pants');
}

exec function addtemhorse()
{
	additem('DLC1 Temerian HorseBag');
	additem('DLC1 Temerian HorseBlinders');
	additem('DLC1 Temerian HorseSaddle');
}

exec function addnilfdlc()
{
	additem('DLC5 Nilfgaardian Armor');
	additem('DLC5 Nilfgaardian Boots');
	additem('DLC5 Nilfgaardian Gloves');
	additem('DLC5 Nilfgaardian Pants');
}

exec function addnilfngp()
{
	additem('NGP DLC5 Nilfgaardian Armor');
	additem('NGP DLC5 Nilfgaardian Boots');
	additem('NGP DLC5 Nilfgaardian Gloves');
	additem('NGP DLC5 Nilfgaardian Pants');
}

exec function addnilfhorse()
{
	additem('DLC5 Nilfgaardian HorseBag');
	additem('DLC5 Nilfgaardian HorseBlinders');
	additem('DLC5 Nilfgaardian HorseSaddle');
}

exec function adddlccrossbow(){
	additem('DLC13 Elven Crossbow');
	additem('DLC13 Skellige Crossbow');
	additem('DLC13 Nilfgaardian Crossbow');
}