class Entity:
    def __init__(self):
        self.canmove = False
        self.canbepassed = True
        self.positionwidth = 0
        self.positionheigth = 0


class Character(Entity):
    def __init__(self):
        self.canmove = True
        self.canbepassed = True
        self.positionwidth = 0
        self.positionheigth = 0
