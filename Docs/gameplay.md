# Геймплей проекта

## Физические параметры



### Глобальная гравитация отсутсвует







### Объекты с Rigidbody2D



|Объект|Mass|Gravity Scale|Linear Drag|Angular Drag|Collision Detection|
|-|-|-|-|-|-|
|CharacterTopDown|10|0|1|1|Continuous|

### 

### Physics Material 2D оригинальный не изменённый от unity



## Префабы



### Препятствия



|Префаб|Компоненты|
|-|-|
|wall|BoxCollider2D|
|door|BoxCollider2D, door script, Audio Source|
|Keydoor|BoxCollider2D, door script, Audio Source|
|lever|BoxCollider2D, rigidbody 2d, carry scrip lever script|



UI в игре отсутствует


### Бонусы

|Префаб|Компоненты|Эффект|
|-|-|-|
|key|CircleCollider2D (Is Trigger), script key, carry|подбирает ключ, ключ исчезает|

## Параметры, влияющие на сложность или игру



|Параметр|Где|Влияние|
|-|-|-|
|Speed|PlayerController|Скорость игрока|
|key index|Door|привязка айди ключа к двери|
|key value|Key|привязка яйди к ключу|
|door value|Lever|привязка яйди двери к рычагу|

