import pygame

pygame.init()

canvasWidth = 600
canvasHeight = 600
mapWidth = 500
mapHeight = 500
entityWidth = mapWidth/10
entityHeight = mapHeight/10
mapOffSetWidth = (canvasWidth - mapWidth)/2
mapOffSetHeight = (canvasHeight - mapHeight)/2
heroPosWidth = mapOffSetWidth
heroPosHeight = mapOffSetHeight

white = (0, 0, 0)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

floorImg = pygame.transform.scale(pygame.image.load('src/floor.gif'), (int(entityWidth), int(entityHeight)))
heroImg = pygame.transform.scale(pygame.image.load('src/hero-down.gif'), (int(entityWidth), int(entityHeight)))


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def hero(x, y):
    gameDisplay.blit(heroImg, (x, y))


def gameMap():
    for i in range(10):
        for j in range(10):
            floor(mapOffSetWidth+(j * entityWidth), mapOffSetHeight+(i * entityHeight))


gameExit = False

while not gameExit:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            gameExit = True

        print(event)

    gameDisplay.fill(white)
    gameMap()
    hero(heroPosWidth, heroPosHeight)
    pygame.display.update()
    clock.tick(60)

pygame.quit()
