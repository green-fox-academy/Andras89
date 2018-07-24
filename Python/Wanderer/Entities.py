class Entity:
    def __init__(self):
        self.canMove = False
        self.canBePassed = True
        self.positionWidth = 0
        self.positionHeight = 0


class Character(Entity):
    def __init__(self):
        self.canMove = True
        self.canBePassed = True
        self.positionWidth = 0
        self.positionHeight = 0


class GameMap:
    def __init__(self, canvasWidth, canvasHeight, mapWidth, mapHeight):
        self.canvasWidth = canvasWidth
        self.canvasHeight = canvasHeight
        self.mapWidth = mapWidth
        self.mapHeight = mapHeight
        self.entityWidth = mapWidth / 10
        self.entityHeight = mapHeight / 10
        self.mapOffSetWidth = (canvasWidth - mapWidth) / 2
        self.mapOffSetHeight = (canvasHeight - mapHeight) / 2
        self.entityContainer = self.populate_entities()

    def populate_entities(self):
        mapContainer = [x.strip() for x in open('src/map/MAPS.txt', encoding='utf-8')]
        entities = []

        for i in range(10):
            for j in range(10):
                temp = Entity()
                temp.positionWidth = self.mapOffSetWidth + (j * self.entityWidth)
                temp.positionHeight = self.mapOffSetHeight + (i * self.entityHeight)

                if mapContainer[i][j] == '1':
                    entities.append(temp)
                else:
                    temp.canBePassed = False
                    entities.append(temp)
        entities = self.populate_hero(entities)

        return entities

    def populate_hero(self, entities):
        hero = Character()
        hero.positionWidth = self.mapOffSetWidth
        hero.positionHeight = self.mapOffSetHeight
        entities.append(hero)

        return entities

    def move_hero_horizontal(self, heroMoveWidth):
        heroPosWidth = self.entityContainer[100].positionWidth
        heroPosHeight = self.entityContainer[100].positionHeight
        selectedWidth = heroPosWidth + heroMoveWidth

        descisor = next((x for x in self.entityContainer if x.positionWidth == selectedWidth and
                         x.positionHeight == heroPosHeight and
                         x.canBePassed), 0)

        if type(descisor) is Entity:
            self.entityContainer[100].positionWidth += heroMoveWidth


gameScape = GameMap(600, 600, 500, 500)
gameScape.move_hero_horizontal(50)
