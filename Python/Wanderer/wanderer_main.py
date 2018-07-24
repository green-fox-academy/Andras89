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

black = (0, 0, 0)
white = (255, 255, 255)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

floorImg = pygame.transform.scale(pygame.image.load('src/floor.gif'), (int(entityWidth), int(entityHeight)))
heroImg = pygame.transform.scale(pygame.image.load('src/hero-down.gif'), (int(entityWidth), int(entityHeight)))


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def hero(x, y):
    gameDisplay.blit(heroImg, (x, y))


def game_map():
    for i in range(10):
        for j in range(10):
            floor(mapOffSetWidth+(j * entityWidth), mapOffSetHeight+(i * entityHeight))


gameExit = False

while not gameExit:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            gameExit = True
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_LEFT:
                heroPosWidth -= entityWidth
            if event.key == pygame.K_RIGHT:
                heroPosWidth += entityWidth
            if event.key == pygame.K_UP:
                heroPosHeight -= entityHeight
            if event.key == pygame.K_DOWN:
                heroPosHeight += entityHeight

        print(event)

    gameDisplay.fill(black)
    game_map()
    hero(heroPosWidth, heroPosHeight)
    pygame.display.update()
    clock.tick(60)

pygame.quit()
