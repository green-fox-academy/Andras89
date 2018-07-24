class Entity:
    def __init__(self):
        self.canMove = False
        self.canBePassed = True
        self.positionWidth = 0
        self.positionHeight = 0


class Character(Entity):
    def __init__(self):
        super().__init__()
        self.canMove = True


class Hero(Character):
    def __init__(self):
        super().__init__()
        self.facing = 'D'


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
        self.entityContainer = []
