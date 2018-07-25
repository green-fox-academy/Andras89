import pygame

from entities import Hero
from game_logic import GameLogic

canvasWidth = 600
canvasHeight = 600
mapWidth = 500
mapHeight = 500

pygame.init()
logic = GameLogic(canvasWidth, canvasHeight, mapWidth, mapHeight)
logic.populate_entities(Hero())

black = (0, 0, 0)
white = (255, 255, 255)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()


def load_image(filePath):
    return pygame.transform.scale(pygame.image.load(filePath),
                                  logic.game_ent_width(), logic.game_ent_height())


heroImgDown = load_image('src/images/hero-down.gif')
heroImgUp = load_image('src/images/hero-up.gif')
heroImgLeft = load_image('src/images/hero-left.gif')
heroImgRight = load_image('src/images/hero-right.gif')
floorImg = load_image('src/images/floor.gif')
wallImg = load_image('src/images/wall.gif')
skeletonImg = load_image('src/images/skeleton.gif')
bossImg = load_image('src/images/boss.gif')


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def wall(x, y):
    gameDisplay.blit(wallImg, (x, y))


def hero(x, y):
    if logic.get_hero().facing == 'L':
        gameDisplay.blit(heroImgLeft, (x, y))
    elif logic.get_hero().facing == 'R':
        gameDisplay.blit(heroImgRight, (x, y))
    elif logic.get_hero().facing == 'U':
        gameDisplay.blit(heroImgUp, (x, y))
    else:
        gameDisplay.blit(heroImgDown, (x, y))


def game_map():
    for i in range(logic.get_map_tiles_len()):
        if logic.game_all_entities()[i].canBePassed:
            floor(logic.game_all_entities()[i].positionWidth, logic.game_all_entities()[i].positionHeight)
        else:
            wall(logic.game_all_entities()[i].positionWidth, logic.game_all_entities()[i].positionHeight)
    hero(logic.get_hero().positionWidth, logic.get_hero().positionHeight)


def game_loop():
    gameExit = False

    while not gameExit:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                gameExit = True

            print(event)

        keys = pygame.key.get_pressed()
        if keys[pygame.K_LEFT]:
            logic.move_hero_horizontal(-logic.game_ent_width())
        if keys[pygame.K_RIGHT]:
            logic.move_hero_horizontal(logic.game_ent_width())
        if keys[pygame.K_UP]:
            logic.move_hero_vertical(-logic.game_ent_height())
        if keys[pygame.K_DOWN]:
            logic.move_hero_vertical(logic.game_ent_height())

        gameDisplay.fill(black)
        game_map()
        pygame.display.update()
        clock.tick(9)
