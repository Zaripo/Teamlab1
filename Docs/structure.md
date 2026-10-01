# Структура проекта

## Сцены проекта

| Название сцены | Путь | Краткое описание|
| TopDownDemo | Assets/IndieMarc/TopDownDemo/TopDownDemo.unity | Игровая сцена: игрок, освещение, полы, стенки, ключи, рычаги, тени, двери, трава |
| TopDownDemo3D | Assets/IndieMarc/TopDownDemo/TopDownDemo3D.unity | Игровая сцена: игрок, освещение, полы, стенки, ключи, рычаги, тени, двери, трава | 

## Основная игровая сцена: TopDownDemo

### Все объекты на сцене

| Объект | Является префабом? | Примечание |
| Main Camera | Нет | Следует за игроком | 
| Lights | Нет | Освещение сцены | 
| Player | Да | Управляем персонаж |
| Floor | Да | Статичный пол | 
| Key | Да | ключ для открытия дверей | 
| Wall | Да | Статичная стена | 
| Lever | Да | Рычаг для открыания дверей | 
| Grass | Да | Трава как украшение сцены | 
| Door | Да | Открывается при задеваниее персонажа ключа или рычага | 
| Shadow | Да | Тень как украшение на сцене | 

### Объект Player

| Компонент | Параметры | 
| Transform | Position, Rotation, Scale | 
| Sprite Renderer | Sprite, Color, Flip, Draw mode, Mask Interaction, Sprite Sort Point, Material |
| Animator | Controller, Avatar, Apply Root Motion, Animate Physics, Update mode, Culling Mode | 
| Rigidbody2D | Body Type, Material, Simulated, Use auto Mass, Mass, liner Damping, Angular Damping, Gravity Scale |
| Capsule Collider 2D | Material, Is trigger, Used By Effector, Composite Operation, Offset, size, Direction | 
| Player Character (Script) | Player_id, Max_hp, Move_accel, Move_deccel, Move_max |
| Auto Order Layer (Script) | Offset, Sort_refresh_rate, Rotate_offset | 
| Character Anim (Script) | Script | 
| Character Hold Item (Script) | Script, Hand | 

### Скрипты проекта

| Скрипт | Где прикреплен | Что делает | 
| AutoOrderLayer | Player | Управляет слоем объектов, как персонаж находиться относительно объекта взади или спереди |
| AutoOrderLayerChild | Player | Тоже самое, но для других предметов |
| CarryItem | Player | Носить предмет в руке |
| CharacterAnim | Player | Анимация хотьбы персонажа | 
| CharacterHoldItem | Player | Держать пермдет | 
| Door | Door | Открывает и закрывает двери |
| FixOffset | Maincamera | Отвечате за фикс движения камеры | 
| FollowCamera | Maincamera | Движение камеры в след за персонажем | 
| Key | Key | отвечает за взаимодействие ключа | 
| Lever | Lever | отвечает за взаимодействия рычага |
| PlayerCharacter | Player | осн скрипт персонажа отвечает за его свойства |
| PlayerControls | Player | Отвечает за движение персонажа |
| TheAudio | Прикреплен к многим предметам | отвечает за звук |