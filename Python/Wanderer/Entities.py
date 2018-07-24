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
        self.hero = Character()

    def populate_entities(self):
        mapContainer = [x.rstrip() for x in open('src/map/MAPS.txt')]
        entities = []

        for i in range(10):
            for j in range(10):
                if mapContainer[i][j] == 1:
                    temp = Entity()
                    temp.positionWidth = self.mapOffSetWidth + (j * self.entityWidth)
                    temp.positionHeight = self.mapOffSetHeight + (i * self.entityHeight)
                    entities.append(temp)
                else:
                    temp = Entity()
                    temp.positionWidth = self.mapOffSetWidth + (j * self.entityWidth)
                    temp.positionHeight = self.mapOffSetHeight + (i * self.entityHeight)
                    temp.canBePassed = False
                    entities.append(temp)

        return entities


gameScape = GameMap(600, 600, 500, 500)
