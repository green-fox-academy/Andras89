import pygame

pygame.init()

canvasWidth = 720
canvasHeight = 720

white = (0, 0, 0)

gameDisplay = pygame.display.set_mode((canvasWidth, canvasHeight))
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

floorImg = pygame.image.load('src/floor.gif')


def floor(x, y):
    gameDisplay.blit(floorImg, (x, y))


def map():
    for i in range(10):
        for j in range(10):
            floor(j * 72, i * 72)


gameExit = False

while not gameExit:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            gameExit = True

        print(event)

    gameDisplay.fill(white)
    map()
    pygame.display.update()
    clock.tick(60)

pygame.quit()
