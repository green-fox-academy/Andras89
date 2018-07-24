import pygame
import entities

pygame.init()

canvasWidth = 600
canvasHeight = 600
mapWidth = 500
mapHeight = 500

gM = entities.GameMap(canvasWidth, canvasHeight, mapWidth, mapHeight)

black = (0, 0, 0)
white = (255, 255, 255)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

floorImg = pygame.transform.scale(pygame.image.load('src/images/floor.gif'), (int(gM.entityWidth), int(gM.entityHeight)))
heroImg = pygame.transform.scale(pygame.image.load('src/images/hero-down.gif'), (int(gM.entityWidth), int(gM.entityHeight)))
wallImg = pygame.transform.scale(pygame.image.load('src/images/wall.gif'), (int(gM.entityWidth), int(gM.entityHeight)))


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def wall(x, y):
    gameDisplay.blit(wallImg, (x, y))


def hero(x, y):
    gameDisplay.blit(heroImg, (x, y))


def game_map():
    for i in range(len(gM.entityContainer) - 1):
        if gM.entityContainer[i].canBePassed:
            floor(gM.entityContainer[i].positionWidth, gM.entityContainer[i].positionHeight)
        else:
            wall(gM.entityContainer[i].positionWidth, gM.entityContainer[i].positionHeight)
    hero(gM.entityContainer[gM.get_hero_index()].positionWidth, gM.entityContainer[gM.get_hero_index()].positionHeight)


gameExit = False

while not gameExit:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            gameExit = True
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_LEFT:
                gM.move_hero_horizontal(-gM.entityWidth)
            if event.key == pygame.K_RIGHT:
                gM.move_hero_horizontal(gM.entityHeight)
            if event.key == pygame.K_UP:
                gM.move_hero_vertical(-gM.entityHeight)
            if event.key == pygame.K_DOWN:
                gM.move_hero_vertical(gM.entityHeight)

        print(event)

    gameDisplay.fill(black)
    game_map()
    pygame.display.update()
    clock.tick(60)

pygame.quit()
