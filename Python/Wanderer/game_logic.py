from entities import GameMap, Entity, Hero


class GameLogic:
    def __init__(self, canvasWidth, canvasHeight, mapWidth, mapHeight):
        self.gameMap = GameMap(canvasWidth, canvasHeight, mapWidth, mapHeight)

    def get_map_tiles_len(self):
        return len(list(x for x in self.game_all_entities() if type(x) is Entity))

    def get_hero(self):
        return self.game_all_entities()[self.get_hero_index()]

    def game_all_entities(self):
        return self.gameMap.entityContainer

    def game_ent_width(self):
        return int(self.gameMap.entityWidth)

    def game_ent_height(self):
        return int(self.gameMap.entityHeight)

    def populate_entities(self, inputHero):
        self.gameMap.entityContainer = []
        self.populate_tiles()
        self.populate_hero(inputHero)

    def populate_tiles(self):
        mapContainer = [x.strip() for x in open('src/map/MAPS.txt', encoding='utf-8-sig')]

        for i in range(int(self.gameMap.mapHeight / self.gameMap.entityHeight)):
            for j in range(int(self.gameMap.mapWidth / self.gameMap.entityWidth)):
                temp = Entity()
                temp.positionWidth = self.gameMap.mapOffSetWidth + (j * self.gameMap.entityWidth)
                temp.positionHeight = self.gameMap.mapOffSetHeight + (i * self.gameMap.entityHeight)

                if mapContainer[i][j] == '1':
                    self.gameMap.entityContainer.append(temp)
                else:
                    temp.canBePassed = False
                    self.gameMap.entityContainer.append(temp)

    def populate_hero(self, inputHero):
        hero = inputHero
        hero.positionWidth = self.gameMap.mapOffSetWidth
        hero.positionHeight = self.gameMap.mapOffSetHeight
        self.gameMap.entityContainer.append(hero)

    def get_hero_index(self):
        hero = next(x for x in self.gameMap.entityContainer if type(x) is Hero)
        heroIndex = self.gameMap.entityContainer.index(hero)

        return heroIndex

    def move_hero_horizontal(self, heroMoveWidth):
        if heroMoveWidth < 0:
            self.gameMap.entityContainer[self.get_hero_index()].facing = 'L'
        if heroMoveWidth > 0:
            self.gameMap.entityContainer[self.get_hero_index()].facing = 'R'

        selectedWidth = self.get_hero().positionWidth + heroMoveWidth

        selector = next((x for x in self.gameMap.entityContainer if x.positionWidth == selectedWidth and
                         x.positionHeight == self.get_hero().positionHeight and
                         x.canBePassed), 0)

        if type(selector) is Entity:
            self.gameMap.entityContainer[self.get_hero_index()].positionWidth += heroMoveWidth

    def move_hero_vertical(self, heroMoveHeight):
        if heroMoveHeight < 0:
            self.gameMap.entityContainer[self.get_hero_index()].facing = 'U'
        if heroMoveHeight > 0:
            self.gameMap.entityContainer[self.get_hero_index()].facing = 'D'

        selectedHeight = self.get_hero().positionHeight + heroMoveHeight

        selector = next((x for x in self.gameMap.entityContainer if x.positionHeight == selectedHeight and
                         x.positionWidth == self.get_hero().positionWidth and
                         x.canBePassed), 0)

        if type(selector) is Entity:
            self.gameMap.entityContainer[self.get_hero_index()].positionHeight += heroMoveHeight
