import pygame
import entities

pygame.init()

canvasWidth = 600
canvasHeight = 600
mapWidth = 500
mapHeight = 500

gameLandScape = entities.GameMap(canvasWidth, canvasHeight, mapWidth, mapHeight)

black = (0, 0, 0)
white = (255, 255, 255)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

floorImg = pygame.transform.scale(pygame.image.load('src/images/floor.gif'), (int(gameLandScape.entityWidth), int(gameLandScape.entityHeight)))
heroImg = pygame.transform.scale(pygame.image.load('src/images/hero-down.gif'), (int(gameLandScape.entityWidth), int(gameLandScape.entityHeight)))
wallImg = pygame.transform.scale(pygame.image.load('src/images/wall.gif'), (int(gameLandScape.entityWidth), int(gameLandScape.entityHeight)))


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def wall(x, y):
    gameDisplay.blit(wallImg, (x, y))


def hero(x, y):
    gameDisplay.blit(heroImg, (x, y))


def game_map():
    for i in range(len(gameLandScape.entityContainer)-1):
        if gameLandScape.entityContainer[i].canBePassed:
            floor(gameLandScape.entityContainer[i].positionWidth, gameLandScape.entityContainer[i].positionHeight)
        else:
            wall(gameLandScape.entityContainer[i].positionWidth, gameLandScape.entityContainer[i].positionHeight)
    hero(gameLandScape.entityContainer[100].positionWidth, gameLandScape.entityContainer[100].positionHeight)


gameExit = False

while not gameExit:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            gameExit = True
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_LEFT:
                gameLandScape.move_hero_horizontal(-gameLandScape.entityWidth)
            if event.key == pygame.K_RIGHT:
                gameLandScape.move_hero_horizontal(gameLandScape.entityHeight)
            if event.key == pygame.K_UP:
                gameLandScape.move_hero_vertical(-gameLandScape.entityHeight)
            if event.key == pygame.K_DOWN:
                gameLandScape.move_hero_vertical(gameLandScape.entityHeight)

        print(event)

    gameDisplay.fill(black)
    game_map()
    pygame.display.update()
    clock.tick(60)

pygame.quit()
