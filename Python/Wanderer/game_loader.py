import pygame
import entities

canvasWidth = 600
canvasHeight = 600
mapWidth = 500
mapHeight = 500

pygame.init()
gM = entities.GameMap(canvasWidth, canvasHeight, mapWidth, mapHeight)

black = (0, 0, 0)
white = (255, 255, 255)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

heroImgDown = pygame.transform.scale(pygame.image.load('src/images/hero-down.gif'),
                                     (int(gM.entityWidth), int(gM.entityHeight)))
heroImgUp = pygame.transform.scale(pygame.image.load('src/images/hero-up.gif'),
                                   (int(gM.entityWidth), int(gM.entityHeight)))
heroImgLeft = pygame.transform.scale(pygame.image.load('src/images/hero-left.gif'),
                                     (int(gM.entityWidth), int(gM.entityHeight)))
heroImgRight = pygame.transform.scale(pygame.image.load('src/images/hero-right.gif'),
                                      (int(gM.entityWidth), int(gM.entityHeight)))
floorImg = pygame.transform.scale(pygame.image.load('src/images/floor.gif'),
                                  (int(gM.entityWidth), int(gM.entityHeight)))
wallImg = pygame.transform.scale(pygame.image.load('src/images/wall.gif'),
                                 (int(gM.entityWidth), int(gM.entityHeight)))


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def wall(x, y):
    gameDisplay.blit(wallImg, (x, y))


def hero(x, y):
    if gM.entityContainer[gM.get_hero_index()].facing == 'L':
        gameDisplay.blit(heroImgLeft, (x, y))
    elif gM.entityContainer[gM.get_hero_index()].facing == 'R':
        gameDisplay.blit(heroImgRight, (x, y))
    elif gM.entityContainer[gM.get_hero_index()].facing == 'U':
        gameDisplay.blit(heroImgUp, (x, y))
    else:
        gameDisplay.blit(heroImgDown, (x, y))


def game_map():
    for i in range(len(list(x for x in gM.entityContainer if type(x) is entities.Entity))):
        if gM.entityContainer[i].canBePassed:
            floor(gM.entityContainer[i].positionWidth, gM.entityContainer[i].positionHeight)
        else:
            wall(gM.entityContainer[i].positionWidth, gM.entityContainer[i].positionHeight)
    hero(gM.entityContainer[gM.get_hero_index()].positionWidth, gM.entityContainer[gM.get_hero_index()].positionHeight)


def game_loop():
    gameExit = False

    while not gameExit:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                gameExit = True

            print(event)

        keys = pygame.key.get_pressed()
        if keys[pygame.K_LEFT]:
            gM.move_hero_horizontal(-gM.entityWidth)
        if keys[pygame.K_RIGHT]:
            gM.move_hero_horizontal(gM.entityHeight)
        if keys[pygame.K_UP]:
            gM.move_hero_vertical(-gM.entityHeight)
        if keys[pygame.K_DOWN]:
            gM.move_hero_vertical(gM.entityHeight)

        gameDisplay.fill(black)
        game_map()
        pygame.display.update()
        clock.tick(9)
